using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Witaj w grze 'Orzeł czy reszka'!");

        while (true)
        {
            Console.Write("Wybierz 'orzeł' lub 'reszka' (lub wpisz 'koniec', aby zakończyć grę): ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "koniec")
            {
                Console.WriteLine("Dziękujemy za grę! Do zobaczenia!");
                break;
            }

            if (userChoice != "orzeł" && userChoice != "reszka")
            {
                Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                continue;
            }

            string result = RzucMoneta();
            Console.WriteLine($"Wynik rzutu: {result}");

            if (userChoice == result)
            {
                Console.WriteLine("Gratulacje! Zgadłeś.");
            }
            else
            {
                Console.WriteLine("Niestety, nie zgadłeś. Spróbuj ponownie.");
            }
        }
    }

    static string RzucMoneta()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 2); // 0 lub 1
        return randomNumber == 0 ? "orzeł" : "reszka";
    }
}
