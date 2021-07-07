using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashChallenge.Entities
{
    class Student
    {
        public int Number { get; set; }

        public Student(int number)
        {
            Number = number;
        }
        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return Number.Equals(other.Number);
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
