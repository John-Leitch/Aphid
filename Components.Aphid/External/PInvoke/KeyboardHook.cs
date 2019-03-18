namespace Components.PInvoke
{
    public struct KeyboardHook
    {
        public int vkCode;
        public int scanCode;
        public int flags;
        public int time;
        public int dwExtraInfo;

        public override string ToString()
        {
            return string.Format(
                "vkCode: {0}, scanCode: {1}, flags: {2}, time: {3}, dwExtraInfo: {4}",
                vkCode,
                scanCode,
                flags,
                time,
                dwExtraInfo);
        }
    }
}
