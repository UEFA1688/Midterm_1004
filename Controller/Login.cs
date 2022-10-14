using System.Collections.Generic;
using System;

class Login{

    public void ShowLoginScreen() {
        Console.Clear();
        PrintHeaderLoginScreen();
    }

    public bool InputLoginFromKeyboard(List<User> listUsers) {
        string Email = InputEmailFromKeyboard();
        if (Email == "exit"){
            Console.WriteLine("Invalid email. Please try again");
            Console.Clear();
        return false;
        }
        string Password = InputPasswordFromKeyboard();

        foreach (User user in listUsers) {
            Console.WriteLine(user.GetEmail);
            if (user.GetEmail == Email && user.GetPassword == Password) {
                 ShowAdminMenu(user);

                return true;
            }
            else{
                 Console.WriteLine("Incorrect email or password. Please try again.");
            }
         return true;

        }
        return false;
    }

    private void ShowAdminMenu(User user) {
        AdminMenu controller = new AdminMenu();
        controller.ShowAdmin(user);
    }


    public string InputEmailFromKeyboard() {
        Console.Write("Input Email: ");

        return Console.ReadLine();
    }

    public string InputPasswordFromKeyboard() {
        Console.Write("Input Password: ");

        return Console.ReadLine();
    }

    private void PrintHeaderLoginScreen() {
        Console.WriteLine("Login Screen");
        Console.WriteLine("------------"); 
    }

}