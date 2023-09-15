using System;
namespace Uppgift_2.__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv lönen för en av personerna...");
        int lön1= int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv lönen för den andra personen...");
            int lön2= int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv lönen för den tredje personen...");
            int lön3 = int.Parse(Console.ReadLine());
            int mid = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medellönen av de tre personerna är " + mid + " kr");
            Console.ReadKey();
        }
    }
}
