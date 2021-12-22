using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class StudContCalculator
    {
        public StudCont Container { get; set; }
        public StudContCalculator(StudCont cont = null)
        {
            Container = cont;
        }

        public float AverageAge(Student.Compare comp, string line)
        {
            float total = 0;
            int count = 0;
            foreach (Student stud in Container)
            {
                if (comp(stud, line))
                {
                    total += stud.Age;
                    count++;
                }
            }
            return total / count;
        }

        public float AveragePerformance(Student.Compare comp, string line)
        {
            float total = 0;
            int count = 0;
            foreach (Student stud in Container)
            {
                if (comp(stud, line))
                {
                    total += stud.Performance;
                    count++;
                }
            }
            return total / count;
        }
    }
}