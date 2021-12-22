using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var studList = new StudCont();
            var studHelper = new StudContHelper();
            var studCalc = new StudContCalculator();
            studList.Add(new Student("Каркуша Дмитрий Евгениевич", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 95));
            studList.Add(new Student("Черняева Влада Станислвовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "А", 119, "КИТ", "Компьютерные игры", 94));
            studList.Add(new Student("Капелька Ярослав Иванович", new DateTime(2002, 6, 7), new DateTime(2019, 9, 1), "А", 119, "КИТ", "Компьютерные игры", 67));

            studCalc.Container = studList;
            Console.WriteLine();
            Console.WriteLine(studHelper.ToTable(studList, Student.CompareSpecialty, "Компьютерные игры"));
            studList.Reset();
            Console.WriteLine("Средний возраст группы КИТ-119А: " + studCalc.AverageAge(Student.CompareGroup, "КИТ-119А"));

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(studList, options);

            Console.WriteLine(jsonString);

            StudCont studList2 = new StudCont(JsonSerializer.Deserialize<List<Student>>(jsonString));
            foreach (Student stud in studList2)
            {
                Console.WriteLine(stud.ToText());
            }

            Console.ReadLine();
        }
    }
}