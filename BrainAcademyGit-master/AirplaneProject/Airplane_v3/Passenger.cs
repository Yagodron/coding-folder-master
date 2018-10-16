using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane_v4
{
    interface IPassenger
    {
        void Delete_passenger();
        void Add_passenger(Flight flight);
        void Print_passenger();
    }
    class Passenger : IPassenger
    {
        // passenger first name, second name, nationality, passport, date of birthday, sex, class
        private string name;
        private string surname;
        private string nationality;
        private string passport;
        private DateTime birthday;
        private string sex;
        private Flight passenger_plane;

        public void PrintHead()
        {
            Console.Write("{0,8:G}" + " ", "name");
            Console.Write("{0,8:G}" + " ", "surname");
            Console.Write("{0,8:G}" + " ", "nation");
            Console.Write("{0,8:G}" + " ", "passport");
            Console.Write("{0,8:G}" + " ", "sex");
            Console.Write("{0,8:G}" + " ", "birthday");
            Console.WriteLine();
        }

        public void Print_passenger()
        {
            Console.Write("{0,8:G}" + " ", this.Name);
            Console.Write("{0,8:G}" + " ", this.Surname);
            Console.Write("{0,8:G}" + " ", this.Nationality);
            Console.Write("{0,8:G}" + " ", this.Passport);
            Console.Write("{0,8:G}" + " ", this.Sex);
            Console.Write("{0,8:G}" + " ", this.Birthday.Date.ToString("g"));
            Console.WriteLine();
        }

        public void Delete_passenger()
        {
            this.name = String.Empty;
            this.surname = String.Empty;
            this.nationality = String.Empty;
            this.passport = String.Empty;
            this.birthday = DateTime.MinValue;
            this.sex = String.Empty;
            this.passenger_plane = null;
        }

        private string Sex_Choice()
        {
            string s = "";
            do
            {
                Console.WriteLine("1) male 2) female");
                ConsoleKeyInfo case_switch = Console.ReadKey();
                switch (case_switch.Key.ToString())
                {
                    case "D1":
                        Console.WriteLine("male");
                        s = "male";
                        return s;
                    case "D2":
                        Console.WriteLine("female");
                        s = "female";
                        return s;
                    default:
                        Console.WriteLine(case_switch.Key.ToString());
                        Console.WriteLine("wrong input");
                        break;
                }
            }
            while (true);
        }

        public void Add_passenger(Flight flight)
        {
            this.passenger_plane = flight;
            Console.WriteLine("input the first name");
            this.Name = Console.ReadLine();
            Console.WriteLine("input the second name");
            this.Surname = Console.ReadLine();
            Console.WriteLine("input the nationality");
            this.Nationality = Console.ReadLine();
            Console.WriteLine("input the passport");
            this.Passport = Console.ReadLine();
            Console.WriteLine("input the sex");
            this.Sex = Sex_Choice();
            this.birthday = DateAndTime();
            this.passenger_plane.FlightDeleteHandler += passenger_plane_FlightDeleteHandler;
        }

        void passenger_plane_FlightDeleteHandler(object sender, FlightEventArgs args)
        {
            Console.WriteLine("{0} was deleted",this.Name);
            this.Delete_passenger();
        }

        public DateTime DateAndTime()
        {
            do
            {
                try
                {
                    Console.WriteLine("input year of the birth");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("input month of the birth");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("input day of the birth");
                    int c = int.Parse(Console.ReadLine());
                    DateTime date1 = new DateTime(a, b, c, 0, 0, 0);
                    return date1.Date;
                }
                catch (FormatException)
                {
                    Console.WriteLine("this is not a date");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("this is a wrong date");
                }
            } while (true);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        //public string Class_
        //{
        //    get { return class_; }
        //    set { class_ = value; }
        //}
        //public string Flight_num
        //{
        //    get { return flight_num; }
        //    set { flight_num = value; }
        //}
    }
}
