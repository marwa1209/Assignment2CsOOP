using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2CsOOP
{
    public class Employee
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityPrivilege SecurityLevel { get; set; }//q4 4.	Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }//q3 3.	We need to restrict the Gender field to be only M or F [Male or Female] 
        #endregion

        #region Constructor
        public Employee(int id, string name, SecurityPrivilege securityLevel, decimal salary, DateTime hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = Gender;
        }

        #endregion

        #region methods
        public override string ToString()//q5
        {
            return String.Format(
                "ID: {0}, Name: {1}, Security Level: {2}, Salary: {3}, Hire Date: {4}, Gender: {5}",
                ID,
                Name,
                SecurityLevel,
                Salary.ToString("C", CultureInfo.CurrentCulture),
                HireDate,
                Gender
            );
        }
        #endregion
    }
}
