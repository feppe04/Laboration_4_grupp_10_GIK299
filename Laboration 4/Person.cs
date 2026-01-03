using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string EyeColor { get; set; }
        public Gender Gender { get; set; }
        public Hair Hair { get; set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\n" +
                   $"Gender: {Gender}\n" +
                   $"Hair: {Hair.Color}, {Hair.Lenght}\n" +
                   $"Birthday: {BirthDay.ToShortDateString()}\n" +
                   $"Eyecolor: {EyeColor}\n";


        }
    }

}
