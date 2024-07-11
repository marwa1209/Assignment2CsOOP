namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapculation
            Employee employee = new Employee("marwa", 22, 20000);
            Console.WriteLine(employee);
            #endregion
            #region Class
            Car C1;
            // Declare Reference From Type "Car"

            // Can Refer To An Object From Type "Car"
            // Or An Object from Class [Inheriting From Car]

            // CLR Will Allocate 4 Bytes For Reference "C1" At Stack
            // Zero bytes Allocated at heap

            C1 = new Car();
            // New >

            // 1. Allocate Required Bytes [16 Bytes] At Heap
            // 2. Initialize The Allocated bytes With Default value Of Datatype

            // 3. Call User defined Constructor [If Exists]
            // 4. Assign the Reference "C1" To Allocated Object At heap

            Console.WriteLine(C1);
            Car C2 = new Car(10, "BMW", 290);

            Console.WriteLine(C1);
            Console.WriteLine("-----------------");

            Car C3 = new Car(20, "BYD");
            Console.WriteLine(C3);

            Console.WriteLine("-----------------------");
            Car C4 = new Car(30);

            Console.WriteLine(C4);
            #endregion


        }
    }
}
