using System;
  
  class Faculty : Person
{
  public string Id {get; set;}
  public string Title {get; set;}
  public DateTime DateOfEmployment {get; set;}
  public string Employer {get; set;}
  public string YearlySalary {get; set;}
  public bool Tenured {get; set;}

  public Faculty() : base()
  {
    Title = "Instructor";
  }

  public Faculty(string fname, string lname) : base(fname, lname)
  {
    Title = "Instructor";
  }

  public void GrantTenure()
  {
   if (DateTime.Today.Year -5 >= DateOfEmployment.Year)
   {
    Tenured = true;
   }
  else
   {
    Tenured = false;
   }
  }

  public void Promote()
  {
    if ((DateTime.Today.Year -2 >= DateOfEmployment.Year)&&(Title=="Instructor"))
    {
      Title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor Rank");
    }
    else if ((DateTime.Today.Year -5 >= DateOfEmployment.Year)&&(Title =="Assistant Professor"))
    {
      Title = "Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor Rank");
    }
    else if (DateTime.Today.Year -10 >= DateOfEmployment.Year&&(Title =="Associate Professor"))
    {
      Title = " Professor";
      Console.WriteLine("Faculty promoted to Professor Rank");
    }
    else 
    {
      Console.WriteLine("No more promotion possible");
    }
  }

  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("I've worked as " + Title + " at " + Employer + " since " + DateOfEmployment);
  }


}