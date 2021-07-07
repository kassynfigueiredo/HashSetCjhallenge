using System;
using HashChallenge.Entities;
using System.Collections.Generic;

namespace HashChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());

            HashSet<Student> aStudent = new HashSet<Student>();
            for (int i = 1; i <= a; i++)
            {
                int x = int.Parse(Console.ReadLine());
                aStudent.Add(new Student(x));
            }

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());

            HashSet<Student> bStudent = new HashSet<Student>();
            for (int i = 1; i <= b; i++)
            {
                int x = int.Parse(Console.ReadLine());
                bStudent.Add(new Student(x));
            }

            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());

            HashSet<Student> cStudent = new HashSet<Student>();
            for (int i = 1; i <= c; i++)
            {
                int x = int.Parse(Console.ReadLine());
                cStudent.Add(new Student(x));
            }

            HashSet<Student> d = new HashSet<Student>(a);
            d.UnionWith(bStudent);
            d.UnionWith(cStudent);

            Console.WriteLine($"Total student: {d.Count}");
        }
    }
}
