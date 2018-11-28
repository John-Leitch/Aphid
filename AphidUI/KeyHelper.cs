using Components.PInvoke;
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
        public static char GetCharFromKey(Key key, out bool isControlKey)
        {
            isControlKey = false;
            char c = '\0';
            var virtualKey = KeyInterop.VirtualKeyFromKey(key);
            var keyboardState = new byte[256];
            User32.GetKeyboardState(keyboardState);
            var sb = new StringBuilder(2);

            switch (User32.ToUnicode(
                (uint)virtualKey,
                User32.MapVirtualKey((uint)virtualKey, MapType.MAPVK_VK_TO_VSC),
                keyboardState,
                sb,
                sb.Capacity, 0))
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
