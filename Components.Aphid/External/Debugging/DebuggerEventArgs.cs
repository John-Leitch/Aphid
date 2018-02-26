using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Components.PInvoke;
using System.ComponentModel;
using System.IO;

namespace Components.Cypress
{
    public class DebuggerEventArgs : EventArgs
    {
        public IntPtr ProcessHandle { get; private set; }

        public DEBUG_EVENT DebugEvent { get; private set; }

        public byte[] FaultingInstructions { get; private set; }

        public string InstructionHash { get; private set; }

        public ProcessMemory Memory { get; private set; }

#if FULL_DBG
        public BreakpointManager Breakpoints { get; private set; }

        public HookManager Hooks { get; private set; }
#endif

        public DebuggerEventArgs(
            IntPtr processHandle, 
            byte[] faultingInstructions,
            string instructionHash, 
            DEBUG_EVENT debugEvent,
            ProcessMemory memory
#if FULL_DBG
            ,
            BreakpointManager breakpoints,
            HookManager hooks
#endif
            )
        {
            ProcessHandle = processHandle;
            FaultingInstructions = faultingInstructions;
            InstructionHash = instructionHash;
            DebugEvent = debugEvent;
            Memory = memory;
#if FULL_DBG
            Breakpoints = breakpoints;
            Hooks = hooks;
#endif

        }

        private string GetExceptionMessage(uint exceptionCode)
        {
            var msg = new Win32Exception((int)exceptionCode).Message.Replace(' ', '_');

            foreach (var c in Path.GetInvalidFileNameChars())
            {
                msg = msg.Replace(c, '$');
            }

            return msg;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            switch (DebugEvent.Exception.ExceptionRecord.ExceptionCode)
            {
                case ExceptionCode.EXCEPTION_BREAKPOINT:
                    sb.Append(ExceptionType.Breakpoint + "_");
                    break;

                case ExceptionCode.EXCEPTION_ACCESS_VIOLATION:
                    switch (DebugEvent.Exception.ExceptionRecord.ExceptionInformation[0])
                    {
                        case AccessViolationFlag.Read:
                            sb.Append(ExceptionType.ReadAV);
                            break;

                        case AccessViolationFlag.Write:
                            sb.Append(ExceptionType.WriteAV);
                            break;

                        case AccessViolationFlag.Dep:
                            sb.Append(ExceptionType.DepAV);
                            break;

                        default:
                            sb.Append(ExceptionType.UnknownAV);
                            break;
                    }

                    sb.Append("_");

                    var address = DebugEvent.Exception.ExceptionRecord.ExceptionInformation[1];

                    if (address == 0)
                    {
                        sb.Append("Null_");
                    }
                    else if (address < 100)
                    {
                        sb.Append("NearNull_");
                    }

                    break;

                default:
                    var msg = GetExceptionMessage(DebugEvent.Exception.ExceptionRecord.ExceptionCode);
                    sb.AppendFormat("{0}_{1}_", ExceptionType.Exception, msg);
                    break;
            }

            sb.Append(DebugEvent.Exception.dwFirstChance == 1 ? "FC_" : "SC_");            
            sb.Append(InstructionHash);
            
            return sb.ToString();
        }
    }
}
