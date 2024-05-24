using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class userData
        {
            public string name;
            public int level;
            public userData(string _name, int lv)
            {
                name = _name;
                level = lv;
            }
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<userData> list = new List<userData>();
            list.Add(new userData("GTA 5", 10));
            list.Add(new userData("Genshin impact", 15));
            list.Add(new userData("Gunny", 5));
            list.Add(new userData("Liên Minh Huyền Thoại", 100));

            var selectedData = list.Select(u => new { u.name, u.level });
            foreach (var item in selectedData)
            {
                Console.WriteLine("Name: " + item.name + " | Level: " + item.level);
            }
        }
    }
}
