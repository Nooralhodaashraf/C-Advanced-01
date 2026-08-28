using System;
using System.Collections.Generic;
using System.Text;

namespace C__Advanced_01
{
    internal class CacheItem<TKey, TValue>
    {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public TimeSpan Expiration { get; set; }

            public CacheItem(TKey key, TValue value, TimeSpan expiration)
            {
                Key = key;
                Value = value;
                Expiration = expiration;
            }
        }
    }

