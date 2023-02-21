using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("    Enter a number between 1 to 7 to show the days --> ");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Saturday();
                        break;
                    case 2:
                        Sunday();
                        break;
                    case 3:
                        Monday();
                        break;
                    case 4:
                        Tuesday();
                        break;
                    case 5:
                        Wednesday();
                        break;
                    case 6:
                        Thursday();
                        break;
                    case 7:
                        Friday();
                        break;
                    default:
                        Console.WriteLine("    Enter a number between 1 to 7");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("    Enter a valid number");
                throw;
            }
            static void Saturday()
            {
                Console.WriteLine("    Saturday is the first day of the week");
            }
            static void Sunday()
            {
                Console.WriteLine("    Sunday is the second day of the week");
            }
            static void Monday()
            {
                Console.WriteLine("    Monday is the third day of the week");
            }
            static void Tuesday()
            {
                Console.WriteLine("    Tuesday is the fourth day of the week");
            }
            static void Wednesday()
            {
                Console.WriteLine("    Wednesday is the fifth day of the week");
            }
            static void Thursday()
            {
                Console.WriteLine("    Thursday is the sixth day of the week");
            }
            static void Friday()
            {
                Console.WriteLine("    Friday is the seventh day of the week");
            }
        }
    }
}