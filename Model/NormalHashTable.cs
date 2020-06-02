using System;

namespace HashTable.Model
{
    public class NormalHashTable<T>
    {
        private item<T>[] items;
        public NormalHashTable(int size)
        {
            items = new item<T>[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new item<T>(i);
            }
        }
        public void Add(T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item);
        }
        public bool Search(T item)
        {
            var key = GetHash(item);
            var show = items[key].Nodes.Contains(item);
            return items[key].Nodes.Contains(item);
        }
        private int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
        public void WriteHash(T item)
        {
            Console.WriteLine("HashCode: " + item.GetHashCode() % items.Length);
        }
    }
}
