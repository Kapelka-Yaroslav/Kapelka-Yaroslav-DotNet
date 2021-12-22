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
            StudContHelper helper = new StudContHelper(studList);
            helper.Write();
            var studList2 = helper.Read();
            studList2.PrintAll(false);
            var name = "Капелька Ярослав Иванович";
            var stud = studList2.GetStudent(name);
            stud.Performance += 5;
            studList2.ChangeStudent(name, stud);
            Console.WriteLine("\nВывод изменненых данных: \n\n");
            studList2.PrintAll(false);
            File.WriteAllText("C:\\Users\\Admin\\source\\repos\\lab3\\output.txt", stud.ToString() + "\n");
            Console.ReadLine();
        }
    }
}