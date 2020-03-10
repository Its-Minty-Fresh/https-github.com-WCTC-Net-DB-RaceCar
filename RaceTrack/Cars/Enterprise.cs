using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Enterprise : RaceCar
    {
        public Enterprise()
        {
            Name = "The Starship Enterprise";
            TopSpeed = 100;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engages warp drive!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} doesn't stop on a dime Jim!!");
            base.Brake();
        }
    }
}
