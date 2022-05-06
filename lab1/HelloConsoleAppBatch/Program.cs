using System;

namespace HelloConsoleAppBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powintanie.");

            string imie;
            string nazwisko;
            int wiek;

            if (args.Length == 0)
            {
                Console.Write("Podaj swoje imie: ");
                imie = Console.ReadLine();

                Console.Write("Podaj swoje nazwisko: ");
                nazwisko = Console.ReadLine();

                Console.WriteLine("Witaj " + imie + " " + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiscie nazywa sie {1}?", imie, nazwisko);

                Console.WriteLine("Podaj swoj wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Bledne dane!");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine("do emerytury zostalo ci {0} lat", 67 - wiek);
                }
                else
                {
                    Console.WriteLine("jestes emerytem");
                }
            }
            else if (args.Length == 1)
            {
                imie = args[0];

                Console.Write("Podaj swoje nazwisko: ");
                nazwisko = Console.ReadLine();

                Console.WriteLine("Witaj " + imie + " " + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiscie nazywa sie {1}?", imie, nazwisko);

                Console.WriteLine("Podaj swoj wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Bledne dane!");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine("do emerytury zostalo ci {0} lat", 67 - wiek);
                }
                else
                {
                    Console.WriteLine("jestes emerytem");
                }
            }
            else if (args.Length == 2)
            {

                imie = args[0];

                nazwisko = args[1];

                Console.WriteLine("Witaj " + imie + " " + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiscie nazywa sie {1}?", imie, nazwisko);

                Console.WriteLine("Podaj swoj wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());

                if (wiek < 0)
                {
                    Console.WriteLine("Bledne dane!");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine("do emerytury zostalo ci {0} lat", 67 - wiek);
                }
                else
                {
                    Console.WriteLine("jestes emerytem");
                }
            }
            else if (args.Length == 3)
            {
                imie = args[0];
                nazwisko = args[1];
                wiek = Convert.ToInt32(args[2]);
                Console.WriteLine("Witaj " + imie + " " + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiscie nazywa sie {1}?", imie, nazwisko);
                if (wiek < 0)
                {
                    Console.WriteLine("Bledne dane!");
                }
                else if (wiek < 67)
                {
                    Console.WriteLine("do emerytury zostalo ci {0} lat", 67 - wiek);
                }
                else
                {
                    Console.WriteLine("jestes emerytem");
                }
            }
        }
    }
}
