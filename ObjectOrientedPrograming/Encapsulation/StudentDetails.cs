using System;

namespace Encapsulation
{
    public class StudentDetails
    {
        private string _studentName;
        private int _age;

        public string StudentName
        {
            get { return _studentName; }
            set {  _studentName=value; }
        }
        public int Age
        {
            get { return _age; }
            set {_age=value; }
        }

        public void Show()
        {
            Console.WriteLine($"{_studentName} {_age}");
        }

    }
}
