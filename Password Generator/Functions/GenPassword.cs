using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator.Functions
{
    internal class GenPassword
    {
        private string charsA; // Uppercase characters
        private string charsB; // Lowercase characters
        private string charsC; // Number characters
        private string charsD; // Special characters
        private string numbers;
        private int lenghtC; // copy of lenght
        public void genPassword(int lenght)
        {
            Console.Clear();
            Logo logo = new Logo();
            logo.displayLogo();
            char restart = 'y';
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1] Uppercase characters");
            Console.WriteLine("[2] Lowercase characters");
            Console.WriteLine("[3] Number characters");
            Console.WriteLine("[4] Special characters\n");
            Console.WriteLine("Select the types and write them separated by commas below");
            do
            {
                lenghtC = lenght;
                numbers = Console.ReadLine();
                string[] total = numbers.Split(',');
                foreach (var nums in total)
                {
                    if (nums.Contains("1"))
                        charsA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    if (nums.Contains("2"))
                        charsB = "abcdefghijklmnopqrstuvwxyz";
                    if (nums.Contains("3"))
                        charsC = "1234567890";
                    if (nums.Contains("4"))
                        charsD = "!@$%^&*";
                }
                string valid = charsA + charsB + charsC + charsD;
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < lenghtC--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }
                Console.Clear();
                logo.displayLogo();
                Console.WriteLine(res.ToString());
                Console.WriteLine("Press enter to regenerate mail");
            }
            while (restart == 'y');
        }
    }
}
