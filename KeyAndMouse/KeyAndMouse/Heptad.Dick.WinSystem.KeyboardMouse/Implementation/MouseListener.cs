using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Heptad.Dick.WinSystem.KeyboardMouse.Win32Api;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Implementation
{
    /// <summary>
    ///     <para>
    ///         因為它是 P/Invoke 方法, 所以 GetSystemMetrics(int)
    ///     </para>
    ///     <para>
    ///         應在名為 NativeMethods、SafeNativeMethods 的類中定義
    ///     </para>
    ///     <para>
    ///         或者 UnsafeNativeMethods
    ///     </para>
    /// </summary>
    /// 
    /// <remarks>
    ///     參考來源 : https://msdn.microsoft.com/en-us/library/windows/desktop/ms724385(v=vs.85).aspx
    /// </remarks>
    internal static class NativeMethods
    {
        private const int SM_CXDRAG = 68;
        private const int SM_CYDRAG = 69;
        private const int SM_CXDOUBLECLK = 36;
        private const int SM_CYDOUBLECLK = 37;

        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int index);

        public static int GetXDragThreshold()
        {
            return GetSystemMetrics(SM_CXDRAG);
        }

        public static int GetYDragThreshold()
        {
            return GetSystemMetrics(SM_CYDRAG);
        }

        public static int GetXDoubleClickThreshold()
        {
            return GetSystemMetrics(SM_CXDOUBLECLK) / 2 + 1;
        }

        public static int GetYDoubleClickThreshold()
        {
            return GetSystemMetrics(SM_CYDOUBLECLK) / 2 + 1;
        }
    }

    internal abstract class MouseListener : BaseListener, IMouseEvents
    {
        private readonly ButtonSet m_DoubleDown;
        private readonly ButtonSet m_SingleDown;
        protected readonly Point m_UninitialisedPoint = new Point(-99999, -99999);
        private readonly int m_xDragThreshold;
        private readonly int m_yDragThreshold;
        private Point m_DragStartPosition;

        private bool m_IsDragging;

        private Point m_PreviousPosition;

        protected MouseListener(Subscribe subscribe)
            : base(subscribe)
        {
            m_xDragThreshold = NativeMethods.GetXDragThreshold();
            m_yDragThreshold = NativeMethods.GetYDragThreshold();
            m_IsDragging = false;

            m_PreviousPosition = m_UninitialisedPoint;
            m_DragStartPosition = m_UninitialisedPoint;

            m_DoubleDown = new ButtonSet();
            m_SingleDown = new ButtonSet();
        }

        public event MouseEventHandler MouseMove;
        public event EventHandler<MouseEventExtArgs> MouseMoveExt;
        public event MouseEventHandler MouseClick;
        public event MouseEventHandler MouseDown;
        public event EventHandler<MouseEventExtArgs> MouseDownExt;
        public event MouseEventHandler MouseUp;
        public event EventHandler<MouseEventExtArgs> MouseUpExt;
        public event MouseEventHandler MouseWheel;
        public event EventHandler<MouseEventExtArgs> MouseWheelExt;
        public event MouseEventHandler MouseHWheel;
        public event EventHandler<MouseEventExtArgs> MouseHWheelExt;
        public event MouseEventHandler MouseDoubleClick;
        public event MouseEventHandler MouseDragStarted;
        public event EventHandler<MouseEventExtArgs> MouseDragStartedExt;
        public event MouseEventHandler MouseDragFinished;
        public event EventHandler<MouseEventExtArgs> MouseDragFinishedExt;

        protected override bool Callback(CallbackData data)
        {
            var e = GetEventArgs(data);

            if (e.IsMouseButtonDown)
                ProcessDown(ref e);

            if (e.IsMouseButtonUp)
                ProcessUp(ref e);

            if (e.WheelScrolled)
            {
                if (e.IsHorizontalWheel)
                    ProcessHWheel(ref e);
                else
                    ProcessWheel(ref e);
            }

            if (HasMoved(e.Point))
                ProcessMove(ref e);

            ProcessDrag(ref e);

            return !e.Handled;
        }

        protected abstract MouseEventExtArgs GetEventArgs(CallbackData data);

        protected virtual void ProcessWheel(ref MouseEventExtArgs e)
        {
            OnWheel(e);
            OnWheelExt(e);
        }

        protected virtual void ProcessHWheel(ref MouseEventExtArgs e)
        {
            OnHWheel(e);
            OnHWheelExt(e);
        }

        protected virtual void ProcessDown(ref MouseEventExtArgs e)
        {
            OnDown(e);
            OnDownExt(e);
            if (e.Handled)
                return;

            if (e.Clicks == 2)
                m_DoubleDown.Add(e.Button);

            if (e.Clicks == 1)
                m_SingleDown.Add(e.Button);
        }

        protected virtual void ProcessUp(ref MouseEventExtArgs e)
        {
            OnUp(e);
            OnUpExt(e);
            if (e.Handled)
                return;

            if (m_SingleDown.Contains(e.Button))
            {
                OnClick(e);
                m_SingleDown.Remove(e.Button);
            }

            if (m_DoubleDown.Contains(e.Button))
            {
                e = e.ToDoubleClickEventArgs();
                OnDoubleClick(e);
                m_DoubleDown.Remove(e.Button);
            }
        }

        private void ProcessMove(ref MouseEventExtArgs e)
        {
            m_PreviousPosition = e.Point;

            OnMove(e);
            OnMoveExt(e);
        }

        private void ProcessDrag(ref MouseEventExtArgs e)
        {
            if (m_SingleDown.Contains(MouseButtons.Left))
            {
                if (m_DragStartPosition.Equals(m_UninitialisedPoint))
                    m_DragStartPosition = e.Point;

                ProcessDragStarted(ref e);
            }
            else
            {
                m_DragStartPosition = m_UninitialisedPoint;
                ProcessDragFinished(ref e);
            }
        }

        private void ProcessDragStarted(ref MouseEventExtArgs e)
        {
            if (!m_IsDragging)
            {
                var isXDragging = Math.Abs(e.Point.X - m_DragStartPosition.X) > m_xDragThreshold;
                var isYDragging = Math.Abs(e.Point.Y - m_DragStartPosition.Y) > m_yDragThreshold;
                m_IsDragging = isXDragging || isYDragging;

                if (m_IsDragging)
                {
                    OnDragStarted(e);
                    OnDragStartedExt(e);
                }
            }
        }

        private void ProcessDragFinished(ref MouseEventExtArgs e)
        {
            if (m_IsDragging)
            {
                OnDragFinished(e);
                OnDragFinishedExt(e);
                m_IsDragging = false;
            }
        }

        private bool HasMoved(Point actualPoint)
        {
            return m_PreviousPosition != actualPoint;
        }

        protected virtual void OnMove(MouseEventArgs e)
        {
            MouseMove?.Invoke(this, e);
        }

        protected virtual void OnMoveExt(MouseEventExtArgs e)
        {
            MouseMoveExt?.Invoke(this, e);
        }

        protected virtual void OnClick(MouseEventArgs e)
        {
            MouseClick?.Invoke(this, e);
        }

        protected virtual void OnDown(MouseEventArgs e)
        {
            MouseDown?.Invoke(this, e);
        }

        protected virtual void OnDownExt(MouseEventExtArgs e)
        {
            MouseDownExt?.Invoke(this, e);
        }

        protected virtual void OnUp(MouseEventArgs e)
        {
            MouseUp?.Invoke(this, e);
        }

        protected virtual void OnUpExt(MouseEventExtArgs e)
        {
            MouseUpExt?.Invoke(this, e);
        }

        protected virtual void OnWheel(MouseEventArgs e)
        {
            MouseWheel?.Invoke(this, e);
        }

        protected virtual void OnWheelExt(MouseEventExtArgs e)
        {
            MouseWheelExt?.Invoke(this, e);
        }

        protected virtual void OnHWheel(MouseEventArgs e)
        {
            MouseHWheel?.Invoke(this, e);
        }

        protected virtual void OnHWheelExt(MouseEventExtArgs e)
        {
            MouseHWheelExt?.Invoke(this, e);
        }

        protected virtual void OnDoubleClick(MouseEventArgs e)
        {
            MouseDoubleClick?.Invoke(this, e);
        }

        protected virtual void OnDragStarted(MouseEventArgs e)
        {
            MouseDragStarted?.Invoke(this, e);
        }

        protected virtual void OnDragStartedExt(MouseEventExtArgs e)
        {
            MouseDragStartedExt?.Invoke(this, e);
        }

        protected virtual void OnDragFinished(MouseEventArgs e)
        {
            MouseDragFinished?.Invoke(this, e);
        }

        protected virtual void OnDragFinishedExt(MouseEventExtArgs e)
        {
            MouseDragFinishedExt?.Invoke(this, e);
        }
    }
}
