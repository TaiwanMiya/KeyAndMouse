using Heptad.Dick.WinSystem.KeyboardMouse.Implementation;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    ///     <para>
    ///         ※ 必須使用 ※
    ///     </para>
    ///     <para>
    ///         建立鍵盤與鼠標掛勾
    ///     </para>
    ///     <para>
    ///         使用此類別做為開端
    ///     </para>
    /// </summary>
    public static class Hook
    {
        /// <summary>
        ///     <para>
        ///         找到應用程序的事件
        ///     </para>
        ///     <para>
        ///         鼠標和鍵盤都在此 0.0
        ///     </para>
        /// </summary>
        /// 
        /// <returns>
        ///     <para>
        ///         返回的實例用於調用與委派事件
        ///     </para>
        ///     <para>
        ///         還可以重新獲取它
        ///     </para>
        ///     <para>
        ///         <i>無論如何都會獲得相同的實例</i>
        ///     </para>
        /// </returns>
        public static IKeyboardMouseEvents AppEvents()
        {
            return new AppEventFacade();
        }

        /// <summary>
        ///     <para>
        ///         找到系統範圍的事件
        ///     </para>
        ///     <para>
        ///         鼠標和鍵盤都在此 0.0
        ///     </para>
        /// </summary>
        /// 
        /// <returns>
        ///     <para>
        ///         返回的實例用於調用與委派事件
        ///     </para>
        ///     <para>
        ///         還可以重新獲取它
        ///     </para>
        ///     <para>
        ///         <i>無論如何都會獲得相同的實例</i>
        ///     </para>
        /// </returns>
        public static IKeyboardMouseEvents GlobalEvents()
        {
            return new GlobalEventFacade();
        }
    }
}