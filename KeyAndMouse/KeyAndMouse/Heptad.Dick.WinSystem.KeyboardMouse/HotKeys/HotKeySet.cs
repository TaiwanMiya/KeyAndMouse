using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse.Implementation;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Hotkeys
{
    /// <summary>
    ///     一組不可變的熱鍵, 在激活該組時提供事件
    /// </summary>
    public class HotKeySet
    {
        /// <summary>
        ///     代表 <see cref="OnHotKeysDownHold"/> 事件簽名的委託
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void HotKeyHandler(object sender, HotKeyArgs e);

        /// <summary>
        ///     跟踪密鑰集的狀態
        /// </summary>
        private readonly Dictionary<Keys, bool> m_hotkeystate;

        /*
         * m_remapping 的例子：
         * 從所請求的鍵集中選擇一個鍵作為參考鍵 (又名主鍵)
         * 
         * m_remapping[ Keys.LShiftKey ] = Keys.LShiftKey
         * m_remapping[ Keys.RShiftKey ] = Keys.LShiftKey
         * 
         * 這允許 m_hotkeystate 使用集合中的單個鍵(主鍵), 它將代表集合中的所有鍵,
         * 這反過來減少了:
         * 
         * Keys k = Keys.RShiftKey
         * Keys primaryKey = PrimaryKeyOf( k ) = Keys.LShiftKey
         * m_hotkeystate[ primaryKey ] = true/false
         */

        /// <summary>
        ///     用於將多個鍵映射到單個鍵
        /// </summary>
        private readonly Dictionary<Keys, Keys> m_remapping;

        /// <summary>
        ///     默認啟用
        /// </summary>
        private bool m_enabled = true;

        // 這些提供了集合是否真正被激活的實際狀態

        /// <summary>
        ///     按下的熱鍵數
        /// </summary>
        private int m_hotkeydowncount;

        private int m_remappingCount;
        // 重新映射的數量，即一組映射，而不是 m_remapping 中的單個計數

        /// <summary>
        ///     創建 HotKeySet 類的實例
        ///     <para>
        ///         一旦創建, 密鑰就無法更改
        ///     </para>
        /// </summary>
        /// 
        /// <param name="hotkeys">
        ///     熱鍵集
        /// </param>
        public HotKeySet(IEnumerable<Keys> hotkeys)
        {
            m_hotkeystate = new Dictionary<Keys, bool>();
            m_remapping = new Dictionary<Keys, Keys>();
            HotKeys = hotkeys;
            InitializeKeys();
        }

        /// <summary>
        ///     啟用命名集合的設定
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     啟用描述集合用於或應該做什麼的設定
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     獲取此類處理的一組熱鍵
        /// </summary>
        public IEnumerable<Keys> HotKeys { get; }

        /// <summary>
        ///     返回這組 Keys 是否被激活
        /// </summary>
        public bool HotKeysActivated
        {
            get { return m_hotkeydowncount == m_hotkeystate.Count - m_remappingCount; }
        }

        /// <summary>
        ///     獲取或設置 HotKey 集的啟用狀態
        /// </summary>
        public bool Enabled
        {
            get { return m_enabled; }
            set
            {
                if (value)
                    InitializeKeys(); //必須獲取每個鍵的實際當前狀態才能更新

                m_enabled = value;
            }
        }

        /// <summary>
        ///     當用戶按住集合中的鍵時調用, 第一次設置鍵時不會觸發它
        ///     <see cref="OnHotKeysDownOnce" />
        /// </summary>
        public event HotKeyHandler OnHotKeysDownHold;

        /// <summary>
        ///     <para>
        ///         每當熱鍵集不再活動時調用
        ///     </para>
        ///     <para>
        ///         這本質上是一個 KeyPress 事件
        ///     </para>
        ///     <para>
        ///         表明發生了一個完整的鍵循環, 僅針對 HotKeys
        ///     </para>
        ///     <para>
        ///         因為從集合中移除的單個鍵構成了一個不完整的集合
        ///     </para>
        /// </summary>
        public event HotKeyHandler OnHotKeysUp;

        /// <summary>
        ///     <para>
        ///         第一次設置向下鍵時調用
        ///     </para>
        ///     <para>
        ///         它不會在用戶持有它的整個持續時間內被調用
        ///     </para>
        ///     <para>
        ///         而只會在它第一次被激活時被調用
        ///     </para>
        /// </summary>
        public event HotKeyHandler OnHotKeysDownOnce;

        /// <summary>
        ///     通用調用處理程序
        /// </summary>
        /// <param name="hotKeyDelegate"></param>
        private void InvokeHotKeyHandler(HotKeyHandler hotKeyDelegate)
        {
            if (hotKeyDelegate != null)
                hotKeyDelegate(this, new HotKeyArgs(DateTime.Now));
        }

        /// <summary>
        ///     <para>
        ///         將密鑰添加到跟踪密鑰的字典中
        ///     </para>
        ///     <para>
        ///         並從操作系統獲取密鑰的實時狀態
        ///     </para>
        /// </summary>
        private void InitializeKeys()
        {
            foreach (var k in HotKeys)
            {
                if (m_hotkeystate.ContainsKey(k))
                    m_hotkeystate.Add(k, false);

                // 使用鍵盤的當前狀態分配
                m_hotkeystate[k] = KeyboardState.GetCurrent().IsDown(k);
            }
        }

        /// <summary>
        ///     取消註冊先前設置的獨占或基於主鍵
        /// </summary>
        /// 
        /// <param name="anyKeyInTheExclusiveOrSet">
        ///     註冊方法中用於創建獨占或集合的任何鍵
        /// </param>
        /// 
        /// <returns>
        ///     <para>
        ///         如果成功則為 <b>true</b>
        ///     </para>
        ///     <para>
        ///         <b>False</b> 不表示註銷失敗
        ///     </para>
        ///     <para>
        ///         它表示該鍵未註冊為異或鍵或者它不是主鍵
        ///     </para>
        /// </returns>
        public bool UnregisterExclusiveOrKey(Keys anyKeyInTheExclusiveOrSet)
        {
            var primaryKey = GetExclusiveOrPrimaryKey(anyKeyInTheExclusiveOrSet);

            if (primaryKey == Keys.None || !m_remapping.ContainsValue(primaryKey))
                return false;

            var keystoremove = new List<Keys>();

            foreach (var pair in m_remapping)
                if (pair.Value == primaryKey)
                    keystoremove.Add(pair.Key);

            foreach (var k in keystoremove)
                m_remapping.Remove(k);

            --m_remappingCount;

            return true;
        }

        /// <summary>
        ///     註冊一組已經是 HotKeySet 一部分的鍵, 以便在鍵之間提供更好的靈活性
        ///     <example>
        ///         <code>
        ///  HotKeySet hks = new HotKeySet( new [] { Keys.T, Keys.LShiftKey, Keys.RShiftKey } );
        ///  RegisterExclusiveOrKey( new [] { Keys.LShiftKey, Keys.RShiftKey } );
        ///  </code>
        ///         允許 Keys.LShiftKey 或 Keys.RShiftKey 與 Keys.T 結合使用
        ///     </example>
        /// </summary>
        /// 
        /// <param name="orKeySet"></param>
        /// 
        /// <returns>
        ///     用於映射的主鍵或 Keys.None 錯誤
        /// </returns>
        public Keys RegisterExclusiveOrKey(IEnumerable<Keys> orKeySet)
        {
            // 首先進行驗證, 以免 m_remapping 留下部分集
            foreach (var k in orKeySet)
                if (!m_hotkeystate.ContainsKey(k))
                    return Keys.None;

            var i = 0;
            var primaryKey = Keys.None;

            // 驗證後提交
            foreach (var k in orKeySet)
            {
                if (i == 0)
                    primaryKey = k;

                m_remapping[k] = primaryKey;

                ++i;
            }

            // 必須增加以準確計算激活所需的密鑰數量
            ++m_remappingCount;

            return primaryKey;
        }

        /// <summary>
        ///     獲取主鍵
        /// </summary>
        /// 
        /// <param name="k"></param>
        /// 
        /// <returns>
        ///     如果存在則主鍵, 否則為 Keys.None
        /// </returns>
        private Keys GetExclusiveOrPrimaryKey(Keys k)
        {
            return m_remapping.ContainsKey(k) ? m_remapping[k] : Keys.None;
        }

        /// <summary>
        ///     解決獲取用於狀態檢查的密鑰
        /// </summary>
        /// 
        /// <param name="k"></param>
        /// 
        /// <returns>
        ///     如果存在則主鍵, 否則輸入的鍵
        /// </returns>
        private Keys GetPrimaryKey(Keys k)
        {
            // 如果鍵被重新映射，則獲取主鍵
            return m_remapping.ContainsKey(k) ? m_remapping[k] : k;
        }

        /// <summary>
        /// </summary>
        /// <param name="kex"></param>
        internal void OnKey(KeyEventArgsExt kex)
        {
            if (!Enabled)
                return;

            // 如果映射到單個鍵, 則獲取主鍵或獲取鍵本身
            var primaryKey = GetPrimaryKey(kex.KeyCode);

            if (kex.IsKeyDown)
                OnKeyDown(primaryKey);
            else // 重置
                OnKeyUp(primaryKey);
        }

        private void OnKeyDown(Keys k)
        {
            // 如果仍然激活鍵, 則繼續調用事件
            if (HotKeysActivated)
            {
                InvokeHotKeyHandler(OnHotKeysDownHold); // 調用持續時間事件
            }

            // 表示鍵的狀態當前為 false, 但鍵現在已關閉
            else if (m_hotkeystate.ContainsKey(k) && !m_hotkeystate[k])
            {
                m_hotkeystate[k] = true; // 鍵的狀態為關閉
                ++m_hotkeydowncount; // 增加此組中的鍵數

                if (HotKeysActivated) // 因為增加了, 檢查set是否被激活
                    InvokeHotKeyHandler(OnHotKeysDownOnce); // 調用初始事件
            }
        }

        private void OnKeyUp(Keys k)
        {
            if (m_hotkeystate.ContainsKey(k) && m_hotkeystate[k]) // 表示鍵的狀態已關閉但現在已啟動
            {
                var wasActive = HotKeysActivated;

                m_hotkeystate[k] = false; // key 的狀態為 up
                --m_hotkeydowncount; // 這組不再準備好了

                if (wasActive)
                    InvokeHotKeyHandler(OnHotKeysUp); // 調用 KeyUp 事件, 因為該集合不再處於活動狀態
            }
        }
    }
}