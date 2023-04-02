using System;

namespace MyFirstProgram2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
        
            switch (n)
            {
                case 1:
                    Console.WriteLine("unu");
                    break;
                case 2:
                    Console.WriteLine("doi");
                    break;
                case 3:
                    Console.WriteLine("trei");
                    break;
                case 5:
                    Console.WriteLine("cinci");
                    break;
                case 8:
                    Console.WriteLine("opt");
                    break;
                default:
                    Console.WriteLine("Neidentificat");
                    break;



            }
        }

    }
}
