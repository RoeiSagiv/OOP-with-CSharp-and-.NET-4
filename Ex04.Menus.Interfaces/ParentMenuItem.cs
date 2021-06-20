namespace Ex04.Menus.Interfaces
{
    public class ParentMenuItem : MenuItem
    {
        private Menu m_ChildMenu;

        public ParentMenuItem(string i_NameOfParentMenuItem, Menu i_ParentMenu) : base(i_NameOfParentMenuItem)
        {
            m_ChildMenu = new ChildMenu(i_NameOfParentMenuItem, i_ParentMenu);
        }

        public Menu ChildMenu
        {
            get
            {
                return m_ChildMenu;
            }
        }

        internal override void OnClick()
        {
            m_ChildMenu.ShowAndOperateMenu();
        }
    }
}
