namespace Ex04.Menus.Interfaces
{
    public class ChildMenu : Menu
    {
        private Menu m_ParentMenu;

        public ChildMenu(string i_NameOfChildMenu, Menu i_ParentMenu) : base(i_NameOfChildMenu, "Back") 
        {
            m_ParentMenu = i_ParentMenu;
        }

        public override void ReturnToPreviousMenu()
        {
            m_ParentMenu.ShowAndOperateMenu();
        }
    }
}
