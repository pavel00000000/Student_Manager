
//Разработайте приложение для учета студентов в университете. Ваша задача - создать класс "Student" для представления студента и класс "StudentManager", который будет отвечать за управление списком студентов.
//Класс "Student" должен содержать следующие поля:
//Имя(Name) - строковое поле.
//Фамилия(Surname) - строковое поле.
//Возраст(Age) - целочисленное поле.
//Курс(Year) - целочисленное поле.
//Класс "Student" должен также иметь конструктор, который принимает значения для всех полей и метод "ToString()", который возвращает строковое представление объекта студента.
//Класс "StudentManager" должен содержать список (List) студентов и иметь следующие методы:
//AddStudent(Student student): добавляет студента в список.
//RemoveStudent(Student student): удаляет студента из списка.
//GetStudentsByYear(int year): возвращает список студентов, находящихся на указанном курсе.
//GetOldestStudent(): возвращает самого старшего студента из списка.
//Создайте консольное приложение, которое будет взаимодействовать с пользователем. Пользователь должен иметь возможность добавлять студентов, удалять студентов, просматривать список студентов на определенном курсе и получать информацию о самом старшем студенте.
//Приложение должно работать до тех пор, пока пользователь не введет команду для выхода.

using System;
using Studen_t;
using Student_Manager;
using System.Threading.Tasks.Dataflow;

StudentManager studentManager = new StudentManager("Имя", "Фамилия", 20, 3);

bool exit = false;

while (!exit)
{
    Console.WriteLine("0 Выход");
    Console.WriteLine("1 Список студентов");
    Console.WriteLine("2 Добавить студента");
    Console.WriteLine("3 Удалить студента");
    Console.WriteLine("4 Показать список студентов на определенном курсе ");
    Console.WriteLine("5 Получить информацию о самом старшем студенте.");
    string command = Console.ReadLine();

    switch (command)
    {
        case "0":
            exit = true;
            break;
        case "1":
            studentManager.Print();
            break;
        case "2":
            Console.WriteLine(" Введите имя студента");
            string N_Name = Console.ReadLine();
            Console.WriteLine(" Введите фамилию стулента");
            string N_Surname = Console.ReadLine();
            Console.WriteLine(" Введите возраст студента");
            int N_Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите введите курс студента");
            int N_Year = Convert.ToInt32(Console.ReadLine());
            studentManager.AddStudent(N_Name, N_Surname, N_Age, N_Year);
            break;
       case "3":
            Console.WriteLine(" Введите имя студента");
            string A_Name = Console.ReadLine();
            Console.WriteLine(" Введите фамилию стулента");
            string A_Surname = Console.ReadLine();
            Console.WriteLine(" Введите возраст студента");
            int A_Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите введите курс студента");
            int A_Year = Convert.ToInt32(Console.ReadLine());
   
            studentManager.RemoveStudent(A_Name, A_Surname, A_Age, A_Year);
            break;
       case "4":
            Console.WriteLine(" Введите введите курс студента");
            int B_Year = Convert.ToInt32(Console.ReadLine());
            if (B_Year > 5)
            {
                Console.WriteLine("Неверный курс");
                break;
            }
            studentManager.GetStudentsByYear(B_Year);
            break;
       case "5":
           
            studentManager.GetOldestStudent();
            break;
        default:
            Console.WriteLine("Неизвестная команда");
            break;
    }
}

Console.WriteLine("Программа завершена.");
    

