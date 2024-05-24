using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.B1
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Các số trong danh sách là:");
            foreach ( var i in list )
            {
                Console.WriteLine(i);
            }

            var newlist = list.FindAll(item => item % 2 == 0);
            Console.WriteLine("Các số chẵn trong danh sạch là:");
            foreach ( var item in newlist )
            {
                Console.WriteLine(item);
            }
        }
    }
}
