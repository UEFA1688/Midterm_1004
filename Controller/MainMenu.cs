using System;
using System.Collections.Generic;



class MainMenu {

    private Register register;
    private Data data;
    private Login login;
    private List<User> users;

    public void ShowMainMenuScreen() {
        PrepareListUsersWhenMainScreenIsLoaded();
        Console.Clear();
        ShowMenuScreenInformation();
    }

    private void ShowMenuScreenInformation() {
        PrintHeaderMenuScreen();
        PrintListMenuScreen();
        RouteToMenu(InputSelectedMenuFromKeyboard());
    }

    private void PrepareListUsersWhenMainScreenIsLoaded() {
        this.users = new List<User>();
    }

    public AuthenMenu InputSelectedMenuFromKeyboard() {
        Console.Write("Select Menu: ");

        return (AuthenMenu)(int.Parse)(Console.ReadLine());        
    }

    private void RouteToMenu(AuthenMenu menu) {

        if (menu == AuthenMenu.Register) {
            ShowRegisterScreen();
             this.users.Add(this.register.InputNewUserFromKeyboard());
            Console.Clear();
            ShowMenuScreenInformation();
        }

        else if (menu == AuthenMenu.Show) {
            ShowDataScreen();
            bool status = this.data.CountOfUser(users);
            Console.Clear();
            ShowUserScreenWhenAuthenInCorrect(status);

        }  

        else if (menu == AuthenMenu.Login) {
            ShowLoginScreen();
            bool status = this.login.InputLoginFromKeyboard(this.users);
            ShowMenuScreenWhenAuthenInCorrect(status);
        }  
      ShowMainMenuScreen();
    }
    
    private void ShowUserScreenWhenAuthenInCorrect(bool authenStatus) {
        if (authenStatus) {
            ShowMenuScreenInformation();
     }
    }
    private void ShowMenuScreenWhenAuthenInCorrect(bool authenStatus) {
        if (!authenStatus) {
            Console.WriteLine("Incorrect email or password. Please try again.");
            ShowMenuScreenInformation();
        }
    }

    private void ShowRegisterScreen() {
        this.register = new Register();
        this.register.ShowRegisterScreen();
    }

    private void ShowDataScreen() {
        this.data = new Data();
        this.data.ShowDataScreen();
    }

    private void ShowLoginScreen() {
        this.login = new Login();
        this.login.ShowLoginScreen();
    }

    private void PrintHeaderMenuScreen() {
        Console.WriteLine("Idia camp 2022");
        Console.WriteLine("--------------------------");
    }

    private void PrintListMenuScreen() {
        Console.WriteLine("1. Register Idia Camp 2022");
        Console.WriteLine("2. Show attendance statistics");
        Console.WriteLine("3. Login");

    }

}