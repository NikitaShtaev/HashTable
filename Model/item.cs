

using System.Collections.Generic;

namespace HashTable.Model
{
    public class item<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }
        public item(int key)
        {
            Key = key;
            Nodes = new List<T>();
        }

    }
}
