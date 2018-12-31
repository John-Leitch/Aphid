using System;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Components.PInvoke;

namespace Components.Cypress
{
    public class NativeDebugger
    {
        public event EventHandler<DebuggerEventArgs> DebugEventReceived;
        public event EventHandler Killing;

#if FULL_DBG
        private Dictionary<IntPtr, HookManager> _hookManagers = new Dictionary<IntPtr, HookManager>();
        private Dictionary<IntPtr, BreakpointManager> _breakpointManagers = new Dictionary<IntPtr, BreakpointManager>();
        private Dictionary<IntPtr, string> _breakpointModules = new Dictionary<IntPtr, string>();
        private Dictionary<IntPtr, IntPtr> _breakpointBases = new Dictionary<IntPtr, IntPtr>();
#endif
        private Dictionary<IntPtr, string> _moduleTable = new Dictionary<IntPtr, string>();
        private Thread _debugThread = null;
        private bool _killProcesses = false;
        private Dictionary<IntPtr, ProcessMemory> _readers;
        private Dictionary<uint, bool> _loaderBreakpointTable = new Dictionary<uint, bool>();
        private Dictionary<uint, Process> _processTable = new Dictionary<uint, Process>();

        public bool IsStarted { get; set; }
        public bool HideWindows { get; set; }
        public bool CreateNewConsole { get; set; }
        public bool HashException { get; set; }
        public int HashSize { get; set; }
        public List<DebugProcess> Processes { get; private set; }
        public DateTime StartTime { get; private set; }
        public int Timeout { get; set; }
        public bool ReadFaultingInstructions { get; set; }

        public NativeDebugger()
        {
            HashSize = 32;
            HashException = true;
            Processes = new List<DebugProcess>();
            ReadFaultingInstructions = true;
            _readers = new Dictionary<IntPtr, ProcessMemory>();

            if (!EnvironmentHelper.IsX86())
            {
                throw new NotImplementedException("NativeDebugger only supports x86.");
            }
        }

        private DebugProcess FindProcess(IEnumerable<DebugProcess> processes, uint id)
        {
            var p = processes.SingleOrDefault(x =>
            {
                try
                {
                    return x.Process.Id == (int)id;
                }
                catch 
                {
                    return false;
                }
            });
            if (p != null)
            {
                return p;
            }
            else
            {
                foreach (var p2 in processes)
                {
                    p = FindProcess(p2.Children, id);
                    if (p != null)
                    {
                        return p;
                    }
                }
            }
            return null;
        }

        private void AddProcess(uint id)
        {
            if (_processTable.ContainsKey(id))
            {
                return;
            }
            var p = Process.GetProcessById((int)id);
            _processTable.Add(id, p);
            DebugProcess parent;
            try
            {
                parent = FindProcess(Processes, (uint)p.GetParentId());
            }
            catch
            {
                parent = null;
            }
            var dp = new DebugProcess(p, parent);
            if (parent != null)
            {
                parent.Children.Add(dp);
            }
            else
            {
                Processes.Add(dp);
            }
            
        }

        private void RemoveProcess(uint id)
        {
            _processTable.Remove(id);
            var p = FindProcess(Processes, id);
            if (p != null)
            {
                var procList = p.Parent == null ? Processes : p.Parent.Children;
                if (p.Children.Any(x =>
                {
                    try
                    {
                        return !x.Process.HasExited;
                    }
                    catch
                    {
                        return false;
                    }
                }))
                {
                    procList.AddRange(p.Children);
                }

                procList.Remove(p);
                p.Process.Dispose();
            }
        }

        private void LockProcesses(Action action)
        {
            lock (Processes)
            {
                lock (_processTable)
                {
                    action();
                }
            }
        }

        public void Detach()
        {
            foreach (var p in Processes)
            {
                Detach(p);
            }
        }

        public void Detach(DebugProcess process)
        {
            foreach (var p in process.Children)
            {
                Detach(p);
            }

            DetachNode(process);
        }

        private void DetachNode(DebugProcess process)
        {
            var result = Kernel32.DebugActiveProcessStop((uint)process.Process.Id);

            if (!result)
            {
                throw new InvalidOperationException("Could not detach");
            }

            lock (_loaderBreakpointTable)
            {
                _loaderBreakpointTable.Remove((uint)process.Process.Id);
            }
        }

        public void Kill()
        {
            if (Killing != null)
            {
                Killing(this, new EventArgs());
            }

            LockProcesses(() =>
            {
                _killProcesses = true;
                foreach (var p in Processes)
                {
                    Kill(p);
                }
            });
        }

        private void Kill(DebugProcess process)
        {
            foreach (var p in process.Children)
            {
                Kill(p);
            }

            try
            {
                DetachNode(process);
            }
            catch { }

            try
            {
                process.Process.Kill();
            }
            catch { }
            
            process.Process.WaitForExit();
        }

