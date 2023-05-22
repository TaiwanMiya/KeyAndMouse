using System;
using System.Windows.Forms;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    ///     <para>
    ///         ※ 推薦使用 ※
    ///     </para>
    ///     <para>
    ///         提供鍵盤事件
    ///     </para>
    /// </summary>
    public interface IKeyboardEvents
    {
        /// <summary>
        ///     <para>
        ///         按下某個鍵時發生
        ///     </para>
        /// </summary>
        event KeyEventHandler KeyDown;

        /// <summary>
        ///     <para>
        ///         觸發某個鍵時發生
        ///     </para>
        /// </summary>
        /// 
        /// <remarks>
        /// 關鍵事件按以下順序發生:
        /// <list type="number">
        ///     <item>KeyDown</item>
        ///     <item>KeyPress</item>
        ///     <item>KeyDownTxt</item>
        ///     <item>KeyUp</item>
        /// </list>
        ///     <para>
        ///         非字符鍵不會引發 KeyPress 事件; 但非字符鍵會引發 KeyDown 和 KeyUp 事件
        ///     </para>
        ///     <para>
        ///         使用 KeyChar 屬性在運行時對擊鍵進行採樣, 並使用或修改常見擊鍵的子集
        ///     </para>
        ///     <para>
        ///         僅在應用程序中處理鍵盤事件而不使其他應用程序接收鍵盤事件
        ///     </para>
        ///     <para>
        ///         設置 <i>Windows Form</i> 裡面的 KeyPress 的屬性
        ///     </para>
        ///     <para>
        ///         <see cref="KeyPressEventArgs.Handled" /> 為 <b>true</b>
        ///     </para>
        /// </remarks>
        event KeyPressEventHandler KeyPress;

        /// <summary>
        ///     <para>
        ///         按下鍵時發生, 包括字符鍵
        ///     </para>
        /// </summary>
        event EventHandler<KeyDownTxtEventArgs> KeyDownTxt;

        /// <summary>
        ///     <para>
        ///         鬆開某個鍵時發生
        ///     </para>
        /// </summary>
        event KeyEventHandler KeyUp;
    }
}