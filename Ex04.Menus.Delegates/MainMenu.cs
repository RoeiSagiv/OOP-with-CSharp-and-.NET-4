using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : Menu
    {
        public MainMenu(string i_NameOfMainMenu) : base(i_NameOfMainMenu, "Exit") 
        {   
        }

        public override void ReturnToPreviousMenu()
        {
            Console.WriteLine("Notice! You select to exit the menu. Goodbye and have a nice day :)");
        }
    }
}
