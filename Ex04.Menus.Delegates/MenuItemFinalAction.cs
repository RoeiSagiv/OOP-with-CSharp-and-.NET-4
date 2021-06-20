using System;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    public delegate void ClickedEventHandler();

    public class MenuItemFinalAction : MenuItem
    {
        public event ClickedEventHandler m_ClickedOccured;

        private Menu m_ParentMenu;
        
        public MenuItemFinalAction(string i_NameOfMenuItem, ClickedEventHandler i_MethodAfterClicked) : base(i_NameOfMenuItem) 
        {
            m_ClickedOccured += i_MethodAfterClicked;
        }

        internal Menu ParentMenu
        {
            set
            {
                m_ParentMenu = value;
            }
        }

        internal void AddToReporterIfClickedList(ClickedEventHandler i_MethodAfterClicked)
        {
            m_ClickedOccured += i_MethodAfterClicked;
        }

        internal void RmoveFromReporterIfClickedList(ClickedEventHandler i_MethodAfterClicked)
        {
            m_ClickedOccured -= i_MethodAfterClicked;
        }

        internal override void OnClick()
        {
            Console.Clear();
            m_ClickedOccured.Invoke();
            Thread.Sleep(2500);
            Console.Clear();
            m_ParentMenu.ShowAndOperateMenu();
        }
    }
}
