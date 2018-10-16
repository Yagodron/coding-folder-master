using System;
using System.Data.Entity;

namespace PracticeMVC.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime Time { get; set; }
        public decimal Price { get; set; }
    }

    public class FlightDBContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
    }
}