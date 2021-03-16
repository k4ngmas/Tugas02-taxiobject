using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            coding1 taxi = new coding1();

            taxi.drivername = "Bobby";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            taxi.TaxiInfo();
            taxi.pickuppassenger();
            taxi.dropoffpassenger();

            Console.ReadKey();
        }
    }
}
