using System.Runtime.InteropServices;

namespace Heptad.Dick.WinSystem.KeyboardMouse.Win32Api
{
    /// <summary>
    ///     <see cref="Point"/> 結構定義了一個點的 X 坐標和 Y 坐標
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        /// <summary>
        ///     指定 X 坐標
        /// </summary>
        public int X;

        /// <summary>
        ///     指定 Y 坐標
        /// </summary>
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }

        public bool Equals(Point other)
        {
            return other.X == X && other.Y == Y;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (obj.GetType() != typeof(Point)) return false;
            return Equals((Point) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}