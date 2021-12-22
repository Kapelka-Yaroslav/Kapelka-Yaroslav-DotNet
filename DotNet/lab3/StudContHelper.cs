using System.IO;
using System.Linq;

namespace lab3
{
    class StudContHelper
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
    }
}