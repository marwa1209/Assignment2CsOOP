using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace demo
{
    internal class Employee
    {


        //#region Getter&Setter
        //#region Attributes
        ////public string? Name;
        ////public int Id;
        ////public decimal Salary;
        //private string? Name;
        //private int Id;
        //private decimal Salary;
        //#endregion

        //#region constructors
        //public Employee(string? name, int id, decimal salary)
        //{
        //    Name = name;
        //    Id = id;
        //    Salary = salary;
        //}

        //public override bool Equals(object? obj)
        //{
        //    return obj is Employee employee &&
        //           Name == employee.Name &&
        //           Id == employee.Id &&
        //           Salary == employee.Salary;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Name, Id, Salary);
        //}
        //#endregion

        //#region methods
        //public string? GetName()
        //{
        //    return Name;
        //}
        //public string? SetName()
        //{
        //    return Name;
        //}
        //public override string ToString()
        //{
        //    return $"Id = {Id}\nName={Name}\nSalary = {Salary}";
        //}
        //#endregion 
        //#endregion
        #region prop
        public string Name { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }
        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        #endregion
    }
}
