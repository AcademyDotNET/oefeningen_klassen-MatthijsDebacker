using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTester
{
    class Student
    {
        public string Name { get; set; }
        private int grade;
        public int Grade { 
            get { return grade; }
            set
            {
                if(value >= 0  && value <= 20)
                {
                    grade = value;
                }
            }
        }
        public bool Passed
        {
            get
            {
                if (Grade >= 10)
                {
                    return true;
                }
                return false;
            }
        }

        public Student(string name, int score)
        {
            Name = name;
            Grade = score;
        }

        public override string ToString()
        {
            string str = $"Student: {Name} with a grade of {Grade} has";
            if(!Passed)
            {
                str += " not";
            }
            str += " passed";
            return str;
        }
    }
}
