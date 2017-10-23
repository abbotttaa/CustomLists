using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            Marbles<int> list = new Marbles<int>();
            list.Add(4);
            Console.WriteLine(list[0]);
            Console.ReadLine();
        }
    }
}
