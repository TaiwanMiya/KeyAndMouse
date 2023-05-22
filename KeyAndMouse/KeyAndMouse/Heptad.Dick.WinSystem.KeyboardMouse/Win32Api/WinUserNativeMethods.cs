using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
	public class WinUserNativeMethods
	{
        /// <summary>
        ///     檢查窗口 (給其中一個參數即可, 另一個可為null)
        /// </summary>
        /// 
        /// <param name="lpClassName">
        ///     程序的名稱
        /// </param>
        /// 
        /// <param name="lpWindowName">
        ///     程序的視窗名稱
        /// </param>
        /// 
        /// <returns>
        ///     應用程式的句柄
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "FindWindow", SetLastError = true)]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        ///     檢索類名和窗口名與指定字符串匹配的窗口的句柄
        ///     <para>
        ///         該函數搜索子窗口, 從指定子窗口後面的窗口開始, 此函數不執行區分大小寫的搜索
        ///     </para>
        /// </summary>
        /// 
        /// <param name="hwndParent">
        ///     要搜索其子窗口的父窗口的句柄
        ///     <para>
        ///         如果 <see href="hwndParent"/> 為NULL, 則該函數使用桌面窗口作為父窗口
        ///     </para>
        ///     <para>
        ///         該函數在作為桌面子窗口的窗口中搜索
        ///     </para>
        ///     <para>
        ///         如果 <see href="hwndParent"/> 是HWND_MESSAGE, 該函數搜索所有僅消息窗口
        ///     </para>
        /// </param>
        /// 
        /// <param name="hwndChildAfter">
        ///     子窗口的句柄
        ///     <para>
        ///         搜索從 Z 順序中的下一個子窗口開始, 子窗口必須是 <see href="hwndParent"/> 的直接子窗口, 而不僅僅是後代窗口
        ///     </para>
        ///     <para>
        ///         如果 <see href="hwndChildAfter"/> 為NULL, 則搜索從hwndParent的第一個子窗口開始
        ///     </para>
        ///     <para>
        ///         如果 <see href="hwndChildAfter"/> 和 <see href="hwndChildAfter"/> 均為NULL, 則該函數將搜索所有頂級窗口和僅消息窗口
        ///     </para>
        /// </param>
        /// 
        /// <param name="lpszClass">
        ///     通過先前調用 RegisterClass 或 RegisterClassEx 函數創建的類名或類原子
        ///     <para>
        ///         原子必須放在lpszClass的低位詞中, 高位字必須為零
        ///     </para>
        ///     <para>
        ///         如果lpszClass是一個字符串, 它指定窗口類名
        ///     </para>
        ///     <para>
        ///         類名可以是使用 RegisterClass 或 RegisterClassEx 註冊的任何名稱, 或任何預定義的控件類名稱, 也可以是MAKEINTATOM(0x8000)
        ///     </para>
        ///     <para>
        ///         在後一種情況下, 0x8000 是菜單類的原子
        ///     </para>
        ///     <para>
        ///         有關詳細信息, 請參閱本主題的備註部分
        ///     </para>
        /// </param>
        /// 
        /// <param name="lpszWindow">
        ///     窗口名稱 (窗口的標題), 如果此參數為NULL, 則所有窗口名稱都匹配
        /// </param>
        /// 
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "FindWindowEx", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        /// <summary>
        ///     顯示窗口
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口句柄
        /// </param>
        /// 
        /// <param name="nCmdShow">
        ///     ShowWindowCommands 方法 (用作不同呈現方式)
        /// </param>
        /// 
        /// <returns>
        /// 
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        ///     將指定視窗的執行緒帶入前景並啟動視窗
        ///     <para>
        ///         鍵盤輸入會導向至視窗, 而使用者會變更各種視覺提示, 系統會將稍微較高的優先順序指派給建立前景視窗的執行緒, 而不是其他執行緒
        ///     </para>
        /// </summary>
        /// <param name="hWnd">
        ///     窗口的句柄
        /// </param>
        /// 
        /// <returns>
        ///     如果視窗帶至前景, 則傳回值為非零
        ///     <para>
        ///         如果視窗未帶入前景, 則傳回值為零
        ///     </para>
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// 非同步顯示窗口
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口句柄
        /// </param>
        /// 
        /// <param name="nCmdShow">
        ///     ShowWindowCommands 方法 (用作不同呈現方式)
        /// </param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "ShowWindowAsync")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        /// <summary>
        ///     銷毀窗口
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口句柄
        /// </param>
        /// 
        /// <returns>
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "DestroyWindow")]
        public static extern int DestroyWindow(IntPtr hWnd);

        /// <summary>
        ///     設定窗口位置或置頂
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口的句柄
        /// </param>
        /// 
        /// <param name="hWndInsertAfter">
        ///     在 Z 順序中位於定位窗口之前的窗口句柄 -1至頂
        /// </param>
        /// 
        /// <param name="x">
        ///     窗口的x座標
        /// </param>
        /// 
        /// <param name="y">
        ///     窗口的y座標
        /// </param>
        /// 
        /// <param name="Width">
        ///     窗口的寬度
        /// </param>
        /// 
        /// <param name="Height">
        ///     窗口的高度
        /// </param>
        /// 
        /// <param name="flags">
        ///     
        /// </param>
        /// 
        /// <returns>
        ///     
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);

        /// <summary>
        ///     設定窗口至頂
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口的句柄
        /// </param>
        /// 
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool BringWindowToTop(IntPtr hWnd);

        /// <summary>
        ///     獲取視窗四個點位的座標
        ///     <para>
        ///         傳出一個結構, 給<see cref="RECT"/>
        ///     </para>
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口句柄
        /// </param>
        /// 
        /// <param name="lpRect">
        ///     傳出一個結構, 給<see cref="RECT"/>
        /// </param>
        /// 
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        /// <summary>
        ///     將指定的消息發送到一個或多個窗口
        ///     <para>
        ///         <see cref="SendMessage(IntPtr, uint, uint, uint)"/> 函數調用指定窗口的窗口過程
        ///     </para>
        ///     <para>
        ///         直到窗口過程處理完消息才返回
        ///     </para>
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口的句柄
        /// </param>
        /// 
        /// <param name="Msg">
        ///     要發布的消息
        /// </param>
        /// 
        /// <param name="wParam">
        ///     附加消息特定信息
        /// </param>
        ///
        /// <param name="lParam">
        ///     附加消息特定信息
        /// </param>
        /// 
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        /// <summary>
        ///     同 <see cref="SendMessage(IntPtr, uint, uint, uint)"/>
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口的句柄
        /// </param>
        /// 
        /// <param name="Msg">
        ///     要發布的消息
        /// </param>
        /// 
        /// <param name="wParam">
        ///     附加消息特定信息
        /// </param>
        ///
        /// <param name="lParam">
        ///     附加消息特定信息
        /// </param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        ///     <see cref="Heptad.Dick.WinSystem.KeyboardMouse.Code.WMcode.WM_SETTEXT"/> 專用
        ///     <para>
        ///         IParam 寫入文字
        ///     </para>
        ///     <para>
        ///         <example>
        ///             <br>IntPtr hWnd = WinUserNativeMethods.FindWindow(null, "未命名 - 記事本");</br>
        ///             <br>IntPtr htextbox = WinUserNativeMethods.FindWindowEx(hWnd, IntPtr.Zero, "EDIT", null);</br>
        ///             <br>IntPtr htextbox2 = WinUserNativeMethods.FindWindowEx(hWnd, htextbox, "EDIT", null); // 依據上次獲得的句柄, 可以得到下一個的句柄</br>
        ///             <br>WinUserNativeMethods.SetForegroundWindow(hWnd);</br>
        ///             <br>WinUserNativeMethods.SendMessage(htextbox, WMcode.WM_SETTEXT, IntPtr.Zero, txtNotepadText.Text);</br>
        ///         </example>
        ///     </para>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam">寫入的文字內容</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

        /// <summary>
        ///     在與創建指定窗口的線程關聯的消息隊列中放置（發布）一條消息,
        ///     <para>
        ///         並在不等待線程處理該消息的情況下返回
        ///     </para>
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口的句柄
        /// </param>
        /// 
        /// <param name="Msg">
        ///     要發布的消息
        /// </param>
        /// 
        /// <param name="wParam">
        ///     附加消息特定信息
        /// </param>
        ///
        /// <param name="lParam">
        ///     附加消息特定信息
        /// </param>
        /// 
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "PostMessage")]
        public static extern int PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        /// <summary>
        ///     同 <see cref="PostMessage(IntPtr, uint, uint, uint)"/>
        /// </summary>
        /// 
        /// <param name="hWnd">
        ///     窗口的句柄
        /// </param>
        /// 
        /// <param name="Msg">
        ///     要發布的消息
        /// </param>
        /// 
        /// <param name="wParam">
        ///     附加消息特定信息
        /// </param>
        ///
        /// <param name="lParam">
        ///     附加消息特定信息
        /// </param>
        /// 
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "PostMessage")]
        public static extern int PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        ///     獲取前景窗口 (最上層窗口)
        /// </summary>
        /// 
        /// <returns>
        ///     窗口的句柄
        /// </returns>
        [DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// 應用程序的 最左, 最上, 最右, 最下的座標結構
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            /// <summary>
            /// 最左座標
            /// </summary>
            public int Left;
            /// <summary>
            /// 最上座標
            /// </summary>
            public int Top;
            /// <summary>
            /// 最右座標
            /// </summary>
            public int Right;
            /// <summary>
            /// 最下座標
            /// </summary>
            public int Bottom;
        }
    }

    public struct IParamm
    {
        /// <summary>
        ///     重複次數
        /// </summary>
        public ushort repeatCount;

        /// <summary>
        ///     鍵盤掃描碼
        /// </summary>
        public int scanCode;

        /// <summary>
        ///     擴展鍵
        /// </summary>
        public ushort extendedKey;

        /// <summary>
        ///     功能鍵狀態
        /// </summary>
        public ushort prevKeyState;

        /// <summary>
        ///     過渡狀態
        /// </summary>
        public ushort transitionState;

        /// <summary>
        ///     <para>
        ///         <see cref="WinUserNativeMethods.SendMessage(IntPtr, uint, uint, uint)"/>
        ///     </para>
        ///     <para>
        ///         <see cref="WinUserNativeMethods.PostMessage(IntPtr, uint, uint, uint)"/>
        ///     </para>
        ///     的 IParam 參數 (第4個參數)
        /// </summary>
        public int lParam =>
            repeatCount | (scanCode << 16) | (extendedKey << 24) |
                (prevKeyState << 30) | (transitionState << 31);
    }
}
