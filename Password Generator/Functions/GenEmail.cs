using System;
using System.Text;

namespace Password_Generator.Functions
{
    internal class GenEmail
    {
        public void genRndEmail(string mailDomain)
        {
        start:
            Console.Clear();
            Logo logo = new Logo();
            logo.displayLogo();
            string validMail = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            string validPass = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!@$%^&*";
            int lenght = 8;
            StringBuilder res = new StringBuilder();
            StringBuilder res2 = new StringBuilder();
            Random rnd = new Random();
            while (0 < lenght--)
            {
                res.Append(validMail[rnd.Next(validMail.Length)]);
                res2.Append(validPass[rnd.Next(validPass.Length)]);
            }
            Console.WriteLine($"{res}@{mailDomain}:{res2}\nEnter to regenerate mail");
            Console.ReadKey();
            goto start;
        }
    }
}
