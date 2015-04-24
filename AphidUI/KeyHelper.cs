using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AphidUI
{
    public static class KeyHelper
    {
        private enum MapType : uint
        {
            MAPVK_VK_TO_VSC = 0x0,
            MAPVK_VSC_TO_VK = 0x1,
            MAPVK_VK_TO_CHAR = 0x2,
            MAPVK_VSC_TO_VK_EX = 0x3,
        }

        [DllImport("user32.dll")]
        private static extern int ToUnicode(
            uint wVirtKey,
            uint wScanCode,
            byte[] lpKeyState,
            [Out, MarshalAs(UnmanagedType.LPWStr, SizeParamIndex = 4)] 
            StringBuilder pwszBuff,
            int cchBuff,
            uint wFlags);

        [DllImport("user32.dll")]
        private static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(uint uCode, MapType uMapType);

        public static char GetCharFromKey(Key key, out bool isControlKey)
        {
            isControlKey = false;
            char c = '\0';
            var virtualKey = KeyInterop.VirtualKeyFromKey(key);
            var keyboardState = new byte[256];
            GetKeyboardState(keyboardState);
            var code = MapVirtualKey((uint)virtualKey, MapType.MAPVK_VK_TO_VSC);
            var sb = new StringBuilder(2);
            var result = ToUnicode((uint)virtualKey, code, keyboardState, sb, sb.Capacity, 0);

            switch (result)
            {
                case -1:
                case 0:
                    isControlKey = true;
                    break;

                default:
                    c = sb[0];
                    break;
            }

            return c;
        }
    }
}
