using System.Runtime.InteropServices;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     <see cref="MouseStruct" /> 包含有關鼠標輸入事件的信息
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    internal struct MouseStruct
    {
        /// <summary>
        ///     指定一個 Point 結構, 該結構包含鼠標的 X 和 Y 坐標, 依照屏幕坐標去表示
        /// </summary>
        [FieldOffset(0x00)] public Point Point;

        /// <summary>
        ///     指定與消息關聯的信息
        /// </summary>
        /// 
        /// <remarks>
        ///     以下為可能出現的值:
        ///     <list type="bullet">
        ///         <item>
        ///             <description>0 - 無信息</description>
        ///         </item>
        ///         <item>
        ///             <description>1 - X-按鈕1 點擊</description>
        ///         </item>
        ///         <item>
        ///             <description>2 - X-按鈕2 點擊</description>
        ///         </item>
        ///         <item>
        ///             <description>120 - 鼠標滾輪向前</description>
        ///         </item>
        ///         <item>
        ///             <description>-120 - 鼠標滾輪向後</description>
        ///         </item>
        ///     </list>
        /// </remarks>
        [FieldOffset(0x0A)] public short MouseData;

        /// <summary>
        ///     在系統記號(System Ticks) 中返回與輸入關聯的時間戳
        /// </summary>
        [FieldOffset(0x10)] public int Timestamp;
    }
}