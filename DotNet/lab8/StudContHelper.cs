using System;
using System.IO;
using System.Linq;

namespace lab8
{
    public class StudContHelper
    {

        public StudContHelper(StudCont cont = null, string path = "output.txt")
        {
        }
        public void Write(StudCont cont = null, string path = null)
        {
            string respath = path;
            if (cont != null)
            {
                File.WriteAllLines(respath, cont.ToList());
            }
        }
        public static StudCont Read(string path = null)
        {
            string[] lines = File.ReadAllLines(path);
            StudCont rescont = new StudCont();
            foreach (var line in lines)
            {
                rescont.Add(Student.ParseString(line));
            }
            return rescont;
        }

        public static string ToTable(StudCont cont)
        {
            string result = $"|{"Ф.И.О",-35}|{"Группа",-10}|{"Успеваемость",-15}|\n";
            result += "|--------------------------------------------------------------|\n";
            foreach (Student stud in cont)
            {
                result += $"|{stud.Name,-35}|{stud._group,-10}|{stud.Performance,-15}|\n";
                result += "|--------------------------------------------------------------|\n";
            }
            return result;
        }
        public static string ToTable(StudCont cont, Student.Compare comp, string line)
        {
            string result = $"|{"Ф.И.О",-35}|{"Группа",-10}|{"Успеваемость",-15}|\n";
            result += "|--------------------------------------------------------------|\n";
            foreach (Student stud in cont)
            {
                if (comp(stud, line))
                {
                    result += $"|{stud.Name,-35}|{stud._group,-10}|{stud.Performance,-15}|\n";
                    result += "|--------------------------------------------------------------|\n";
                };
            }
            return result;
        }

    }
}