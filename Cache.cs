using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace C__Advanced_01
{
    internal class Cache<TKey, TValue>
    {
        public CacheItem<TKey, TValue> item;
        List<CacheItem<TKey, TValue>> items = new List<CacheItem<TKey, TValue>>();
        public void Add(TKey key, TValue value, TimeSpan expiration)
        {
            item = new CacheItem<TKey, TValue>(key, value, expiration);
            items.Add(item);
        }

        public TValue Get(TKey key)
        {
            return items.First(x => x.Key.Equals(key)).Value;
        }

        public void Remove(TKey key)
        {
            item = items.FirstOrDefault(x => x.Key.Equals(key));

            if (item != null)
                items.Remove(item);
        }

        public bool Contains(TKey key)
        {
            return items.Any(x => x.Key.Equals(key));
        }
    }
}
