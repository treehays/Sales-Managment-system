using System;
using SMS.menu;
// Connections
namespace SMS
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.AllMainMenu();         

            // DateTime dv = DateTime.Parse("2022/11/29");
            // DateTime che = DateTime.UtcNow;
            // System.Console.WriteLine(DateTime.Now.Day);
            // System.Console.WriteLine(che);
            // // System.Console.WriteLine(che-dv.Day);
            // System.Console.WriteLine((dv-che).Days+1);

        }
    }
}

