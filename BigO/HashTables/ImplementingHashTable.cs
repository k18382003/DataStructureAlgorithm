using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.HashTables
{
    public class ImplementingHashTable
    {
        private object[] data;

        public ImplementingHashTable(int size)
        {
            this.data = new object[size];
        }

        private int _hash(string key)
        {
            var hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % this.data.Length;
            }
            return hash;
        }

        public void Set(string key, object value)
        {
            var address = _hash(key);
            var bucket = new List<Dictionary<string, object>>();
            var keyvalues = new Dictionary<string, object>();
            if (this.data[address] == null)
            {
                this.data[address] = bucket;
            }
            keyvalues.Add(key, value);
            ((List<Dictionary<string, object>>)this.data[address]).Add(keyvalues);
        }

        public object Get(string key)
        {
            var res = "Not Found";
            var position = data[_hash(key)];
            if (position == null)
                return res;
            foreach (var item in (List<Dictionary<string, object>>)position)
            {
                if (item.ContainsKey(key))
                    return item[key];
            }
            return res;
        }
    }
}
