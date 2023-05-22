using System.Runtime.InteropServices;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     底層鼠標方法
    /// </summary>
    public static class MouseNativeMethods
    {
        /// <summary>
        ///     <para>
        ///         函數 <see cref="GetDoubleClickTime"/>
        ///     </para>
        ///     <para>
        ///         是檢索鼠標的當前雙擊時間, 雙擊是連續兩次單擊鼠標按鈕,  第二次發生在第一次之後的指定時間內
        ///     </para>
        ///     <para>
        ///         雙擊時間是雙擊的第一次和第二次單擊之間發生的最大毫秒數
        ///     </para>
        /// </summary>
        /// 
        /// <returns>
        ///     返回值指定當前雙擊時間, 以毫秒為單位
        /// </returns>
        [DllImport("user32.dll")]
        public static extern int GetDoubleClickTime();

        /// <summary>
        ///     <para>
        ///         函數 <see cref="GetCursorPos"/>
        ///     </para>
        ///     <para>
        ///         是找到當前鼠標的位置, 並返回一個 <see cref="Point"/> 結構
        ///     </para>
        /// </summary>
        /// <param name="lpPoint">傳出<see cref="Point"/></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet =CharSet.Auto)]
        public static extern bool GetCursorPos(out Point lpPoint);
    }
}