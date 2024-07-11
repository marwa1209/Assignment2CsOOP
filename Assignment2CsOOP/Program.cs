namespace Assignment2CsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            Person[] persons = new Person[3];
            persons[0] = new Person("Alice", 30);
            persons[1] = new Person("Bob", 25);
            persons[2] = new Person("Charlie", 35);

            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            #endregion

            #region q2
            Person[] persons2 = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Please enter a valid integer for age.");
                    Console.Write("Age: ");
                }

                persons[i] = new Person(name, age);
            }

            Person oldestPerson = persons[0];

            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldestPerson.Age)
                {
                    oldestPerson = persons[i];
                }
            }
            Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}."); 
            #endregion
        }
    }
}
