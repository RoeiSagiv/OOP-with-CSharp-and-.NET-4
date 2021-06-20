using System;
using System.Collections.Generic;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    public class MenuItemFinalAction : MenuItem
    {
        private readonly List<IClickReporter> m_ReportIfClicked;
        private Menu m_ParentMenu;

        public MenuItemFinalAction(string i_NameOfMenuItem, IClickReporter i_ClickReporter) : base(i_NameOfMenuItem) 
        {
            m_ReportIfClicked = new List<IClickReporter>();
            m_ReportIfClicked.Add(i_ClickReporter);
        }

        internal Menu ParentMenu
        {
            set
            {
                m_ParentMenu = value;
            }
        }

        internal void AddToReporterIfClickedList(IClickReporter i_ClickReporter)
        {
            m_ReportIfClicked.Add(i_ClickReporter);
        }

        internal void RmoveFromReporterIfClickedList(IClickReporter i_ClickReporter)
        {
            m_ReportIfClicked.Remove(i_ClickReporter);
        }

        internal override void OnClick()
        {
            Console.Clear();
            foreach(IClickReporter reporterClicked in m_ReportIfClicked)
            {
                reporterClicked.ReportActionClicked();
            }

            Thread.Sleep(2500);
            Console.Clear();
            m_ParentMenu.ShowAndOperateMenu();
        }
    }
}
