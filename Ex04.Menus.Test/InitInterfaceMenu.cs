using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class InitInterfaceMenu
    {
        private MainMenu m_MainMenu;

        internal MainMenu MainMenu
        {
            get
            {
                return m_MainMenu;
            }
        }

        internal InitInterfaceMenu(string i_NameOfMainMenu)
        {
            m_MainMenu = new MainMenu(i_NameOfMainMenu);
            
            ParentMenuItem versionAndSpaces = new ParentMenuItem("Version and Spcaes", m_MainMenu);
            ParentMenuItem dateOrTime = new ParentMenuItem("Show Date/Time", m_MainMenu);
            
            MenuItemFinalAction showVersion = new MenuItemFinalAction("Show Version", new VersionAndSpacesMethods.Version());
            MenuItemFinalAction countSpaces = new MenuItemFinalAction("Count Spaces", new VersionAndSpacesMethods.CountSpaces());
            
            MenuItemFinalAction showDate = new MenuItemFinalAction("Show Date", new ShowDateOrTimeMethods.ShowDate());
            MenuItemFinalAction showTime = new MenuItemFinalAction("Show Time", new ShowDateOrTimeMethods.ShowTime());

            versionAndSpaces.ChildMenu.AddToMenuItemList(showVersion);
            versionAndSpaces.ChildMenu.AddToMenuItemList(countSpaces);

            dateOrTime.ChildMenu.AddToMenuItemList(showDate);
            dateOrTime.ChildMenu.AddToMenuItemList(showTime);

            m_MainMenu.AddToMenuItemList(versionAndSpaces);
            m_MainMenu.AddToMenuItemList(dateOrTime);
        }
    }
}
