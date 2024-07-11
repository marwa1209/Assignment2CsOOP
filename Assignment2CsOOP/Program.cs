namespace Assignment2CsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region q1
            //Person[] persons = new Person[3];
            //persons[0] = new Person("Alice", 30);
            //persons[1] = new Person("Bob", 25);
            //persons[2] = new Person("Charlie", 35);

            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            //#endregion
            //Console.WriteLine("*****************************");
            //#region q2
            //Person[] persons2 = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age;
            //    while (!int.TryParse(Console.ReadLine(), out age))
            //    {
            //        Console.WriteLine("Please enter a valid integer for age.");
            //        Console.Write("Age: ");
            //    }

            //    persons[i] = new Person(name, age);
            //}

            //Person oldestPerson = persons[0];

            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = persons[i];
            //    }
            //}
            //Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}.");
            //#endregion
            //Console.WriteLine("*****************************");
            ////part03
            //#region q1
            //Employee emp1 = new Employee(1, "Alice", 3, 60000m, new DateTime(2020, 5, 1), "Female");
            //Employee emp2 = new Employee(2, "Bob", 2, 55000m, new DateTime(2019, 3, 15), "Male");
            //Employee emp3 = new Employee(3, "Charlie", 1, 50000m, new DateTime(2018, 7, 30), "Male");

            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2);
            //Console.WriteLine(emp3);
            //#endregion
            Console.WriteLine("*****************************");
            #region q2
            HireDate hireDate1 = new HireDate(1, 5, 2020);
            HireDate hireDate2 = new HireDate(15, 3, 2019);
            HireDate hireDate3 = new HireDate(30, 7, 2018);

            Employee2 emp21 = new Employee2(1, "Alice", SecurityPrivilege.Developer, 60000m, hireDate1, Gender.Female);
            Employee2 emp22 = new Employee2(2, "Bob", SecurityPrivilege.Secretary, 55000m, hireDate2, Gender.Male);
            Employee2 emp23 = new Employee2(3, "Charlie", SecurityPrivilege.DBA, 50000m, hireDate3, Gender.Male);

            Console.WriteLine(emp21);
            Console.WriteLine(emp22);
            Console.WriteLine(emp23);
            #endregion
            Console.WriteLine("*****************************");
            #region q6
            HireDate hireDate21 = new HireDate(1, 5, 2020);
            HireDate hireDate22 = new HireDate(15, 3, 2019);
            HireDate hireDate23 = new HireDate(30, 7, 2018);

            // Create an array of Employees
            Employee2[] EmpArr = new Employee2[3];

            // Populate the array with specific roles
            EmpArr[0] = new Employee2(1, "DBA Employee", SecurityPrivilege.DBA, 60000m, hireDate1, Gender.Male);
            EmpArr[1] = new Employee2(2, "Guest Employee", SecurityPrivilege.Guest, 55000m, hireDate2, Gender.Female);
            EmpArr[2] = new Employee2(3, "Security Officer", SecurityPrivilege.FullPermissions, 70000m, hireDate3, Gender.Male);

            // Display details of each employee in the array
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
            #endregion
            Console.WriteLine("*****************************");

        }

    }
    }
