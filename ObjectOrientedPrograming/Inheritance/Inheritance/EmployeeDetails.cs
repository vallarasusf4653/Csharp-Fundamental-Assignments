using System;

namespace Inheritance
{
    public class EmployeeDetails : PersonalDetails
    {
        public string EmpID { get; set; }


        public string Role { get; set; }

        public EmployeeDetails(string paramName, int paramAge, string paramGender, string paramEmpID, string paramRole) : base(paramName, paramAge, paramGender)
        {
            this.EmpID = paramEmpID;
            this.Role = paramRole;
        }


    }
}
