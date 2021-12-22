using System;
using System.Linq;

namespace lab3
{
    public class Student
    {
        private readonly string _name;
        private readonly DateTime _dateOfBirth;
        private readonly DateTime _dateOfAdmission;
        private string _groupIndex;
        private int _groupNum;
        private string _faculty;
        private string _specialty;
        private int _performance;
        private string[] _faculties = { "Э", "МИТ", "И", "ХТ", "БЭМ", "МО", "СГТ", "КН", "КИТ" };

        public Student(string name, DateTime dateOfBirth, DateTime dateOfAdmission, string groupIndex, int groupNum, string faculty, string specialty, int performance)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _dateOfBirth = dateOfBirth;
            _dateOfAdmission = dateOfAdmission;
            _groupIndex = groupIndex ?? throw new ArgumentNullException(nameof(groupIndex));
            _groupNum = groupNum;
            _faculty = faculty ?? throw new ArgumentNullException(nameof(faculty));
            _specialty = specialty ?? throw new ArgumentNullException(nameof(specialty));
            _performance = performance;
        }

        public string Name { get { return _name; } }
        public DateTime DateOfBith { get { return _dateOfBirth; } }
        public DateTime DateOfAdmission { get { return _dateOfAdmission; } }
        public string GroupIndex
        {
            get { return _groupIndex; }
            private set
            {
                if (value.Length <= 2 && value.Length != 0)
                {
                    _groupIndex = value;
                }
            }
        }
        public int GroupNum { get { return _groupNum; } private set { _groupNum = value; } }
        public string Faculty
        {
            get { return _faculty; }
            private set
            {
                if (_faculties.Contains(value.ToUpper()))
                {
                    _faculty = value.ToUpper();
                }
            }
        }
        public string Specialty { get { return _specialty; } private set { _specialty = value; } }
        public int Performance
        {
            get { return _performance; }
            set
            {
                if (value <= 100 && value >= 0)
                {
                    _performance = value;
                }
            }
        }
        public override string ToString()
        {
            string output = _name + ";" + _dateOfBirth.ToString() + ";" + _dateOfAdmission + ";" + _faculty + ";" + _groupNum + ";" + _groupIndex + ";" + _specialty + ";" + _performance;
            return output;
        }
        public static Student ParseString(string line)
        {
            string[] arr = line.Split(";");
            Student stud = new Student(arr[0], DateTime.Parse(arr[1]), DateTime.Parse(arr[2]), arr[5], Int32.Parse(arr[4]), arr[3], arr[6], Int32.Parse(arr[7]));
            return stud;
        }
        public string ToText()
        {
            string output = "Ф.И.О.: " + _name + "\nДата рождения: " + _dateOfBirth.ToString() + "\nДата поступления: " + _dateOfAdmission + "\nГруппа: " + _faculty + "-" + _groupNum + _groupIndex + "\nСпециальность: " + _specialty + "\nУспеваемость:" + _performance + "%";
            return output;
        }
    }
}