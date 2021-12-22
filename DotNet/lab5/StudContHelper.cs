using System;
using System.IO;
using System.Linq;

namespace Lab5
{
    public class StudContHelper
    {
        public string Path { get; set; }
        public StudCont Container { get; set; }

        public StudContHelper(StudCont cont = null, string path = "output.txt")
        {
            Path = path;
            Container = cont;
        }
        public void Write(StudCont cont = null, string path = null)
        {
            StudCont rescont = cont ?? Container;
            string respath = path ?? Path;
            if (rescont != null)
            {
                File.WriteAllLines(respath, rescont.ToList());
            }
        }
        public StudCont Read(string path = null)
        {
            string respath = path ?? Path;
            string[] lines = File.ReadAllLines(respath);
            StudCont rescont = new StudCont();
            foreach (var line in lines)
            {
                rescont.Add(Student.ParseString(line));
            }
            return rescont;
        }
        public string ToTable(StudCont cont)
        {
            string result = $"|{"Ф.И.О",-30}|{"Группа",-10}|{"Успеваемость",-15}|\n";
            result += "|---------------------------------------------------------|\n";
            foreach (Student stud in cont)
            {
                result += $"|{stud.Name,-30}|{stud.Group,-10}|{stud.Performance,-15}|\n";
                result += "|---------------------------------------------------------|\n";
            }
            return result;
        }
        public string ToTable(StudCont cont, Student.Compare comp, string line)
        {
            string result = $"|{"Ф.И.О",-30}|{"Группа",-10}|{"Успеваемость",-15}|\n";
            result += "|---------------------------------------------------------|\n";
            foreach (Student stud in cont)
            {
                if (comp(stud, line))
                {
                    result += $"|{stud.Name,-30}|{stud.Group,-10}|{stud.Performance,-15}|\n";
                    result += "|---------------------------------------------------------|\n";
                };
            }
            return result;
        }
    }
}
