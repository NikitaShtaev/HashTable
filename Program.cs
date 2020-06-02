using HashTable.Model;
using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var NormalHT2 = new NormalHashTable<Person>(100);
            var newperson2 = new Person() { Name = $"N{1}", Age = 1 + 20, Gender = 1 % 2 };
            Console.WriteLine(newperson2.ToString());
            NormalHT2.WriteHash(newperson2);

            Console.WriteLine("==============");

            for (int i = 0; i < 10; i++)
            {
                var newperson = new Person() { Name = $"N{i}", Age = i + 20, Gender = i % 2 };
                NormalHT2.Add(newperson);
                Console.WriteLine(newperson.ToString());
                NormalHT2.WriteHash(newperson);
            }
            Console.WriteLine(NormalHT2.Search(newperson2));
            Console.ReadLine();
            #region MyHT
            //var MyHT = new MyHashTable<int, string>(100);
            //for (int i = 0; i < 10; i++)
            //{
            //    MyHT.Add(i, $"{i}");
            //    MyHT.WriteHash(i+10);
            //}
            //Console.WriteLine(MyHT.Search(0,"0"));
            //Console.WriteLine(MyHT.Search(10,"10"));
            //Console.ReadLine();
            #endregion
            #region BadHashTable
            //var BadHT = new BadHashTable<int>(100);
            //for (int i = 0; i < 10; i++)
            //{
            //    BadHT.Add(i);
            //}
            //Console.WriteLine(BadHT.Search(0));
            //Console.WriteLine(BadHT.Search(5));
            //Console.ReadLine();
            #endregion
        }
    }
}
