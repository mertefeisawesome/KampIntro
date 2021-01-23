using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryClass
{
    class MyDictionary<TKey, TValue>
    {
        private List<TKey> _keys;
        private List<TValue> _values;

        public MyDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = _keys.IndexOf(key);
                TValue value = _values[index];
                return value;
            }

        }
        public TKey this[TValue val]
        {
            get
            {
                int index = _values.IndexOf(val);
                TKey key = _keys[index];
                return key;
            }

        }

        public void Add(TKey key, TValue val)
        {
            _keys.Add(key);
            _values.Add(val);
        }
    }
}
