using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilModelLib.model
{
    public class Bil
    {
        public String Model { get; set; }
        public String StelNummer { get; set; }
        public int Km { get; set; }
        public int Aar { get; set; }
        public String Maerke { get; set; }
        public String Braendsel { get; set; }


        // evt konstruktør + ToString

        public override string ToString()
        {
            return $"Model={Model}, StelNummer={StelNummer}, Km={Km}, Aar={Aar}, Maerke={Maerke}, Braendsel={Braendsel}";
        }
    }
}
