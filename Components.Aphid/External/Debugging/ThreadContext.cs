using Components.PInvoke;
using System;

namespace Components.Cypress
{
    public static class ThreadContext
    {
        public static CONTEXT GetContext(IntPtr thread, CONTEXT_FLAGS flags)
        {
            var context = new CONTEXT { ContextFlags = flags };
            var result = Kernel32.GetThreadContext(thread, ref context);
            return context;
        }

        public static bool SetContext(IntPtr thread, CONTEXT context) => Kernel32.SetThreadContext(thread, ref context);

        public static bool SetEip(IntPtr thread, uint eip)
        {
            var context = GetContext(thread, CONTEXT_FLAGS.CONTEXT_CONTROL);
            context.Eip = eip;

            return SetContext(thread, context);
        }

        public static bool EnableSingleStep(IntPtr thread, uint eip)
        {
            var context = GetContext(thread, CONTEXT_FLAGS.CONTEXT_CONTROL);
            context.EFlags |= 0x100;
            context.Eip = eip;

            return SetContext(thread, context);
        }

        public static bool DisableSingleStep(IntPtr thread)
        {
            var context = GetContext(thread, CONTEXT_FLAGS.CONTEXT_CONTROL);
            context.EFlags &= ~0x100u;

            return SetContext(thread, context);
        }

        //public static bool SetFlags(uint flags)
        //{
        //}
    }
}
