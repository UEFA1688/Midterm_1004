
namespace MIDTERM
{

class Program {

     static MainMenu mainMenu;

    static void Main(string[] args)
    {

            PreMainMenu();
            ShowMainMenuScreen();
        }

        static void PreMainMenu() {
            Program.mainMenu = new MainMenu();
        }

        static void ShowMainMenuScreen() {
            Program.mainMenu.ShowMainMenuScreen();
        }
    }
}