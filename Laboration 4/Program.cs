using System;
using System.Xml.Linq;

namespace Laboration_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapar lista för att lagra alla skapade Person-objekt
            List<Person> personList = new List<Person>();
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. List Persons");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddPerson(personList); // Anropar metod för att lägga till person
                        break;
                    case "2":
                        ListPersons(personList); // Anropar metod för att listan personer
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
            // Metoder
            static void AddPerson(List<Person> PersonList)
            {
                Console.WriteLine("\n--- Add a New Person ---");

                // Anbänder try-catch för att fånga felaktig inmatning
                try
                {
                    
                    Console.Write("First Name: ");
                    string fName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string lName = Console.ReadLine();

                    // Hantering av Enum-typ för kön
                    Console.Write("Gender (Male, Female , Nonbinary, Other): ");
                    string genderInput = Console.ReadLine();

                    //Gör om strängen till Enum-typ. "true" på slutet gör att den inte bryr sig om stor/liten bokstav.
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), genderInput, true);

                    Console.Write("Hair Color: ");
                    string hColor = Console.ReadLine();

                    Console.Write("Hair Length: ");
                    string hLength = Console.ReadLine();

                    // Skapar structen via konstuktorn i Hair.cs
                    Hair hair = new Hair(hColor, hLength);

                    Console.Write("Eye Color: ");
                    string eyeColor = Console.ReadLine();

                    Console.Write("Birthdate (yyyy-mm-dd): ");
                    DateTime bDay = DateTime.Parse(Console.ReadLine());

                    // Skapar nytt Person-objekt med insamlade data
                    Person newPerson = new Person
                    {
                        FirstName = fName,
                        LastName = lName,
                        Gender = gender,
                        Hair = hair,
                        EyeColor = eyeColor,
                        BirthDay = bDay
                    };

                    // Lägger till den nya personen i listan
                    PersonList.Add(newPerson);
                    Console.WriteLine("Person added successfully!");
                }
                catch (Exception)
                {
                    // Fångar alla typer av fel och visar ett generellt felmeddelande
                    Console.WriteLine("\nError: Invalid input. Person not added.");
                }
                Console.WriteLine("\nPress any key to return to the menu");
                Console.ReadKey();
            }



            static void ListPersons(List<Person> personList)
            {
                Console.WriteLine("\n--- List of Persons ---");

                if (personList.Count == 0)
                {
                    Console.WriteLine("No persons available.");
                }
                else
                {
                    // Intererar genom listan och skriver ut varje persons information
                    foreach (Person p in personList)
                    {
                        // Anropar ToString-metoden i Person-klassen för att formatera utskriften
                        Console.WriteLine(p.ToString());
                        Console.WriteLine("--------------------");
                    }
                }

                // Dessa rader ligger nu sist i metoden, så de körs oavsett om listan var tom eller inte
                Console.WriteLine("\nPress any key to return to the menu");
                Console.ReadKey();
            }
        }
    }
}




