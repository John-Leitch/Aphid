namespace Components.PInvoke
{
    public enum DebugEventType : int
    {
        EXCEPTION_DEBUG_EVENT = 1, //Reports an exception debugging event. The value of u.Exception specifies an EXCEPTION_DEBUG_INFO structure.
        CREATE_THREAD_DEBUG_EVENT = 2, //Reports a create-thread debugging event. The value of u.CreateThread specifies a CREATE_THREAD_DEBUG_INFO structure.
        CREATE_PROCESS_DEBUG_EVENT = 3, //Reports a create-process debugging event. The value of u.CreateProcessInfo specifies a CREATE_PROCESS_DEBUG_INFO structure.
        EXIT_THREAD_DEBUG_EVENT = 4, //Reports an exit-thread debugging event. The value of u.ExitThread specifies an EXIT_THREAD_DEBUG_INFO structure.
        EXIT_PROCESS_DEBUG_EVENT = 5, //Reports an exit-process debugging event. The value of u.ExitProcess specifies an EXIT_PROCESS_DEBUG_INFO structure.            
        LOAD_DLL_DEBUG_EVENT = 6, //Reports a load-dynamic-link-library (DLL) debugging event. The value of u.LoadDll specifies a LOAD_DLL_DEBUG_INFO structure.
        OUTPUT_DEBUG_STRING_EVENT = 8, //Reports an output-debugging-string debugging event. The value of u.DebugString specifies an OUTPUT_DEBUG_STRING_INFO structure.
        RIP_EVENT = 9, //Reports a RIP-debugging event (system debugging error). The value of u.RipInfo specifies a RIP_INFO structure.
        UNLOAD_DLL_DEBUG_EVENT = 7, //Reports an unload-DLL debugging event. The value of u.UnloadDll specifies an UNLOAD_DLL_DEBUG_INFO structure.
    }
}
