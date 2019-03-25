using System;

namespace Components.PInvoke
{
    [Flags]
    public enum ShowWindowCommands : uint
    {
        /// <summary>
        ///        Hides the window and activates another window.
        /// </summary>
        SW_HIDE = 0,

        /// <summary>
        ///        Activates and displays a window. If the window is minimized or maximized, the system restores it to its original size and position. An application should specify this flag when displaying the window for the first time.
        /// </summary>
        SW_SHOWNORMAL = 1,

        /// <summary>
        ///        Activates and displays a window. If the window is minimized or maximized, the system restores it to its original size and position. An application should specify this flag when displaying the window for the first time.
        /// </summary>
        SW_NORMAL = 1,

        /// <summary>
        ///        Activates the window and displays it as a minimized window.
        /// </summary>
        SW_SHOWMINIMIZED = 2,

        /// <summary>
        ///        Activates the window and displays it as a maximized window.
        /// </summary>
        SW_SHOWMAXIMIZED = 3,

        /// <summary>
        ///        Maximizes the specified window.
        /// </summary>
        SW_MAXIMIZE = 3,

        /// <summary>
        ///        Displays a window in its most recent size and position. This value is similar to <see cref="SW_SHOWNORMAL"/>, except the window is not activated.
        /// </summary>
        SW_SHOWNOACTIVATE = 4,

        /// <summary>
        ///        Activates the window and displays it in its current size and position.
        /// </summary>
        SW_SHOW = 5,

        /// <summary>
        ///        Minimizes the specified window and activates the next top-level window in the z-order.
        /// </summary>
        SW_MINIMIZE = 6,

        /// <summary>
        ///        Displays the window as a minimized window. This value is similar to <see cref="SW_SHOWMINIMIZED"/>, except the window is not activated.
        /// </summary>
        SW_SHOWMINNOACTIVE = 7,

        /// <summary>
        ///        Displays the window in its current size and position. This value is similar to <see cref="SW_SHOW"/>, except the window is not activated.
        /// </summary>
        SW_SHOWNA = 8,

        /// <summary>
        ///        Activates and displays the window. If the window is minimized or maximized, the system restores it to its original size and position. An application should specify this flag when restoring a minimized window.
        /// </summary>
        SW_RESTORE = 9
    }
}
