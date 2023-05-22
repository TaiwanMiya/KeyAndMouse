using System;
using System.Collections.Generic;
using System.Linq;
using Heptad.Dick.WinSystem.KeyboardMouse.Implementation;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    ///     <para>
    ///         檢測組合鍵的擴展方法
    ///     </para>
    /// </summary>
    public static class KeyCombinationExtensions
    {
        /// <summary>
        ///     <para>
        ///         檢測一個鍵或組合鍵並觸發相應的操作
        ///     </para>
        /// </summary>
        /// 
        /// <param name="source">
        ///     <para>
        ///         作者建議使用
        ///     </para>
        ///     <para>
        ///         全局或應用程序掛鉤的實例, 使用以下
        ///     </para>
        ///     <list type="bullet">
        ///         <item>
        ///             <description><see cref="Hook.GlobalEvents" /></description>
        ///         </item>
        ///         <item>
        ///             <description><see cref="Hook.AppEvents" /></description>
        ///         </item>
        ///     </list>
        /// </param>
        /// 
        /// <param name="map">
        ///     <para>
        ///         此映射包含映射到相應操作的組合鍵列表, 可以使用字典初始化輕鬆創建
        ///     </para>
        ///     <para>
        ///         每當檢測到列出的組合時, 都會觸發相應的操作
        ///     </para>
        /// </param>
        /// 
        /// <param name="reset">
        ///     <para>
        ///         當按下某個鍵但它不是任何想要的組合的一部分時, 可執行此操作
        ///     </para>
        /// </param>
        public static void OnCombination(this IKeyboardEvents source,
            IEnumerable<KeyValuePair<Combination, Action>> map, Action reset = null)
        {
            var watchlists = map.GroupBy(k => k.Key.TriggerKey)
                .ToDictionary(g => g.Key, g => g.ToArray());
            source.KeyDown += (sender, e) =>
            {
                var found = watchlists.TryGetValue(e.KeyCode, out KeyValuePair<Combination, Action>[] element);
                if (!found)
                {
                    reset?.Invoke();
                    return;
                }
                var state = KeyboardState.GetCurrent();
                var action = reset;
                var maxLength = 0;
                foreach (var current in element)
                {
                    var matches = current.Key.Chord.All(state.IsDown);
                    if (!matches) continue;
                    if (maxLength > current.Key.ChordLength) continue;
                    maxLength = current.Key.ChordLength;
                    action = current.Value;
                }
                action?.Invoke();
            };
        }


        /// <summary>
        ///     <para>
        ///         檢測按鍵或按鍵組合序列並觸發相應的操作
        ///     </para>
        /// </summary>
        /// 
        /// <param name="source">
        ///     <para>
        ///         全局或應用程序掛鉤的實例, 使用如下
        ///     </para>
        ///     <list type="bullet">
        ///         <item>
        ///             <description><see cref="Hook.GlobalEvents" /></description>
        ///         </item>
        ///         <item>
        ///             <description><see cref="Hook.AppEvents" /></description>
        ///         </item>
        ///     </list>
        /// </param>
        /// 
        /// <param name="map">
        ///     <para>
        ///         此映射包含映射到相應操作的序列列表, 可以使用字典初始化輕鬆創建
        ///     </para>
        ///     <para>
        ///         每當檢測到列出的序列時, 都會觸發相應的操作,, 如果兩個或多個序列匹配, 將使用最長的一個
        ///     </para>
        ///     <para>
        ///         舉例:
        ///     </para>
        ///     <para>
        ///         如果用戶先按 A, 然後按 B, 然後按 C, 則序列可能會同時檢測到 A、B、C 和 B、C
        ///     </para>
        ///     <para>
        ///         在這種情況下, 只有對應的動作到 'A,B,C' 才會被觸發
        ///     </para>
        /// </param>
        public static void OnSequence(this IKeyboardEvents source, IEnumerable<KeyValuePair<Sequence, Action>> map)
        {
            var actBySeq = map.ToArray();
            var endsWith = new Func<Queue<Combination>, Sequence, bool>((chords, sequence) =>
            {
                var skipCount = chords.Count - sequence.Length;
                return skipCount >= 0 && chords.Skip(skipCount).SequenceEqual(sequence);
            });

            var max = actBySeq.Select(p => p.Key).Max(c => c.Length);
            var min = actBySeq.Select(p => p.Key).Min(c => c.Length);
            var buffer = new Queue<Combination>(max);

            var wrapMap = actBySeq.SelectMany(p => p.Key).Select(c => new KeyValuePair<Combination, Action>(c, () =>
            {
                buffer.Enqueue(c);
                if (buffer.Count > max) buffer.Dequeue();
                if (buffer.Count < min) return;
                // 委派最長匹配序列對應的動作
                actBySeq
                    .Where(pair => endsWith(buffer, pair.Key))
                    .OrderBy(pair => pair.Key.Length)
                    .Select(pair => pair.Value)
                    .LastOrDefault()
                    ?.Invoke();
            }));

            OnCombination(source, wrapMap, buffer.Clear);
        }
    }
}