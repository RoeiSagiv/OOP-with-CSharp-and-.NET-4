namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InitInterfaceMenu menuImplementedWithInterface = new InitInterfaceMenu("Menu Implemented With Interface");
            menuImplementedWithInterface.MainMenu.ShowAndOperateMenu();
            InitDelegateMenu menuImplementedWithDelegates = new InitDelegateMenu("Menu Implemented With Delegates");
            menuImplementedWithDelegates.MainMenu.ShowAndOperateMenu();
        }
    }
}
