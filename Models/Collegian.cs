using System.Collections.Generic;
using System;

class Collegian: User {
    private string studentID;
     public Collegian(string NamePrefix, 
     string FristName, 
     string LastName, 
     string Age, 
     string Allergy, 
     string Religion,
     string studentID,
     string Email,
     string Password)
     :base(NamePrefix, FristName, LastName, Age, Allergy, Religion, Email, Password){
        this.studentID = GetStudentID= studentID;
        this.Email  = Email;
        this.Password  = Password;
     }


     public string GetStudentID {get;}

}
