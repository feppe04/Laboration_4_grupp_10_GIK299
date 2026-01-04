using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public struct Hair
    {
        public string Color  { get; set; }
        public string Length { get; set; }

        public Hair(string color, string length)
        {
            Color = color;
            Length = length;
        }
    }
}
