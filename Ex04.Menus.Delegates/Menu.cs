using System;
using System.Collections.Generic;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    public abstract class Menu
    {
        internal readonly List<MenuItem> m_ItemsOfMenu;
        internal string m_NameOfMenu;
        private string m_ReturnToPreviousMenu;

        public Menu(string i_NameOfMenu, string i_ReturnToPreviousMenu)
        {
            m_ItemsOfMenu = new List<MenuItem>();
            m_NameOfMenu = i_NameOfMenu;
            m_ReturnToPreviousMenu = i_ReturnToPreviousMenu;
        }

        public abstract void ReturnToPreviousMenu();

        public int GetChoiceOptionFromUser()
        {
            int optionChoiceOfUser = 0;
            string optionChoiceFromfUser = Console.ReadLine();
            bool goodInput = int.TryParse(optionChoiceFromfUser, out optionChoiceOfUser);
            while(!goodInput || optionChoiceOfUser > m_ItemsOfMenu.Count || optionChoiceOfUser < 0 )
            {
                if(!goodInput)
                {
                    string parsingErrorMsg = string.Format("Notice! something went wrong while parsing your input: {0}, Please try agian!", optionChoiceFromfUser);
                    Console.WriteLine(parsingErrorMsg);
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    string outOfRangeErrorMsg = string.Format("Notice! your input is out of the range: 0 - {0}", m_ItemsOfMenu.Count);
                    Console.WriteLine(outOfRangeErrorMsg);
                    Thread.Sleep(2500);
                    Console.Clear();
                }
            }

            return optionChoiceOfUser;
        }

        public void OperateUserChoice()
        {
            int choiceOptionFromUser = GetChoiceOptionFromUser();
            if(choiceOptionFromUser == 0)
            {
                Console.Clear();
                ReturnToPreviousMenu();
            }
            else
            {
                Console.Clear();
                m_ItemsOfMenu[choiceOptionFromUser - 1].OnClick();
                Thread.Sleep(2500);
                Console.Clear();
            }
        }

        public void AddToMenuItemList(MenuItem i_ItemToAdd)
        {
            m_ItemsOfMenu.Add(i_ItemToAdd);
            if(i_ItemToAdd is MenuItemFinalAction)
            {
                (i_ItemToAdd as MenuItemFinalAction).ParentMenu = this;
            }
        }

        public void RemoveFromMenuItemList(MenuItem i_ItemToRemove)
        {
            m_ItemsOfMenu.Remove(i_ItemToRemove);
        }

        public void ShowAndOperateMenu() 
        {
            int indexOfMenuItem = 1;
            drawMenuTitle();
            drawReturnToPreviousMenu();
            foreach (MenuItem menuItem in m_ItemsOfMenu)
            {
                drawMenuItem(indexOfMenuItem, menuItem);
                indexOfMenuItem++;
            }

            Console.WriteLine("Choose the option you want:");
            OperateUserChoice();
        }

        private void drawMenuTitle()
        {
            string Menutitle = string.Format("Name of the menu: {0}", m_NameOfMenu);
            Console.WriteLine(Menutitle);
            Console.WriteLine("=================\n");
        }

        private void drawReturnToPreviousMenu()
        {
            string menuItemStr = string.Format("---[0]--- {0}{1}", m_ReturnToPreviousMenu, Environment.NewLine);
            Console.WriteLine(menuItemStr);
        }

        private void drawMenuItem(int i_IndexOfMenuItem, MenuItem i_MenuItem)
        {
            string menuItemStr = string.Format("---[{0}]--- {1}{2}", i_IndexOfMenuItem, i_MenuItem.NameOfMenuItem, Environment.NewLine);
            Console.WriteLine(menuItemStr);
        }
    }
}
