using Studen_t;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager
{
    class StudentManager : Student
    {


        public StudentManager(string name, string surname, int age, int year) : base(name, surname, age, year)
        {
        }
        List<Student> Student = new List<Student>()
    {
        new Student("Иван","Иванов",19, 2),
        new Student("Сергей","Сидоров",23, 1),
        new Student("Игорь","Козлов",20, 2),
        new Student("Степан","Литвиненко",25, 3),
        new Student("Александр","Зинченко",22, 4),
        new Student("Марина","Степанова",19, 5),
        new Student("Юля","Слюсарь",18, 4),
    };


        public void Print()
        {
            foreach (Student student in Student)
            {
                Console.WriteLine(student.ToStrin());
            }
        }

        public void AddStudent(string name, string surname, int age, int year)
        {
            Student newStudent = new Student(name, surname, age, year);
            Student.Add(newStudent);
            Console.WriteLine("Новый студент добавлен");
        }
        public void RemoveStudent(string name, string surname, int age, int year)
        {
            Student studentToRemove = new Student(name, surname, age, year);

            int removedCount = Student.RemoveAll(student => student.Name == studentToRemove.Name &&
                                                           student.Surname == studentToRemove.Surname &&
                                                           student.Age == studentToRemove.Age &&
                                                           student.Year == studentToRemove.Year);

            if (removedCount > 0)
            {
                Console.WriteLine("Студент удален");
            }
            else
            {
                Console.WriteLine("Студент не найден");
            }
        }
        public void GetStudentsByYear(int year)
        {
            List<Student> studentsByYear = Student.FindAll(student => student.Year == year);
            Console.WriteLine($" на  {year} курсе учатся ");
            foreach (Student student in studentsByYear)
            {
                Console.WriteLine($" {student.Name.ToUpper()} {student.Surname.ToUpper()}");
            }
        }
        public void GetOldestStudent()
        {
            int maxAge = Student.Max(student => student.Age);

            Student oldestStudent = Student.FirstOrDefault(student => student.Age == maxAge);

            if (oldestStudent != null)
            {
                Console.WriteLine($"Самый старший студент: {oldestStudent.Name} {oldestStudent.Surname}");
            }
            else
            {
                Console.WriteLine("Студенты не найдены.");
            }
        }

    }
}
