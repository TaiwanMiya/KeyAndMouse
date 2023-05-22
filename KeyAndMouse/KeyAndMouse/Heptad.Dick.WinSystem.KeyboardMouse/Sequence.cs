using System.Linq;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    ///     <para>
    ///         描述鍵或鍵組合序列
    ///     </para>
    ///     <para>
    ///         例如 Ctrl+Z,Z
    ///     </para>
    /// </summary>
    public class Sequence : SequenceBase<Combination>
    {
        private Sequence(Combination[] combinations) : base(combinations)
        {

        }

        /// <summary>
        /// 從表示鍵或鍵組合的參數創建序列對象的實例
        /// </summary>
        /// 
        /// <param name="combinations">組合鍵</param>
        /// 
        /// <returns></returns>
        public static Sequence Of(params Combination[] combinations)
        {
            return new Sequence(combinations);
        }

        /// <summary>
        ///     <para>
        ///         從字符串創建一個序列對象的實例
        ///     </para>
        ///     <para>
        ///         該字符串必須包含以 逗號 “,” 分隔的描述鍵或鍵組合的字符串列表
        ///     </para>
        ///     <para>
        ///         舉例:
        ///     </para>
        ///     <para>
        ///         'A,B,C', 'Alt+R,S', 'Shift+R,Alt+K'
        ///     </para>
        /// </summary>
        /// 
        /// <param name="text">字串</param>
        /// 
        /// <returns></returns>
        public static Sequence FromString(string text)
        {
            var parts = text.Split(',');
            var combinations = parts.Select(Combination.FromString).ToArray();
            return new Sequence(combinations);
        }
    }
}