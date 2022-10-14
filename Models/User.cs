using System.Reflection.Emit;

class User {
    protected string NamePrefix;
    protected string FristName;
    protected string LastName;
    protected string Age;
    protected string Allergy;
    protected string Religion;
    protected string Email;
    protected string Password;

    public User( string NamePrefix, string FristName, string LastName, string Age ,string Allergy, string Religion, string Email, string Password) {
        this.NamePrefix = GetNamePrefix = NamePrefix;
        this.FristName = GetFristName = FristName;
        this.LastName = GetLastName = LastName;
        this.Age = GetAge = Age;
        this.Allergy = GetAllergy = Allergy;
        this.Religion = GetReligion = Religion; 
        this.Email = GetEmail = Email;
        this.Password = GetPassword = Password;


    }

   public string GetNamePrefix {get;}
   public string GetFristName {get;}
   public string GetLastName {get;}
   public string GetAge {get;}
   public string GetAllergy {get;}
   public string GetReligion {get;}
   public string GetEmail {get;}
   public string GetPassword {get;}


  }