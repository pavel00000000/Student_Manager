using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studen_t
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }

        public Student(string name, string surname, int age, int year)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Year = year;
        }
        public string ToStrin()
        {
            return $" Имя {Name}, Фамилия {Surname}, Возраст {Age}, Курс {Year}";
        }

    }
}
