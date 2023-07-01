using System.Collections;

namespace Collections
{
    public class Dictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private Array<TKey> _keys;
        private Array<TValue> _values;
        public Dictionary()
        {
            _keys = new Array<TKey>();
            _values = new Array<TValue>();
        }
        public void Add(TKey key, TValue value)
        {
            _keys.Add(key);
            _values.Add(value);
        }
        public bool ContainsKey(TKey key) => _keys.Contains(key);
        public bool Remove(TKey key)
        {
            int index = _keys.IndexOf(key);
            if (index >= 0)
            {
                _keys.RemoveAt(index);
                _values.RemoveAt(index);
                return true;
            }
            return false;
        }
        public TValue this[TKey key]
        {
            get
            {
                int index = _keys.IndexOf(key);

                if (index >= 0)
                {
                    return _values[index];
                }

                else
                {
                    throw new NullReferenceException("Key is not found!"); 
                }
            }
            set
            {
                int index = _keys.IndexOf(key);

                if (index >= 0)
                {
                    _values[index] = value;
                }
                else
                {
                    Add(key, value);
                }
            }
        }
        public int Count => _keys.Length; 
        public void Clear()
        {
            _keys.Clear();
            _values.Clear();
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(_keys[i], _values[i]);
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public Array<TKey> Keys => _keys;
        public Array<TValue> Values => _values; 
    }
}

