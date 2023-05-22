using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Heptad.Dick.WinSystem.KeyboardMouse
{
    /// <summary>
    /// 描述一系列通用對象
    /// </summary>
    /// 
    /// <typeparam name="T"></typeparam>
    public abstract class SequenceBase<T> : IEnumerable<T>
    {
        private readonly T[] _elements;

        /// <summary>
        /// 從序列元素創建一個序列實例
        /// </summary>
        /// 
        /// <param name="elements"></param>
        protected SequenceBase(params T[] elements)
        {
            _elements = elements;
        }

        /// <summary>
        /// 序列中的元素數量
        /// </summary>
        public int Length
        {
            get { return _elements.Length; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _elements.Cast<T>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(",", _elements);
        }

        protected bool Equals(SequenceBase<T> other)
        {
            if (_elements.Length != other._elements.Length) return false;
            return _elements.SequenceEqual(other._elements);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((SequenceBase<T>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_elements.Length + 13) ^
                       ((_elements.Length != 0
                            ? _elements[0].GetHashCode() ^ _elements[_elements.Length - 1].GetHashCode()
                            : 0) * 397);
            }
        }
    }
}