        private ulong CreateInstructionHash(IEnumerable<byte> instructions)
        {
            unchecked
            {
                return instructions
                    .Select((x, i) => ((ulong)x) * ((ulong)i + 1))
                    .Aggregate(1ul, (a, x) => (a + 1) * (x + 1));
            }
        }

        private string GetExceptionHash(Process process, DEBUG_EVENT debugEvent)
        {
            var dumper = new StackDumper(process.Handle, debugEvent.dwThreadId);
            
            var functionPointers = dumper.GetFunctionPointers();

            if (functionPointers == null)
            {
                return "ERROR_" + (ushort)(debugEvent.Exception.ExceptionRecord.ExceptionAddress & 0xFFFF);
            }

            if (functionPointers.Count == 0 || 
                functionPointers[0] != debugEvent.Exception.ExceptionRecord.ExceptionAddress)
            {
                functionPointers.Insert(0, debugEvent.Exception.ExceptionRecord.ExceptionAddress);
            }

            var fp2 = functionPointers.Select(x => (ushort)(x & 0xFFFF)).Take(4).ToArray();

            return string.Join("", fp2.Select(x => string.Format("{0:X4}", x)));
        }

        public ProcessMemory GetMemory(IntPtr processHandle)
        {
            lock (_readers)
            {
                ProcessMemory mem;

                if (!_readers.TryGetValue(processHandle, out mem))
                {
                    _readers.Add(processHandle, mem = new ProcessMemory(processHandle));
                }

                return mem;
            }
        }

