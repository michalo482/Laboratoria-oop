using System;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powintanie.");

            Console.Write("Podaj swoje imie: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("Podaj swoje nazwisko: ");
            string nazwisko;
            nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiscie nazywa sie {1}?", imie, nazwisko);

            Console.WriteLine("Podaj swoj wiek: ");
            int wiek;
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
    }
}
