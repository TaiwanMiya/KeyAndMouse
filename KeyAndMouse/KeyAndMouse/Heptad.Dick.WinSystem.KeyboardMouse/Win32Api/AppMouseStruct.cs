using System;
using System.Runtime.InteropServices;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     <see cref="AppMouseStruct" /> 的結構包含有關應用程序及鼠標輸入事件的信息
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal struct AppMouseStruct
    {
        /// <summary>
        ///     <para>
        ///         指定一個 <see cref="Heptad.Dick.WinSystem.KeyboardMouse.Win32Api.Point" /> 結構
        ///     </para>
        ///     <para>
        ///         該結構包含光標的 X 和 Y 坐標, 以屏幕坐標表示
        ///     </para>
        /// </summary>
        [FieldOffset(0x00)] public Point Point;

        /// <summary>
        ///     指定與鼠標消息關聯的信息
        /// </summary>
        /// <remarks>
        ///     可能的值是:
        ///     <list type="bullet">
        ///         <item>
        ///             <description>0 - 無信息</description>
        ///         </item>
        ///         <item>
        ///             <description> 1   - X-Button1 點擊</description>
        ///         </item>
        ///         <item>
        ///             <description> 2   - X-Button2 點擊</description>
        ///         </item>
        ///         <item>
        ///             <description> 120 - 鼠標向前</description>
        ///         </item>
        ///         <item>
        ///             <description>-120 - 鼠標向後</description>
        ///         </item>
        ///     </list>
        /// </remarks>
        [FieldOffset(0x16)] public short MouseData_x86;

        [FieldOffset(0x22)] public short MouseData_x64;

        /// <summary>
        ///     轉換當前 <see cref="AppMouseStruct" /> 變成一個 <see cref="MouseStruct" />.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///     <see cref="AppMouseStruct" /> 沒有時間戳, 因此在調用時會生成一個
        /// </remarks>
        public MouseStruct ToMouseStruct()
        {
            var tmp = new MouseStruct();
            tmp.Point = Point;
            tmp.MouseData = IntPtr.Size == 4 ? MouseData_x86 : MouseData_x64;
            tmp.Timestamp = Environment.TickCount;
            return tmp;
        }
    }
}