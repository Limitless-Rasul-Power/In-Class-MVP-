using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Models
{
    public class Car
    {
        public int CarID { get; set; }

        public string Model { get; set; }
        public string Vendor { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
        public int Year { get; set; }


        public override string ToString()
        {
            return $"{Model} - {Vendor} - {Year}";
        }


    }
}
