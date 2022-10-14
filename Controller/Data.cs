using System;

class Data{

    private User user;
    private List<User> users;

    public void ShowDataScreen() {
        Console.Clear();
        PrintHeaderDataScreen();
    }

    private void PrintHeaderDataScreen() {
        Console.WriteLine("Show attendance statistics");
        Console.WriteLine("------------"); 
       ShowData(this.user);    
    }

        public void ShowData(User user) {
        SetupUser(user);
    }

    public bool CountOfUser (List<User> listUsers){
        int CountStudents = 0;
        int CountCollegians = 0;
        int CountTeachers = 0;

        int CountGrade10 = 0;
        int CountGrade11 = 0;
        int CountGrade12 = 0;


        foreach(User user in listUsers) {

        if (user is HsStudent) {
            CountStudents++;
        }
        else if (user is Collegian) {
            CountCollegians++;
        }
        else if (user is Teacher) {
            CountTeachers++;
        }
        else if (user is HsStudent_Grade10) {
            CountGrade10++;
        }
        else if (user is HsStudent_Grade11) {
            CountGrade11++;
        }
        else if (user is HsStudent_Grade12) {
            CountGrade12++;
        }

        
    }
    PrintListScreen(CountStudents, CountCollegians, CountTeachers, CountGrade10, CountGrade11, CountGrade12);
    return true;
}
    private void PrintListScreen(int Student, int Collegian, int Teacher, int Grade10, int Grade11, int Grade12) {
        Console.WriteLine($"Total number of registered Teachers : {Teacher}");
        Console.WriteLine($"Total number of registered Students : {Student}");
        Console.WriteLine($"Total number of registered Collegians : {Collegian}");
        Console.WriteLine($"Total number of registered Students Grade 10 : {Grade10}");
        Console.WriteLine($"Total number of registered Students Grade 11 : {Grade11}");
        Console.WriteLine($"Total number of registered Students Grade 12 : {Grade12}");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Please input 0 for BackToMainMenu");
        string input = Console.ReadLine();
        if (input == "0"){
                Console.Clear();
                return; 
        }


    }



    private void SetupUser(User user) {
        this.user = (User)user;
    }

}