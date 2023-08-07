using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Linq;

namespace Ky.Hbe.WorkerPortal.Infrastructure.Model
{

    public static class KYDictionaryExtensions
    {
        public static KYDictionary<T, V> ToKYDictionary<T, V>(this Dictionary<T, V> dict)
        {
            KYDictionary<T, V> kyDict = new KYDictionary<T, V>();

            foreach (var key in dict.Keys)
            {
                kyDict.Add(key, dict[key]);
            }

            return kyDict;
        }
    }

    public class KYDictionary<T, V> : IEnumerable<KYKeyValuePair<T, V>>
    {

        private readonly Dictionary<T, V> dummyDictionary;
        private readonly List<KYKeyValuePair<T, V>> items;
        public KYDictionary()
        {
            items = new List<KYKeyValuePair<T, V>>();
            dummyDictionary = new Dictionary<T, V>();
        }


        public KYDictionary(IDictionary<T, V> dictionary)
        {
            items = new List<KYKeyValuePair<T, V>>();
            dummyDictionary = new Dictionary<T, V>();

            foreach (var key in dictionary.Keys)
            {
                Add(key, dictionary[key]);
            }
        }


        public KYDictionary(KYDictionary<T, V> dictionary)
        {
            items = new List<KYKeyValuePair<T, V>>();
            dummyDictionary = new Dictionary<T, V>();

            foreach (var key in dictionary.Keys)
            {
                Add(key, dictionary[key]);
            }
        }


        IEnumerator<KYKeyValuePair<T, V>> IEnumerable<KYKeyValuePair<T, V>>.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public V this[T key]
        {
            get
            {
                return dummyDictionary[key];
            }
            set
            {
                if (dummyDictionary.ContainsKey(key))
                {

                    Update(key, value); //update
                }
                else
                {
                    Add(key, value); //add
                }
            }
        }

        private void Update(T key, V value)
        {
            dummyDictionary[key] = value;
            items.First(i => ((object)i.Key).ToString() == ((object)key).ToString()).Value = value;
        }

        public void Add(T key, V value)
        {
            dummyDictionary.Add(key, value);
            items.Add(new KYKeyValuePair<T, V>(key, value));
        }

        public Dictionary<T, V> GetAsDictionary()
        {
            return dummyDictionary;
        }

        public bool ContainsKey(T key)
        {
            return dummyDictionary.ContainsKey(key);
        }

        public void Clear()
        {
            items.Clear();
            dummyDictionary.Clear();
        }

        public Dictionary<T, V>.ValueCollection Values
        {
            get
            {
                return dummyDictionary.Values;
            }
        }

        public Dictionary<T, V>.KeyCollection Keys
        {
            get
            {
                return dummyDictionary.Keys;
            }
        }

        public bool Remove(T key)
        {
            bool isRemoved = dummyDictionary.Remove(key);

            if (isRemoved) //also remove from inner list
            {
                var removealbeItem = items.First(i => ((object)i.Key).ToString() == ((object)key).ToString());
                items.Remove(removealbeItem);
            }

            return isRemoved;
        }

        public int Count
        {
            get
            {
                return dummyDictionary.Count;
            }
        }

        public bool ContainsValue(V value)
        {
            return dummyDictionary.ContainsValue(value);
        }
    }

}
