using System;
using Password_Generator.Functions;

namespace Password_Generator
{
    internal class Program
    {
        public static Logo logo = new Logo();
        static void Main(string[] args)
        {
            back:
            logo.displayLogo();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press num on keyboard to select\n");
            Console.WriteLine("[1] Generate Default Password");
            Console.WriteLine("[2] Generate Random E-mail");
            Console.WriteLine("[3] Credits");

            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.D1)
            {
                Console.Clear();
                logo.displayLogo();
                Console.Write("Password lenght: ");
                int lenght = Convert.ToInt32(Console.ReadLine());
                GenPassword genPass = new GenPassword();
                genPass.genPassword(lenght);
            }
            if (key.Key == ConsoleKey.D2)
            {
                Console.Clear();
                logo.displayLogo();
                Console.Write("Enter the mail domain (it is usually located after @): ");
                string domain = Console.ReadLine();
                GenEmail genEmail = new GenEmail();
                genEmail.genRndEmail(domain);
            }
            if (key.Key == ConsoleKey.D3)
            {
                Console.Clear();
                logo.displayCreditLogo();
                Console.WriteLine("Made with love by Fanya <3");
                Console.WriteLine("[Site] - https://fan9.ru");
                Console.WriteLine("[GitHub] - https://github.com/FanyaOff");
                Console.WriteLine("Press enter to back");
                Console.ReadKey();
                Console.Clear();
                goto back;
            }
        }
    }
}
