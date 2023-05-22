using System;
using System.Windows.Forms;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    ///     <para>
    ///         ※ 推薦使用 ※
    ///     </para>
    ///     <para>
    ///         提供鼠標事件
    ///     </para>
    /// </summary>
    public interface IMouseEvents
    {
        /// <summary>
        ///     <para>
        ///         移動鼠標時發生
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseMove;

        /// <summary>
        ///     <para>
        ///         移動鼠標事件
        ///     </para>
        /// </summary>
        /// 
        /// <remarks>
        ///     <para>
        ///         此事件提供擴展功能
        ///     </para>
        ///     <para>
        ///         <see cref="MouseEventArgs" />
        ///     </para>
        ///     <para>
        ///         能夠禁止在其他應用程序中進一步處理鼠標移動
        ///     </para>
        /// </remarks>
        event EventHandler<MouseEventExtArgs> MouseMoveExt;

        /// <summary>
        ///     <para>
        ///         當鼠標單擊時
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseClick;

        /// <summary>
        ///     <para>
        ///         當鼠標按下按鈕時
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseDown;

        /// <summary>
        ///     <para>
        ///         當鼠標按下鼠標按鈕時 -- 擴展
        ///     </para>
        /// </summary>
        /// 
        /// <remarks>
        ///     <para>
        ///         此事件提供擴展功能
        ///     </para>
        ///     <para>
        ///         <see cref="MouseEventArgs" />
        ///     </para>
        ///     <para>
        ///         能夠在其他應用程序中抑制對鼠標單擊的進一步處理
        ///     </para>
        /// </remarks>
        event EventHandler<MouseEventExtArgs> MouseDownExt;

        /// <summary>
        ///     <para>
        ///         當鼠標鬆開按鈕時
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseUp;

        /// <summary>
        ///     <para>
        ///         當鼠標鬆開按鈕時 -- 擴展
        ///     </para>
        /// </summary>
        /// 
        /// <remarks>
        ///     <para>
        ///         此事件提供擴展功能
        ///     </para>
        ///     <para>
        ///         <see cref="MouseEventArgs" />
        ///     </para>
        ///     <para>
        ///         能夠在其他應用程序中抑制對鼠標單擊的進一步處理
        ///     </para>
        /// </remarks>
        event EventHandler<MouseEventExtArgs> MouseUpExt;


        /// <summary>
        ///     <para>
        ///         當鼠標滾輪移動時
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseWheel;

        /// <summary>
        ///     <para>
        ///         當鼠標滾輪水平移動時
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseHWheel;

        /// <summary>
        ///     <para>
        ///         當鼠標滾輪移動時 -- 擴展
        ///     </para>
        /// </summary>
        /// 
        /// <remarks>
        ///     <para>
        ///         此事件提供擴展功能
        ///     </para>
        ///     <para>
        ///         <see cref="MouseEventArgs" />
        ///     </para>
        ///     <para>
        ///         能夠在其他應用程序中抑制對鼠標滾輪移動的進一步處理
        ///     </para>
        /// </remarks>
        event EventHandler<MouseEventExtArgs> MouseWheelExt;

        /// <summary>
        ///     <para>
        ///         當鼠標滾輪水平移動時 -- 擴展
        ///     </para>
        /// </summary>
        /// 
        /// <remarks>
        ///     <para>
        ///         此事件提供擴展功能
        ///     </para>
        ///     <para>
        ///         <see cref="MouseEventArgs" />
        ///     </para>
        ///     <para>
        ///         能夠在其他應用程序中抑制對水平鼠標滾輪移動的進一步處理
        ///     </para>
        /// </remarks>
        event EventHandler<MouseEventExtArgs> MouseHWheelExt;

        /// <summary>
        ///     <para>
        ///         當鼠標雙擊時
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseDoubleClick;

        /// <summary>
        ///     <para>
        ///         在鼠標拖動事件開始時發生
        ///     </para>
        ///     <para>
        ///         按住左鍵直到超過系統拖動上限
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseDragStarted;

        /// <summary>
        ///     <para>
        ///         在鼠標拖動事件開始時發生 -- 擴展
        ///     </para>
        ///     <para>
        ///         按住左鍵直到超過系統拖動上限
        ///     </para>
        /// </summary>
        /// 
        /// <remarks>
        ///     <para>
        ///         此事件提供擴展功能
        ///     </para>
        ///     <para>
        ///         <see cref="MouseEventArgs" />
        ///     </para>
        ///     <para>
        ///         能夠在其他應用程序中抑制對鼠標移動的進一步處理
        ///     </para>
        /// </remarks>
        event EventHandler<MouseEventExtArgs> MouseDragStartedExt;

        /// <summary>
        ///     <para>
        ///         在鼠標拖動事件完成時發生
        ///     </para>
        /// </summary>
        event MouseEventHandler MouseDragFinished;

        /// <summary>
        ///     <para>
        ///         在鼠標拖動事件完成時發生 -- 擴展
        ///     </para>
        /// </summary>
        /// 
        /// <remarks>
        ///     <para>
        ///         此事件提供擴展功能
        ///     </para>
        ///     <para>
        ///         <see cref="MouseEventArgs" />
        ///     </para>
        ///     <para>
        ///         能夠在其他應用程序中抑制對鼠標移動的進一步處理
        ///     </para>
        /// </remarks>
        event EventHandler<MouseEventExtArgs> MouseDragFinishedExt;
    }
}