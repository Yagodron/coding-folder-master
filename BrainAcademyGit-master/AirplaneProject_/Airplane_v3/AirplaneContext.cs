using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Airplane_v4
{
    class AirplaneContext : DbContext
    {
        public AirplaneContext()
            : base()
        {

        }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightClass> FlightClasses { get; set; }
    }
}
