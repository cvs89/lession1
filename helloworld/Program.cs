using System;
using System.Linq;
using System.Collections.Generic;
namespace helloworld
{
    class Janrual
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int addEntries(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }
        public void removeEntries(int index)
        {
            entries.RemoveAt(index);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Janrual j = new Janrual();
            j.addEntries("test1 for first time");
            j.addEntries("test2 for Second time");

            Console.WriteLine(j);

            j.removeEntries(1);

            Console.WriteLine(j);

        }
    }
}
