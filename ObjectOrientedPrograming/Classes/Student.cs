using System;

namespace Classes
{
    public class Student
    {
        

        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        
        public Student(string paramName, int paramAge,string paramRole)
        {
            this.Name=paramName;
            this.Age=paramAge;
            this.Role=paramRole;
        }

        public string StudentInfo()
        {
            return $"Name : {Name}\nAge : {Age}\nRole : {Role}";
        }
        public string StudentInfo(string name)
        {
            return name;
        }
        
        
        
        
    }
}
