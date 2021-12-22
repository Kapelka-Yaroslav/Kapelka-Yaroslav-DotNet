using System;
using System.Collections.Generic;
using System.Text.Json;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            var studList = new StudCont();
            studList.Add(new Student("Каркуша Дмитрий Евгениевич", new DateTime(2002, 4, 2), new DateTime(2019, 9, 1), "Б", 119, "КИТ", "Компьютерные игры", 95));
            studList.Add(new Student("Черняева Влада Станислвовна", new DateTime(2001, 12, 8), new DateTime(2019, 9, 1), "А", 119, "КИТ", "Компьютерные игры", 94));
            studList.Add(new Student("Капелька Ярослав Иванович", new DateTime(2002, 6, 7), new DateTime(2019, 9, 1), "А", 119, "КИТ", "Компьютерные игры", 67));

            Console.WriteLine(StudContHelper.ToTable(studList));

            studList.Reset();
            studList.Sort(StudCont.SortType.Performance);

            Console.WriteLine("Сортировка по успеваемости.\n");

            studList.Reset();
            Console.WriteLine(StudContHelper.ToTable(studList));
            Console.ReadLine();
        }
    }
}