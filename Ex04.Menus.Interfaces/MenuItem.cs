namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_NameOfMenuItem;

        internal MenuItem(string i_NameOfMenuItem) 
        {
            this.m_NameOfMenuItem = i_NameOfMenuItem;
        }

        internal string NameOfMenuItem 
        {
            get
            {
                return m_NameOfMenuItem;
            }
        }

        internal abstract void OnClick();
    }
}
