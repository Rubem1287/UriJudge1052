using System;

namespace Uri1052
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;

            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("February ");
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("April ");
                    break;

                case 5:
                    Console.WriteLine();
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine();
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine();
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine();
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine();
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine();
                    Console.WriteLine("October ");
                    break;

                case 11:
                    Console.WriteLine();
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine();
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Número Inválido");
                    break;
            }
        }
    }
}
