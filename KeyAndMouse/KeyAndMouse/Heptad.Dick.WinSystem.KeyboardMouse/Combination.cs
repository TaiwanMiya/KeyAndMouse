using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse.Implementation;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    ///     <para>
    ///         用於表示在應用程序中經常使用的組合鍵作為快捷鍵
    ///     </para>
    ///     <para>
    ///         例如Alt+Shift+R, 在“Alt”和“Shift”已經按下後按下“R”時會觸發此組合
    ///     </para>
    /// </summary>
    public class Combination
    {
        private readonly Chord _chord;

        private Combination(Keys triggerKey, IEnumerable<Keys> chordKeys)
            : this(triggerKey, new Chord(chordKeys))
        {
        }

        private Combination(Keys triggerKey, Chord chord)
        {
            TriggerKey = triggerKey.Normalize();
            _chord = chord;
        }

        /// <summary>
        ///     觸發組合的最後一個鍵
        /// </summary>
        public Keys TriggerKey { get; }

        /// <summary>
        ///     按下觸發鍵時必須全部按下的鍵
        /// </summary>
        public IEnumerable<Keys> Chord
        {
            get { return _chord; }
        }

        /// <summary>
        ///     按下觸發鍵時必須已按下的修飾符數量
        /// </summary>
        public int ChordLength
        {
            get { return _chord.Count; }
        }

        /// <summary>
        ///     <para>
        ///         一種可鏈接的構建器方法, 用作簡化修飾符創建
        ///     </para>
        ///     配合使用以下方法:
        ///     <list type="number">
        ///         <item>
        ///             <see cref="TriggeredBy" />
        ///         </item>
        ///         <item>
        ///             <see cref="With" />
        ///         </item>
        ///         <item>
        ///             <see cref="Control" />
        ///         </item>
        ///         <item>
        ///             <see cref="Shift" />
        ///         </item>
        ///         <item>
        ///             <see cref="Alt" />
        ///         </item>
        ///     </list>
        /// </summary>
        /// 
        /// <param name="key">枚舉型別<see cref="Keys" /></param>
        public static Combination TriggeredBy(Keys key)
        {
            return new Combination(key, (IEnumerable<Keys>) new Chord(Enumerable.Empty<Keys>()));
        }

        /// <summary>
        ///     <para>
        ///         一種可鏈接的構建器方法, 用作簡化修飾符創建
        ///     </para>
        ///     配合使用以下方法:
        ///     <list type="number">
        ///         <item>
        ///             <see cref="TriggeredBy" />
        ///         </item>
        ///         <item>
        ///             <see cref="With" />
        ///         </item>
        ///         <item>
        ///             <see cref="Control" />
        ///         </item>
        ///         <item>
        ///             <see cref="Shift" />
        ///         </item>
        ///         <item>
        ///             <see cref="Alt" />
        ///         </item>
        ///     </list>
        /// </summary>
        /// 
        /// <param name="key">枚舉型別<see cref="Keys" /></param>
        public Combination With(Keys key)
        {
            return new Combination(TriggerKey, Chord.Concat(Enumerable.Repeat(key, 1)));
        }

        /// <summary>
        ///     <para>
        ///         一種可鏈接的構建器方法, 用作簡化修飾符創建
        ///     </para>
        ///     配合使用以下方法:
        ///     <list type="number">
        ///         <item>
        ///             <see cref="TriggeredBy" />
        ///         </item>
        ///         <item>
        ///             <see cref="With" />
        ///         </item>
        ///         <item>
        ///             <see cref="Control" />
        ///         </item>
        ///         <item>
        ///             <see cref="Shift" />
        ///         </item>
        ///         <item>
        ///             <see cref="Alt" />
        ///         </item>
        ///     </list>
        /// </summary>
        public Combination Control()
        {
            return With(Keys.Control);
        }

        /// <summary>
        ///     <para>
        ///         一種可鏈接的構建器方法, 用作簡化修飾符創建
        ///     </para>
        ///     配合使用以下方法:
        ///     <list type="number">
        ///         <item>
        ///             <see cref="TriggeredBy" />
        ///         </item>
        ///         <item>
        ///             <see cref="With" />
        ///         </item>
        ///         <item>
        ///             <see cref="Control" />
        ///         </item>
        ///         <item>
        ///             <see cref="Shift" />
        ///         </item>
        ///         <item>
        ///             <see cref="Alt" />
        ///         </item>
        ///     </list>
        /// </summary>
        public Combination Alt()
        {
            return With(Keys.Alt);
        }

        /// <summary>
        ///     <para>
        ///         一種可鏈接的構建器方法, 用作簡化修飾符創建
        ///     </para>
        ///     配合使用以下方法:
        ///     <list type="number">
        ///         <item>
        ///             <see cref="TriggeredBy" />
        ///         </item>
        ///         <item>
        ///             <see cref="With" />
        ///         </item>
        ///         <item>
        ///             <see cref="Control" />
        ///         </item>
        ///         <item>
        ///             <see cref="Shift" />
        ///         </item>
        ///         <item>
        ///             <see cref="Alt" />
        ///         </item>
        ///     </list>
        /// </summary>
        public Combination Shift()
        {
            return With(Keys.Shift);
        }

        public override string ToString()
        {
            return string.Join("+", Chord.Concat(Enumerable.Repeat(TriggerKey, 1)));
        }

        /// <summary>
        ///     <para>
        ///         由任何字符串中的修飾符觸發, 例如“Alt+Shift+R”
        ///     </para>
        ///     <para>
        ///         觸發鍵必須是最後一個
        ///     </para>
        /// </summary>
        public static Combination FromString(string trigger)
        {
            var parts = trigger
                .Split('+')
                .Select(p => Enum.Parse(typeof(Keys), p))
                .Cast<Keys>();
            var stack = new Stack<Keys>(parts);
            var triggerKey = stack.Pop();
            return new Combination(triggerKey, stack);
        }

        protected bool Equals(Combination other)
        {
            return
                TriggerKey == other.TriggerKey
                && Chord.Equals(other.Chord);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Combination) obj);
        }

        public override int GetHashCode()
        {
            return Chord.GetHashCode() ^
                   (int) TriggerKey;
        }
    }
}