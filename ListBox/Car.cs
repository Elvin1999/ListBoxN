using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox
{
    public class Car
    {
        public string Model { get; set; }
        public string Vendor { get; set; }
        public double Engine { get; set; }

        public override string ToString()
        {
            return $"{Model}-{Vendor}";
        }
    }
}
