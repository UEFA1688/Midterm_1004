using System;

class AdminMenu {

    private User user;

    public void ShowAdmin(User user) {
        SetupUser(user);
        PrintHeaderScreen();
        PrintListMenuScreen();
        InputSelectedMenuFromKeyboard();
    }

    private void PrintHeaderScreen() {
        Console.Clear();
        Console.WriteLine("Collegian Management");
        Console.WriteLine("-------------------");
        Console.WriteLine("");
    }

    private void PrintListMenuScreen() {
        Console.WriteLine("1. Register Idia camp 2022");
        Console.WriteLine("2. Show all Collegians participating in the program.");
        Console.WriteLine("3. Show all students participating in the program.");
        Console.WriteLine("4. Show all teachers participating in the project.");
        Console.WriteLine("5. Log out");
    }



    private void InputSelectedMenuFromKeyboard() {
        Console.Write("Input Menu: ");
        int input = int.Parse(Console.ReadLine());
        int Register = 1;
        int Collegians = 2;
        int students = 3;
        int teachers = 4;
        int LogOut = 5;

        if (input == Register) {
            ShowRegisterScreen();
        }
        if (input == Collegians) {
            
        }
        if (input == students) {
           
        }
        if (input == teachers) {
            ShowRegisterScreen();
        }
        if (input == LogOut) {
            return;
        }
    }
        private void ShowRegisterScreen() {
        Register controller = new Register();
        controller.InputNewUserFromKeyboard();
    }
        private bool ShowHsStudentScreen(List<User> listUsers) {

            string Name = "";
            string FristName = "";
            string LastName = ""; 

            foreach(User user in listUsers) {
            if (user is HsStudent) {
             Name = user.GetNamePrefix;
             FristName = user.GetFristName;
             LastName = user.GetLastName;       
              }
            
            }
            PrintListScreen(Name,FristName,LastName);
            return true;
        }
    
    private void  PrintListScreen (string Name , string FristName , string LastName) {
        Console.WriteLine($"{Name} ");
        Console.WriteLine($"{FristName} ");
        Console.WriteLine($"{LastName}");
        Console.WriteLine("");
        Console.WriteLine("Please input 0 for BackToMainMenu");
        string input = Console.ReadLine();
        if (input == "0"){
                Console.Clear();
               
        }
    }
    private void SetupUser(User user) {
        this.user = (User)user;
    }
}