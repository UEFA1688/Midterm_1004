class Teacher: User {
    private string Rank;
     public Teacher(string NamePrefix, 
     string FristName, 
     string LastName, 
     string Age, 
     string Allergy, 
     string Religion,
     string Rank,
     string Email,
     string Password)
     :base(NamePrefix, FristName, LastName, Age, Allergy, Religion, Email, Password){
        this.Rank = GetRank = Rank;
     }


     public string GetRank {get;}
}
