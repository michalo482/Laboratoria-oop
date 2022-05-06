using Microsoft.VisualBasic;
using System;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie.");

            string imie = Interaction.InputBox("Podaj imie", "Okienko imie");
            if (imie == "")
            {
                Console.WriteLine("Koniec");
                System.Environment.Exit(1);
            }
            Console.WriteLine("podano imie " + imie);

            string nazwisko = Interaction.InputBox("Podaj nazwisko", "Okienko nazwisko");
            if (nazwisko == "")
            {
                Console.WriteLine("Koniec");
                System.Environment.Exit(1);
            }
            Console.WriteLine("podano nazwisko " + nazwisko);

            Interaction.MsgBox("Witaj " + imie + " " + nazwisko);
            Interaction.MsgBox(string.Format("Witaj {0} {1}. Czy Pan {0} zeczywiscie nazywa sie {1}?", imie, nazwisko));

            string wiekTemp = Interaction.InputBox("Podaj wiek", "Okienko wiek");
            int wiek;
            if (wiekTemp == "")
            {
                Console.WriteLine("Koniec");
                System.Environment.Exit(1);
            }


            wiek = Convert.ToInt32(wiekTemp);


            if (wiek < 67)
            {
                Interaction.MsgBox("do emerytury zostalo ci " + (67 - wiek) + " lat", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
            }
            else
            {
                Interaction.MsgBox("Jestes na emeryturze", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Okienko emerytura");
            }
        }
    }
}
