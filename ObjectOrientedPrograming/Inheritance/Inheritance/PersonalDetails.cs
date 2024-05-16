using System;

namespace Inheritance
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public string Gender { get; set; }
        
        public PersonalDetails(string paramName,int paramAge,string paramGender)
        {
            this.Name=paramName;
            this.Age=paramAge;
            this.Gender=paramGender;
        }
        
    }
}
