using System;

namespace Password_Generator.Functions
{
    internal class Logo
    {
        public void displayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"  _____                                    _    _____                           _             ");
            Console.WriteLine(@" |  __ \                                  | |  / ____|                         | |           ");
            Console.WriteLine(@" | |__) |_ _ ___ _____      _____  _ __ __| | | |  __  ___ _ __   ___ _ __ __ _| |_ ___  _ __");
            Console.WriteLine(@" |  ___/ _` / __/ __\ \ /\ / / _ \| '__/ _` | | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__|");
            Console.WriteLine(@" | |  | (_| \__ \__ \\ V  V / (_) | | | (_| | | |__| |  __/ | | |  __/ | | (_| | || (_) | | ");
            Console.WriteLine(@" |_|   \__,_|___/___/ \_/\_/ \___/|_|  \__,_|  \_____|\___|_| |_|\___|_|  \__,_|\__\___/|_|");
            Console.WriteLine(@"                                                                                             ");
            Console.WriteLine(@"                                                                                             ");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public void displayCreditLogo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"   _____                 _  _  _        ");
            Console.WriteLine(@"  / ____|               | |(_)| |      ");
            Console.WriteLine(@" | |      _ __  ___   __| | _ | |_  ___ ");
            Console.WriteLine(@" | |     | '__|/ _ \ / _` || || __|/ __|");
            Console.WriteLine(@" | |____ | |  |  __/| (_| || || |_ \__ \");
            Console.WriteLine(@"  \_____||_|   \___| \__,_||_| \__||___/");
            Console.WriteLine(@"                                        ");
            Console.WriteLine(@"                                        ");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
