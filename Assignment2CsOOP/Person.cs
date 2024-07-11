using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2CsOOP
{
     public struct Person
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        } 
        #endregion
    }
}