        public void ProcessDebugEvents()
        {
            IsStarted = true;
            var debugEvent = new DEBUG_EVENT();

            while (!_killProcesses && IsStarted && Processes.Count != 0)
            {
                if (!Kernel32.WaitForDebugEvent(ref debugEvent, 200))
                {
                    var error = Marshal.GetLastWin32Error();

                    //if (error == 121 || _killProcesses)
                    /*if (_killProcesses)
                    {
                        KillCore();
                        break;
                    }
                    else */if (error != 121)
                    {
                        throw new Win32Exception(error);
                    }
                    else
                    {
                        if (Timeout > 0 &&
                            (DateTime.Now - StartTime).TotalMilliseconds > Timeout)
                        {
                            Kill();
                            
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                Process p = null;
                
                LockProcesses(() =>
                {
                    if (_processTable.ContainsKey(debugEvent.dwProcessId))
                    {
                        p = _processTable[debugEvent.dwProcessId];
                    }
                });

                byte[] buffer = null;
                string hash = "[NO HASH]";

                switch (debugEvent.dwDebugEventCode)
                {
                    case DebugEventType.CREATE_PROCESS_DEBUG_EVENT:
                        if (p != null)
                        {
                            var mem = new ProcessMemory(p.Handle);
                            lock (_readers)
                            {
                                _readers.Add(p.Handle, mem);
                            }

#if FULL_DBG
                            if (!_hookManagers.ContainsKey(p.Handle))
                            {
                                _hookManagers.Add(p.Handle, new HookManager(mem));
                                _breakpointManagers.Add(p.Handle, new BreakpointManager(mem));
                            }
#endif
                        }
                        lock (_loaderBreakpointTable)
                        {
                            if (!_loaderBreakpointTable.ContainsKey(debugEvent.dwProcessId))
                            {
                                _loaderBreakpointTable.Add(debugEvent.dwProcessId, false);
                            }
                        }
                        LockProcesses(() =>
                        {
                            AddProcess(debugEvent.dwProcessId);
                            p = _processTable[debugEvent.dwProcessId];
                        });
                        Kernel32.CloseHandle(debugEvent.CreateProcessInfo.hFile);
                        break;

                    case DebugEventType.EXIT_PROCESS_DEBUG_EVENT:
                        lock (_loaderBreakpointTable)
                        {
                            if (_loaderBreakpointTable.ContainsKey(debugEvent.dwProcessId))
                            {
                                _loaderBreakpointTable.Remove(debugEvent.dwProcessId);
                            }
                        }

                        LockProcesses(() => RemoveProcess(debugEvent.dwProcessId));

                        if (p != null)
                        {
                            lock (_readers)
                            {
                                try
                                {
                                    // Swallow exceptions caused by accessing Process.Handle after
                                    // process has exited.
                                    _readers.Remove(p.Handle);
                                }
                                catch { }
                            }
                        }
                        break;

                    case DebugEventType.LOAD_DLL_DEBUG_EVENT:
                        Kernel32.CloseHandle(debugEvent.LoadDll.hFile);
                        break;

                    case DebugEventType.EXCEPTION_DEBUG_EVENT:
                        lock (_loaderBreakpointTable)
                        {
                            if (debugEvent.Exception.ExceptionRecord.ExceptionCode == ExceptionCode.EXCEPTION_BREAKPOINT)
                            {
                                if (!_loaderBreakpointTable.ContainsKey(debugEvent.dwProcessId))
                                    _loaderBreakpointTable.Add(debugEvent.dwProcessId, false);

                                if (!_loaderBreakpointTable[debugEvent.dwProcessId])
                                {
                                    _loaderBreakpointTable[debugEvent.dwProcessId] = true;

                                    debugEvent.ContinueUnhandled();
                                    continue;
                                }
                            }
                        }

                        if (p != null)
                        {
                            if (HashException)
                            {
                                hash = GetExceptionHash(p, debugEvent);
                            }

                            if (ReadFaultingInstructions)
                            {
                                buffer = new byte[32];
                                int bytesRead;

                                IntPtr exPtr = IntPtr.Zero;

                                try
                                {
                                    exPtr = (IntPtr)debugEvent.Exception.ExceptionRecord.ExceptionAddress;
                                }
                                catch (OverflowException)
                                {

                                }

                                if (Kernel32.ReadProcessMemory(
                                    p.Handle,
                                    exPtr,
                                    buffer,
                                    buffer.Length,
                                    out bytesRead))
                                {
                                    if (bytesRead < buffer.Length)
                                    {
                                        Array.Resize(ref buffer, bytesRead);
                                    }
                                }
                                else
                                {
                                    buffer = null;
                                }

                                    //hash = CreateInstructionHash(buffer.Take(HashSize));
                            }
                        }
                        //elser
                        //{
                        //    throw new InvalidOperationException();
                        //}

                        break;
                }

                if (DebugEventReceived != null)
                {
                    IntPtr handle;
                    try
                    {
                        handle = p != null ? p.Handle : IntPtr.Zero;
                    }
                    catch
                    {
                        handle = IntPtr.Zero;
                    }

#if FULL_DBG
                    BreakpointManager breakpoints;
                    if (!_breakpointManagers.TryGetValue(handle, out breakpoints))
                    {
                        _breakpointManagers.Add(handle, breakpoints = new BreakpointManager(GetMemory(handle)));
                    }
                    HookManager hooks;
                    if (!_hookManagers.TryGetValue(handle, out hooks))
                    {
                        _hookManagers.Add(handle, hooks = new HookManager(GetMemory(handle)));
                    }
#endif
                    DebugEventReceived(this,
                        new DebuggerEventArgs(
                            handle,
                            buffer, 
                            hash, 
                            debugEvent, 
                            GetMemory(handle)
#if FULL_DBG
                            ,
                            breakpoints,
                            hooks
#endif
                            ));
                }

                if (Timeout > 0 &&
                            (DateTime.Now - StartTime).TotalMilliseconds > Timeout)
                {
                    Kill();

                    return;
                }
            }

            //KillCore();
        }

        public void StartProcess(string command, EventHandler<DebuggerEventArgs> handler)
        {
            DebugEventReceived += handler;
            StartProcess(command);
            DebugEventReceived -= handler;
        }

        public void StartProcess(string command)
        {
            StartTime = DateTime.Now;
            Kernel32.DebugSetProcessKillOnExit(true);
            _debugThread = Thread.CurrentThread;
            var pi = new PROCESS_INFORMATION();

            var si = new STARTUPINFO()
            {
                cb = Marshal.SizeOf(typeof(STARTUPINFO))
            };

            var creationFlags = ProcessCreationFlags.DEBUG_PROCESS;

            if (CreateNewConsole)
            {
                creationFlags |= ProcessCreationFlags.CREATE_NEW_CONSOLE;
            }

            if (HideWindows)
            {
                creationFlags |= ProcessCreationFlags.CREATE_NO_WINDOW;
                si.dwFlags = 1; // STARTF_USESHOWWINDOW
            }

            if (!Kernel32.CreateProcess(
                null,
                command,
                IntPtr.Zero,
                IntPtr.Zero,
                false,
                creationFlags,
                IntPtr.Zero,
                null,
                si,
                pi))
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            LockProcesses(() => AddProcess(pi.dwProcessId));
            ProcessDebugEvents();
            //Kernel32.CloseHandle(si.hStdError);
            //Kernel32.CloseHandle(si.hStdInput);
            //Kernel32.CloseHandle(si.hStdOutput);
            Kernel32.CloseHandle(pi.hThread);
            Kernel32.CloseHandle(pi.hProcess);
        }

        public void Attach(params int[] processIds)
        {
            _debugThread = Thread.CurrentThread;

            LockProcesses(() =>
            {
                foreach (var processId in processIds)
                {
                    var pid = (uint)processId;
                    AddProcess(pid);

                    if (!Kernel32.DebugActiveProcess(pid))
                    {
                        var error = Marshal.GetLastWin32Error();
                        throw new Win32Exception(error);
                        throw new InvalidOperationException("Could not attach to process.");
                    }
                }
            });

            Kernel32.DebugSetProcessKillOnExit(false);
            ProcessDebugEvents();
        }

#if FULL_DBG
        public BreakpointManager[] GetBreakpoints()
        {
            return _breakpointManagers.Select(x => x.Value).ToArray();
        }
#endif
    }
}
