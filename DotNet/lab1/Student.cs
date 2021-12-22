using System;

namespace lab1
{
    class Student
    {
        //Поля
        private string name { set; get; }

        private string surname { set; get; }

        private string patronymic { set; get; }

        DateTime DOB { set; get; }

        DateTime DOA { set; get; }

        private char groupIndex { set; get; }

        private string faculty { set; get; }

        private string speciality { set; get; }

        private byte performance { set; get; }
        //Свойства
        public DateTime GetDateOfAdmission()
        {
            return DOA;
        }

        public void SetDateOfAdmission(int year, int month, int day)
        {
            DateCheck(year, month, day);
            DOA = new DateTime(year, month, day);
        }

        public DateTime GetDateOfBrth()
        {
            return DOB;
        }
        public void SetDateOfBrth(int year, int month, int day)
        {
            DateCheck(year, month, day);
            DOB = new DateTime(year, month, day);
        }


        public void GetInfo()
        {
            Console.WriteLine("Студент " + name + " " + surname + " " + patronymic + " группы " + groupIndex + " факультета " + faculty + " специальности " + speciality + ", " + GetDateOfBrth() + " даты рождения, " + GetDateOfAdmission() + " даты поступления имеет успеваемость " + performance + "%");
        }

        public Student(string nm, string srnm, string patr, char Gin, string fcl, string spc, DateTime Birth, DateTime Adm, byte persent)
        {
            DateCheck(Birth.Year, Birth.Month, Birth.Day);
            DateCheck(Adm.Year, Adm.Month, Adm.Day);
            name = nm;
            surname = srnm;
            patronymic = patr;
            groupIndex = Gin;
            faculty = fcl;
            speciality = spc;
            DOB = Birth;
            DOA = Adm;
            performance = persent;
        }


        public void DateCheck(int year, int month, int day)
        {
            var currentYear = DateTime.Now.Year;
            if (year > currentYear)
            {
                Console.WriteLine("Год введен некорректно!");
            }
            if(month > 12 && month <= 0)
            {
                Console.WriteLine("Месяц введен некорректно!");
            }
            if(day > 31 && day <= 0)
            {
                Console.WriteLine("День введен некорректно!");
            }
        }
    }
}
