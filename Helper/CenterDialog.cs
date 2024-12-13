//***********************************************************************************************************************************
// Filename:		CenterDialog.cs																
// Project:			VisiSensVS 
// Creation Date:	11. 3. 2013	  
// Creation Time:	14:34	
// Original Autor:	(wakl) Kleisch, Walter 
//
//***********************************************************************************************************************************
// 											Copyright (c) 2020 PreSens GmbH
//***********************************************************************************************************************************


using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

class CenterDialog : IDisposable 
{
    private readonly IWin32Window owner;
    private readonly HookProc hookProc;
    private readonly IntPtr hHook = IntPtr.Zero;

    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Centers a dialog on a given form
    ///             Sample usage:
    ///             using (CenterDialog centerDlg = new CenterDialog(this))
    ///             {
    ///                dialog.Show(....);
    ///             } 
    /// </summary>
    ///
    /// <exception cref="ArgumentNullException"> Thrown when one or more required arguments are null. </exception>
    ///
    /// <param name="owner">    The Form where the dialog shoud be centered. </param>
    ///-------------------------------------------------------------------------------------------------

    public CenterDialog(IWin32Window owner)
    {
        if (owner == null) throw new ArgumentNullException("No owner defined");
         
        this.owner = owner;
        hookProc = DialogHookProc;

        hHook = SetWindowsHookEx(WH_CALLWNDPROCRET, hookProc, IntPtr.Zero, GetCurrentThreadId());
    }

    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Centers a dialog on a the main form of the application 
    ///             Sample usage:
    ///             using (CenterDialog centerDlg = new CenterDialog())
    ///             {
    ///                dialog.Show(....);
    ///             } 
    /// </summary>
    ///
    /// <exception cref="ArgumentNullException"> Thrown when one or more required arguments are null. </exception>
    ///-------------------------------------------------------------------------------------------------

    public CenterDialog()
    {
        this.owner = (Application.OpenForms[0] as IWin32Window);
        if (this.owner == null) throw new NullReferenceException("No main form found");
        hookProc = DialogHookProc;

        hHook = SetWindowsHookEx(WH_CALLWNDPROCRET, hookProc, IntPtr.Zero, GetCurrentThreadId());
    }

    private IntPtr DialogHookProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode < 0)
        {
            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }

        CWPRETSTRUCT msg = (CWPRETSTRUCT)Marshal.PtrToStructure(lParam, typeof(CWPRETSTRUCT));
        IntPtr hook = hHook;

        if (msg.message == (int)CbtHookAction.HCBT_ACTIVATE)
        {
            try
            {
                CenterWindow(msg.hwnd);
            }
            finally
            {
                UnhookWindowsHookEx(hHook);
            }
        }

        return CallNextHookEx(hook, nCode, wParam, lParam);
    }

    public void Dispose()
    {
        UnhookWindowsHookEx(hHook);
    }

    private void CenterWindow(IntPtr hChildWnd)
    {
        Rectangle recChild = new Rectangle(0, 0, 0, 0);
        bool success = GetWindowRect(hChildWnd, ref recChild);

        if (!success)
        {
            return;
        }

        int width = recChild.Width - recChild.X;
        int height = recChild.Height - recChild.Y;

        Rectangle recParent = new Rectangle(0, 0, 0, 0);
        success = GetWindowRect(owner.Handle, ref recParent);

        if (!success)
        {
            return;
        }

        Point ptCenter = new Point(0, 0);
        ptCenter.X = recParent.X + ((recParent.Width - recParent.X) / 2);
        ptCenter.Y = recParent.Y + ((recParent.Height - recParent.Y) / 2);


        Point ptStart = new Point(0, 0);
        ptStart.X = (ptCenter.X - (width / 2));
        ptStart.Y = (ptCenter.Y - (height / 2));

        //MoveWindow(hChildWnd, ptStart.X, ptStart.Y, width, height, false);
        System.Threading.Tasks.Task.Factory.StartNew(() => SetWindowPos(hChildWnd, (IntPtr)0, ptStart.X, ptStart.Y, width, height, SetWindowPosFlags.SWP_ASYNCWINDOWPOS | SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOOWNERZORDER | SetWindowPosFlags.SWP_NOZORDER));
    }

    // some p/invoke
    public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

    public delegate void TimerProc(IntPtr hWnd, uint uMsg, UIntPtr nIDEvent, uint dwTime);

    private const int WH_CALLWNDPROCRET = 12;

    private enum CbtHookAction : int
    {
        HCBT_MOVESIZE = 0,
        HCBT_MINMAX = 1,
        HCBT_QS = 2,
        HCBT_CREATEWND = 3,
        HCBT_DESTROYWND = 4,
        HCBT_ACTIVATE = 5,
        HCBT_CLICKSKIPPED = 6,
        HCBT_KEYSKIPPED = 7,
        HCBT_SYSCOMMAND = 8,
        HCBT_SETFOCUS = 9
    }

    [DllImport("kernel32.dll")]
    static extern int GetCurrentThreadId();

    [DllImport("user32.dll")]
    private static extern bool GetWindowRect(IntPtr hWnd, ref Rectangle lpRect);

    [DllImport("user32.dll")]
    private static extern int MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, SetWindowPosFlags uFlags);

    [DllImport("User32.dll")]
    public static extern UIntPtr SetTimer(IntPtr hWnd, UIntPtr nIDEvent, uint uElapse, TimerProc lpTimerFunc);

    [DllImport("User32.dll")]
    public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

    [DllImport("user32.dll")]
    public static extern int UnhookWindowsHookEx(IntPtr idHook);

    [DllImport("user32.dll")]
    public static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    public static extern int GetWindowTextLength(IntPtr hWnd);

    [DllImport("user32.dll")]
    public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int maxLength);

    [DllImport("user32.dll")]
    public static extern int EndDialog(IntPtr hDlg, IntPtr nResult);

    [StructLayout(LayoutKind.Sequential)]
    public struct CWPRETSTRUCT
    {
        public IntPtr lResult;
        public IntPtr lParam;
        public IntPtr wParam;
        public uint message;
        public IntPtr hwnd;
    };
    
}

