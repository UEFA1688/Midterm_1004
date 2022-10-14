using System.Threading.Tasks.Dataflow;
using System.Reflection.Metadata;
using System.Threading;
using System;

class Register{

    public void ShowRegisterScreen() {
        Console.Clear();
        PrintHeaderRegisterScreen();
    }


    public User InputNewUserFromKeyboard() {

        UserType userType = InputUserTypeFromKeyboard();
        string Prefix = RouteToPrefix(SelectedPrefix());
        string FristName = InputFristNameFromKeyboard();
        string LastName = InputLastNameFromKeyboard();
        string Age = InputAgeFromKeyboard();
        string Allergy = InputAllergyFromKeyboard();
        string Religion = RouteToReligion(SelectedReligion());


        if (userType == UserType.HsStudent){
            string Grade = RouteToGrade(SelectedGrade());
            return new HsStudent(Prefix, FristName, LastName, Age, Allergy, Religion, Grade, null, null);


        }else if (userType == UserType.Collegian){ 
            string StudentID = InputStudentIDFromKeyboard();
            Administrator administrator = CheckAdmin();
            
            if (administrator == Administrator.Yes){
                 string Email = InputEmailFromKeyboard();
                 string Password = InputPasswordFromKeyboard();
                 return new Collegian(Prefix, FristName, LastName, Age, Allergy, Religion, StudentID, Email, Password);
            }
            else if (administrator == Administrator.No){
                 return new Collegian(Prefix, FristName, LastName, Age, Allergy, Religion, StudentID, null, null);
            }

        }
        
        else if (userType == UserType.Teacher){ 
            string Rank = RouteToRank(SelectedRank());
            Administrator administrator = CheckAdmin();
            
            if (administrator == Administrator.Yes){
                string Email = InputEmailFromKeyboard();
                string Password = InputPasswordFromKeyboard();
                return new Collegian(Prefix, FristName, LastName, Age, Allergy, Religion, Rank, Email, Password);
            }
            else if (administrator == Administrator.No){
                 return new Teacher(Prefix, FristName, LastName, Age, Allergy, Religion, Rank, null, null);
            }
        }
      return new User(Prefix, FristName, LastName, Age, Allergy, Religion, null, null);
}

    private string InputFristNameFromKeyboard() {
        Console.Write("Input FristName: ");

        return Console.ReadLine();
    }

    private string InputLastNameFromKeyboard() {
        Console.Write("Input LastName: ");

        return Console.ReadLine();
    }

    private UserType InputUserTypeFromKeyboard() {
        Console.WriteLine("Input User Type 1 = Student:");
        Console.WriteLine("Input User Type 2 = Collegian: ");
        Console.WriteLine("Input User Type 3 = Teacher: ");

        int typeNumber = int.Parse(Console.ReadLine());

        UserType userType = (UserType)(typeNumber);

        return userType;
    }

    private Administrator CheckAdmin() {
        Console.WriteLine("");
        Console.WriteLine("Are you an administrator?");
        Console.WriteLine("Input 1 = Yes");
        Console.WriteLine("Input 2 = No ");

        int typeNumber = int.Parse(Console.ReadLine());

        Administrator administrator = (Administrator)(typeNumber);

        return administrator;
    }



    private string InputAgeFromKeyboard() {
        Console.Write("Age: ");

        return Console.ReadLine();
    }
    private string InputAllergyFromKeyboard() {
        Console.Write("Allergy: ");

        return Console.ReadLine();
    }


    private string InputStudentIDFromKeyboard() {
        Console.Write("Student ID: ");

        return Console.ReadLine();
    }

    private string InputEmailFromKeyboard() {
        Console.Write("Email : ");

        return Console.ReadLine();
    }
    private string InputPasswordFromKeyboard() {
        Console.Write("Password : ");

        return Console.ReadLine();
    }


    private void PrintHeaderRegisterScreen() {
        Console.WriteLine("Register for the event");
        Console.WriteLine("-------------------");
    }
    public Prefix SelectedPrefix() {
        Console.WriteLine("");
        Console.WriteLine("Select Prefix: ");
        Console.WriteLine("1: Mr.");
        Console.WriteLine("2: Ms.");
        Console.WriteLine("3: Miss.");

        return (Prefix)(int.Parse)(Console.ReadLine());        
    }

    private string RouteToPrefix(Prefix menu) {
        if (menu == Prefix.Mr) {
             return "Mr.";
        } else if (menu == Prefix.Ms) {
             return "Ms.";
           
        }else if (menu == Prefix.Miss) {
             return "Miss.";
           
        }
        return null;
    }
    public Religion SelectedReligion() {
        Console.WriteLine("");
        Console.WriteLine("Select Religion: ");
        Console.WriteLine("1: Buddhist.");
        Console.WriteLine("2: Christianity.");
        Console.WriteLine("3: Islam.");
        Console.WriteLine("4: Other.");

        return (Religion)(int.Parse)(Console.ReadLine());        
    }

    private string RouteToReligion(Religion menu) {
        if (menu == Religion.Buddhist) {
             return "Buddhist";
        }else if (menu == Religion.Christianity) {
             return "Christianity";    
        }else if (menu == Religion.Islam) {
             return "Islam"; 
        }else if (menu == Religion.Other) {
            Console.WriteLine("Other, please specify");
             return Console.ReadLine(); 
        }
        return null;
    }
    public Grade SelectedGrade() {
        Console.WriteLine("");
        Console.WriteLine("Select Grade: ");
        Console.WriteLine("1: Grade 10.");
        Console.WriteLine("2: Grade 11.");
        Console.WriteLine("3: Grade 12.");


        return (Grade)(int.Parse)(Console.ReadLine());        
    }

    private string RouteToGrade(Grade menu) {
        if (menu == Grade.ten) {
             return "Grade 10";
        }else if (menu == Grade.eleven) {
             return "Grade 11";    
        }else if (menu == Grade.twelve) {
             return "Grade 12"; 
        }
        return null;
    }
    public Rank SelectedRank() {
        Console.WriteLine("");
        Console.WriteLine("Select Religion: ");
        Console.WriteLine("1: Dean.");
        Console.WriteLine("2: Head of department.");
        Console.WriteLine("3: Full-time teacher.");


        return (Rank)(int.Parse)(Console.ReadLine());        
    }

    private string RouteToRank(Rank menu) {
        if (menu == Rank.Dean) {
             return "Dean";
        }else if (menu == Rank.Head) {
             return "Head of department";    
        }else if (menu == Rank.Full) {
             return "Full-time teacher"; 
        }
        return null;
    }

}