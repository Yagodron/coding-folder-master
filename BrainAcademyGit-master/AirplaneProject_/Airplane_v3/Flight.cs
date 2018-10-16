using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane_v4
{
    interface IFlight
    {
        void Delete_flight();
        void Add_flight();
        void PrintFlight();
    }

    public class FlightEventArgs : EventArgs
    {
        public string flight_number;
    }

    class Flight : IFlight
    {
        public delegate void Flight_delete(object sender, FlightEventArgs args);

        public event Flight_delete FlightDeleteHandler;

        public int FlightID { get; set; }
        private string flight_num;
        private string city;
        private string airline;
        private string terminal;
        private string status;
        private int gate;
        private DateTime arr_date;
        private FlightClass f_class;
      
        public void Delete_flight()
        {
            FlightEventArgs args = new FlightEventArgs();
            args.flight_number = this.flight_num;
            //FlightDeleteHandler(this, args);

            using (var ctx = new AirplaneContext())
            {
                ctx.Entry(this).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
            this.Flight_num = string.Empty;
            this.City = string.Empty;
            this.Airline = string.Empty;
            this.Terminal = string.Empty;
            this.Status = string.Empty;
            this.Gate = 0;
            this.arr_date = DateTime.MinValue;



            
        }
 
        private string Status_Choice()
        {
            string s = "";
            do
            {
                Console.WriteLine("1)check-in 2)gate closed 3)arrived 4)departed at \n5)unknown 6)canceled 7)expected at 8)delayed 9)in flight");
                ConsoleKeyInfo case_switch = Console.ReadKey();
                switch (case_switch.Key.ToString())
                {
                    case "D1":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("check-in");
                        s = "check-in";
                        return s;
                    case "D2":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("gate closed");
                        s = "gate closed";
                        return s;
                    case "D3":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("arrived");
                        s = "arrived";
                        return s;
                    case "D4":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("departed at");
                        s = "departed at";
                        return s;
                    case "D5":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("unknown");
                        s = "unknown";
                        return s;
                    case "D6":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("canceled");
                        s = "canceled";
                        return s;
                    case "D7":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("expected at");
                        s = "expected at";
                        return s;
                    case "D8":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("delayed");
                        s = "delayed";
                        return s;
                    case "D9":
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("in flight");
                        s = "in flight";
                        return s;
                    default:
                        Console.WriteLine(case_switch.Key.ToString());
                        Console.WriteLine("wrong input");
                        break;
                }
            }
            while (true);
            
        }

        public void Add_flight()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            do
            {
                Console.WriteLine("input the flight number, can not be empty");
                this.Flight_num = Console.ReadLine();
            } while (this.Flight_num == null);
            Console.WriteLine("input the city/port");
            this.City = Console.ReadLine();
            Console.WriteLine("input the airline");
            this.Airline = Console.ReadLine();
            Console.WriteLine("input the terminal");
            this.Terminal = Console.ReadLine();
            Console.WriteLine("choose the status");
            this.Status = Status_Choice();
            Console.ReadKey();
            int i = 0;
            do
            {
                Console.WriteLine("input the gate");
                string gate = Console.ReadLine();
                bool s = int.TryParse(gate, out i);
                this.Gate = i;
                if (i == 0)
                    Console.WriteLine("gate must be a number");
            }
            while (i == 0);
            this.arr_date = DateAndTime();
            using (var ctx = new AirplaneContext())
            {
                ctx.Flights.Add(this);
                ctx.SaveChanges();
            }

        }

        public DateTime DateAndTime()
        {
            do
            {
                try
                {
                    Console.WriteLine("input year of the flight");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("input month of the flight");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("input day of the flight");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("input hour of the flight");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine("input minute of the flight");
                    int e = int.Parse(Console.ReadLine());
                    DateTime date1 = new DateTime(a, b, c, d, e, 0);
                    return date1;
                }
                catch (FormatException)
                    {
                        Console.WriteLine("this is not a date");
                    }
                catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("this is a wrong date");
                    }
            }
            while (true);
            
        }

        public void PrintHead()
        {
            Console.Write("{0,8:G}" + " ", "flght num");
            Console.Write("{0,8:G}" + " ", "city");
            Console.Write("{0,8:G}" + " ", "airline");
            Console.Write("{0,8:G}" + " ", "terminal");
            Console.Write("{0,8:G}" + " ", "status");
            Console.Write("{0,8:G}" + " ", "gate");
            Console.Write("{0,8:G}" + " ", "arr date");
            Console.WriteLine();
        }

        public void PrintFlight()
        {
            Console.Write("{0,8:G}" + " ", this.Flight_num);
            Console.Write("{0,8:G}" + " ", this.City);
            Console.Write("{0,8:G}" + " ", this.Airline);
            Console.Write("{0,8:G}" + " ", this.Terminal);
            Console.Write("{0,8:G}" + " ", this.Status);
            Console.Write("{0,8:G}" + " ", this.Gate);
            Console.Write("{0,8:G}" + " ", this.arr_date);
            Console.WriteLine();
        }

        public string Flight_num
        {
            get { return this.flight_num; }
            set { this.flight_num = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Airline
        {
            get { return this.airline; }
            set { this.airline = value; }
        }
        public string Terminal
        {
            get { return this.terminal; }
            set { this.terminal = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public int Gate
        {
            get { return this.gate; }
            set { this.gate = value; }
        }

        public FlightClass Flight_Class
        {
            get { return this.f_class; }
            set { this.f_class = value; }
        }
    }
}