[Flags]
public enum SetWindowPosFlags : uint
{
    /// <summary>
    ///     If the calling thread and the thread that owns the window are attached to different input queues, the system posts the request to the thread that owns the window. This prevents the calling thread from blocking its execution while other threads process the request.
    /// </summary>
    SWP_ASYNCWINDOWPOS = 0x4000,

    /// <summary>
    ///     Prevents generation of the WM_SYNCPAINT message.
    /// </summary>
    SWP_DEFERERASE = 0x2000,

    /// <summary>
    ///     Draws a frame (defined in the window's class description) around the window.
    /// </summary>
    SWP_DRAWFRAME = 0x0020,

    /// <summary>
    ///     Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE is sent only when the window's size is being changed.
    /// </summary>
    SWP_FRAMECHANGED = 0x0020,

    /// <summary>
    ///     Hides the window.
    /// </summary>
    SWP_HIDEWINDOW = 0x0080,

    /// <summary>
    ///     Does not ActivateControl the window. If this flag is not set, the window is activated and moved to the top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter parameter).
    /// </summary>
    SWP_NOACTIVATE = 0x0010,

    /// <summary>
    ///     Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client area are saved and copied back into the client area after the window is sized or repositioned.
    /// </summary>
    SWP_NOCOPYBITS = 0x0100,

    /// <summary>
    ///     Retains the current position (ignores X and Y parameters).
    /// </summary>
    SWP_NOMOVE = 0x0002,

    /// <summary>
    ///     Does not change the owner window's position in the Z order.
    /// </summary>
    SWP_NOOWNERZORDER = 0x0200,

    /// <summary>
    ///     Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent window uncovered as a result of the window being moved. When this flag is set, the application must explicitly invalidate or redraw any parts of the window and parent window that need redrawing.
    /// </summary>
    SWP_NOREDRAW = 0x0008,

    /// <summary>
    ///     Same as the SWP_NOOWNERZORDER flag.
    /// </summary>
    SWP_NOREPOSITION = 0x0200,

    /// <summary>
    ///     Prevents the window from receiving the WM_WINDOWPOSCHANGING message.
    /// </summary>
    SWP_NOSENDCHANGING = 0x0400,

    /// <summary>
    ///     Retains the current size (ignores the cx and cy parameters).
    /// </summary>
    SWP_NOSIZE = 0x0001,

    /// <summary>
    ///     Retains the current Z order (ignores the hWndInsertAfter parameter).
    /// </summary>
    SWP_NOZORDER = 0x0004,

    /// <summary>
    ///     Displays the window.
    /// </summary>
    SWP_SHOWWINDOW = 0x0040,

}