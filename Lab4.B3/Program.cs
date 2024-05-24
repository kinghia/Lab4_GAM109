using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab4.B3.Program;

namespace Lab4.B3
{
    internal class Program
    {
        public class student
        {
            public string id;
            public string name;
            public int age;

            public student(string _id, string _name, int _age)
            {
                id = _id;
                name = _name;
                age = _age;
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<student> list = new List<student>();
            list.Add(new student("1", "Bảo Trần", 16));
            list.Add(new student("2", "Quốc Phan", 13));
            list.Add(new student("3", "Tài Huỳnh", 19));
            list.Add(new student("4", "Thuận Lê", 18));
            list.Add(new student("5", "Nghia Hữu", 20));

            //a/ Xuất ra màn hình các student có Age > 12 và Age <20 bằng cách dùng LINQ Query Syntax
            var query = from student in list
                              where student.age > 12 && student.age < 20
                              select student;
            Console.WriteLine("Các sinh viên có tuổi từ 12 đến 20 (LINQ Query Syntax) là: ");
            foreach (var student in query)
            {
                Console.WriteLine($"Name: {student.name}, Age: {student.age}");
            }

            //b/
            var method = list.Where(student => student.age > 12 && student.age < 20);

            Console.WriteLine("\nCác sinh viên có tuổi từ 12 đến 20 (LINQ Method Syntax):");
            foreach (var student in method)
            {
                Console.WriteLine($"Name: {student.name}, Age: {student.age}");
            }
        }
    }
}
