using System;

namespace Laboration_4
{ 
  class Program
  {
    static void Main(string[] args)
    {
        Person myPerson = new Person
        {
            FirstName = "Anna",
            LastName = "Andersson",
            Gender = Gender.Female,
            Hair = new Hair("Brown", "Long"),
            EyeColor = "Blue",
            BirthDay = new DateTime(1990, 5, 15),


        };
        Console.WriteLine(myPerson.ToString());
        Console.WriteLine("Press enter to exit...");
        Console.ReadLine();
    }
  } 
}