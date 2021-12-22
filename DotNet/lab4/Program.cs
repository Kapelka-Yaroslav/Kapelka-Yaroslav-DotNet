using System;
using System.IO;

namespace lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var studList = new StudCont();
            studList.Add(new Student("Каркуша Дмитрий Евгениевич", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 95));
            studList.Add(new Student("Черняева Влада Станислвовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "А", 119, "КИТ", "Компьютерные игры", 94));
            studList.Add(new Student("Капелька Ярослав Иванович", new DateTime(2002, 6, 7), new DateTime(2019, 9, 1), "А", 119, "КИТ", "Компьютерные игры", 67));
            studList.Add(new Student("Аксьонов Александр Юрьевич", new DateTime(2002, 3, 10), new DateTime(2019, 9, 1), "В", 419, "КИТ", "АТМ", 75));
            studList.Add(new Student("Момот Роман Анатолиевич", new DateTime(2002, 12, 24), new DateTime(2019, 9, 1), "В", 419, "КИТ", "АТМ", 71));

            var name = "Капелька Ярослав Иванович";
            var stud = studList.GetStudent(name);

            Console.WriteLine($"Группа студента {name}: {stud.Group}");
            Console.WriteLine("\n");

            Console.WriteLine($"Курс студента {name}: {stud.Year}");
            Console.WriteLine("\n");

            Console.WriteLine($"Семестр студента {name}: {stud.Semester}");
            Console.WriteLine("\n");

            Console.WriteLine($"Возраст студента {name}: {stud.Age}");
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
