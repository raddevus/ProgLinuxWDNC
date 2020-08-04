using System;

namespace SuperConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            // string firstName = "Ted";
            // string lastName;
            // lastName = "Lastonian";
            // Console.WriteLine($"{firstName} {lastName} was here.");

            Console.WriteLine($"There are {args.Length} args.");
            if (args.Length > 0){
                Console.WriteLine($"The first parameter is : {args[0]}");
            }
            foreach (string cmd in args){
                Console.WriteLine($"cmd: {cmd}");
            }
            
            // float unitPrice = 2.04f;
            // int numberUnitsAvailable = 282;
            // float totalCost = unitPrice * numberUnitsAvailable;
            // Console.WriteLine($"Total cost is {totalCost}");

            // int [] studentsPerClassCount = {30,23,17,31,34,12,58,32};
            // float [] distances = {3.23f, 17.389f, 38.37f, 1.23f};
            // string [] lastNames = {"smith", "jones", "jackson"};
            // Console.WriteLine(distances[0]);
            // foreach (float f in distances){
            //     Console.WriteLine($"value : {f}");
            // }
            // foreach (string LName in lastNames){
            //     Console.WriteLine(LName);
            // }
        }
    }
}
