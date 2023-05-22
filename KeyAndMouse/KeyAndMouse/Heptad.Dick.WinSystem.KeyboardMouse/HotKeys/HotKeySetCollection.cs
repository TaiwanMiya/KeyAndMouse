using System.Collections.Generic;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Hotkeys
{
    /// <summary>
    ///     HotKeySet 的集合
    /// </summary>
    public sealed class HotKeySetCollection : List<HotKeySet>
    {
        private KeyChainHandler m_keyChain;

        /// <summary>
        ///     將 HotKeySet 添加到集合中
        /// </summary>
        /// <param name="hks"></param>
        public new void Add(HotKeySet hks)
        {
            m_keyChain += hks.OnKey;
            base.Add(hks);
        }

        /// <summary>
        ///     從集合中移除 HotKeySet
        /// </summary>
        /// <param name="hks"></param>
        public new void Remove(HotKeySet hks)
        {
            m_keyChain -= hks.OnKey;
            base.Remove(hks);
        }

        /// <summary>
        ///     如果 Key 被任何 HotKeySet 使用, 則使用多案例委託來調用各個 HotKeySet
        /// </summary>
        /// <param name="e"></param>
        internal void OnKey(KeyEventArgsExt e)
        {
            if (m_keyChain != null)
                m_keyChain(e);
        }

        private delegate void KeyChainHandler(KeyEventArgsExt kex);
    }
}