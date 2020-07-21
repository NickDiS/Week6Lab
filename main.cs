using System;


class MainClass {
  public static void Main (string[] args) {
    
    /*Address addr1 = new Address();
    addr1.AddressLine1="1234 Main St";
    addr1.AddressLine2="Apt 102";
    addr1.City ="Cleveland";
    addr1.State ="OH";
    addr1.Zipcode ="44143";

    addr1.Display();
    
    Console.WriteLine("Testing Person");
    Person p1 = new Person();
    p1.FirstName ="John";
    p1.LastName ="Smith";
    p1.PermanentAddress.AddressLine1 ="1234 Main St";
    p1.PermanentAddress.AddressLine2 ="Apt 102";
    p1.PermanentAddress.City ="Cleveland";
    p1.PermanentAddress.State ="OH";
    p1.PermanentAddress.Zipcode ="44143";
    p1.DateOfBirth = Convert.ToDateTime("07/21/1994");
    p1.Intro();
    p1.IsBirthday();
    
    Console.WriteLine("Testing Student 1");
    Student s2 = new Student();
    s2.FirstName ="Kera";
    s2.LastName ="Kaiser";
    s2.DateOfBirth = Convert.ToDateTime("01/01/1989");
    s2.PermanentAddress.AddressLine1 ="999 Mallard St";
    s2.PermanentAddress.AddressLine2 ="Apt 102";
    s2.PermanentAddress.City ="Parma";
    s2.PermanentAddress.State ="OH";
    s2.PermanentAddress.Zipcode ="44143";
    s2.GPA =2.1;
    s2.School ="Cleveland State";
    s2.Intro();
    s2.IsBirthday();
    s2.SetAcademicStanding();
    Console.WriteLine(s2.AcademicStanding);

    
    Console.WriteLine("Testing Student 2");
    Student s1 = new Student("Andrew", "Peggman");
    s1.DateOfBirth = Convert.ToDateTime("01/01/1989");
    s1.PermanentAddress.AddressLine1 ="999 Mallard St";
    s1.PermanentAddress.AddressLine2 ="Apt 102";
    s1.PermanentAddress.City ="Parma";
    s1.PermanentAddress.State ="OH";
    s1.PermanentAddress.Zipcode ="44143";
    s1.GPA =2.75;
    s1.School ="Ohio State";
    s1.Intro();
    s1.IsBirthday();
    s1.SetAcademicStanding();
    Console.WriteLine(s1.AcademicStanding);
    */


    Console.WriteLine("Testing Faculty");
    Faculty f1 = new Faculty();
    f1.FirstName = "Tim";
    f1.LastName = "Burton";
    f1.PermanentAddress.AddressLine1 = "42060 Medow Lane";
    f1.PermanentAddress.AddressLine2 = "Memorial Township";
    f1.PermanentAddress.City = "Parma";
    f1.PermanentAddress.State = "OH";
    f1.PermanentAddress.Zipcode = "44133";
    f1.DateOfBirth = Convert.ToDateTime("05/19/1950");
    f1.Id = "1770";
    f1.Title = "Instructor";
    f1.DateOfEmployment = Convert.ToDateTime("06/06/1975");
    f1.Employer = "Tri-C";
    f1.Intro();
    f1.IsBirthday();
    f1.GrantTenure();
    f1.Promote();
    f1.Promote();
    f1.Promote();
    f1.Promote();
  }
}