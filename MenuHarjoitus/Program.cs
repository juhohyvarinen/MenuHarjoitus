using System;

namespace MenuHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Reverse string");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Valkoisen tilan poisto");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;

                case "2":
                    RemoveWhitespace();
                    return true;

                case "3":
                    PoistaValkoinenTila();
                    return true;

                case "4":
                    return false;

                default:
                    return true;
                    
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }
        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse string");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void PoistaValkoinenTila()
        {
            Console.Clear();
            Console.WriteLine("Poista valkoinen tila");

            DisplayResult(CaptureInput().Replace("Saatana",""));
        }

        private static void  DisplayResult(string message)
        {
            Console.WriteLine($"\r\nString that you modified is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
