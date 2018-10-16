using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Airplane_v4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight + 3);

            var flight_class_list = new List<FlightClass>();
            var launcher = new Launch();
            Thread thread_speech = new Thread(launcher.Speech);
            Thread thread_launch = new Thread(launcher.PlaneDrawing);
            var c = flight_class_list.GetEnumerator();

            thread_speech.Start();
            thread_launch.Start();

            thread_launch.Join();

            Console.ForegroundColor = ConsoleColor.Gray;

            Flight[] arrival = new Flight[30];
            Flight[] depature = new Flight[30];
            Passenger[] people = new Passenger[30];
            for (int i = 0; i < 30; i++)
            {
                arrival[i] = new Flight();
                depature[i] = new Flight();
                people[i] = new Passenger();
            }

            Menu(ref arrival, ref depature, ref people,ref flight_class_list);
            Console.ReadKey();
        }

        static void Print(Flight[] A)
        {
            Console.Clear();
            A[0].PrintHead();
            for (int i = 0; i < 30; i++)
            {
                if (A[i].Flight_num != string.Empty && A[i].Flight_num != null) { A[i].PrintFlight(); }
            }
        }
        static void Print(Passenger[] A)
        {
            Console.Clear();
            A[0].PrintHead();
            for (int i = 0; i < 30; i++)
            {
                if (A[i].Surname != string.Empty && A[i].Surname != null) { A[i].Print_passenger(); }
            }
        }
        static void Search(Passenger[] P)
        {
            bool no_res = false;
            string a = " ";
            bool leave = true;
            do
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine("search by :\n1) name \n2) surname \n3) nationality \n4) passport \n5) back");
                int caseSwitch1 = int.Parse(Console.ReadLine());
                switch (caseSwitch1)
                {
                    case 1:
                        no_res = false;
                        Console.WriteLine("input the name of the passenger");
                        a = Console.ReadLine();
                        P[0].PrintHead();
                        for (int i = 0; i < 30; i++)
                        {
                            if (P[i].Name == a)
                            {
                                P[i].Print_passenger();
                                no_res = true;
                            }
                        }
                        if (!no_res)
                        {
                            Console.Clear();
                            Console.WriteLine("none found");
                        }
                        break;
                    case 2:
                        no_res = false;
                        Console.WriteLine("input the surname of the passenger");
                        a = Console.ReadLine();
                        P[0].PrintHead();
                        for (int i = 0; i < 30; i++)
                        {
                            if (P[i].Surname == a)
                            {
                                P[i].Print_passenger();
                                no_res = true;
                            }
                        }
                        if (!no_res)
                        {
                            Console.Clear();
                            Console.WriteLine("none found");
                        }
                        break;
                    case 3:
                        no_res = false;
                        Console.WriteLine("input the nationaity of the passenger");
                        a = Console.ReadLine();
                        P[0].PrintHead();
                        for (int i = 0; i < 30; i++)
                        {
                            if (P[i].Nationality == a)
                            {
                                P[i].Print_passenger();
                                no_res = true;
                            }
                        }
                        if (!no_res)
                        {
                            Console.Clear();
                            Console.WriteLine("none found");
                        }
                        break;
                    case 4:
                        no_res = false;
                        Console.WriteLine("input the passport of the passenger");
                        a = Console.ReadLine();
                        P[0].PrintHead();
                        for (int i = 0; i < 30; i++)
                        {
                            if (P[i].Passport == a)
                            {
                                P[i].Print_passenger();
                                no_res = true;
                            }
                        }
                        if (!no_res)
                        {
                            Console.Clear();
                            Console.WriteLine("none found");
                        }
                        break;
                    case 5:
                        leave = false;
                        break;

                }

            } while (leave == true);
        }
        static void Search(Flight[] F)
        {
            bool no_res = false;
            string a = " ";
            bool leave = true;
            do
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine("search by :\n1) flight number \n2) city \n3) back");
                ConsoleKeyInfo case_switch = Console.ReadKey();
                switch (case_switch.Key.ToString())
                {
                    case "D1":
                        no_res = false;
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("input the numbr of the flight");
                        a = Console.ReadLine();
                        F[0].PrintHead();
                        for (int i = 0; i < 30; i++)
                        {
                            if (F[i].Flight_num == a)
                            {
                                F[i].PrintFlight();
                                no_res = true;
                            }
                        }
                        if (!no_res)
                        {
                            Console.Clear();
                            Console.WriteLine("none found");
                        }
                        break;
                    case "D2":
                        no_res = false;
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.WriteLine("input the city");
                        a = Console.ReadLine();
                        F[0].PrintHead();
                        for (int i = 0; i < 30; i++)
                        {
                            if (F[i].City == a)
                            {
                                F[i].PrintFlight();
                                no_res = true;
                            }
                        }
                        if (!no_res)
                        {
                            Console.Clear();
                            Console.WriteLine("none found");
                        }
                        break;
                    case "D3":
                        leave = false;
                        break;

                }

            } while (leave);
        }

        static void Menu(ref Flight[] arrival, ref Flight[] depature, ref Passenger[] people,ref List<FlightClass> f_class_list)
        {
            Console.Clear();
            do
            {
                Console.WriteLine("work with: \n1) arrivals \n2) depatures \n3) flight classes(only adding) \n4) exit");
                ConsoleKeyInfo case_switch = Console.ReadKey();
                switch (case_switch.Key.ToString())
                {
                    case "D1":                                         //arrival
                        menu_flight(ref arrival, ref people, ref f_class_list);
                        break;
                    case "D2":
                        menu_flight(ref depature, ref people, ref f_class_list);
                        break;
                    case "D3":
                        Console.WriteLine("\ninput the name of the flight class");
                        string name_f_class = Console.ReadLine();
                        int cost = 0;
                        do
                        {
                            Console.WriteLine("input the cost");
                            string cost_string = Console.ReadLine();
                            bool check_number = int.TryParse(cost_string, out cost);
                            if (cost == 0)
                                Console.WriteLine("input a number");
                        }
                        while (cost == 0);
                        FlightClass f_class = new FlightClass(name_f_class, cost);
                        f_class_list.Add(f_class);
                        break;
                    case "D4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
            } while (true);
        }



        static void menu_flight(ref Flight[] flight, ref Passenger[] people, ref List<FlightClass> f_class_list)
        {
            Console.Clear();
            bool exit = true;
            string string_for_input;
            do
                        {
                            Console.WriteLine("1) add flight\n2) change flight \n3) delete flight \n4) search \n5) show flights \n6) set flight class \n7) view current flight class \n8) passengers \n9) back");
                            ConsoleKeyInfo case_switch1 = Console.ReadKey();
                            switch (case_switch1.Key.ToString())
                            {
                                case "D1":
                                    for (int i = 0; i < 30; i++)
                                    {
                                        if (flight[i].Flight_num == null || flight[i].Flight_num == string.Empty)
                                        {
                                            flight[i].Add_flight();
                                            break;
                                        }
                                    }
                                    Print(flight);
                                    break;
                                case "D2":
                                    Console.SetCursorPosition(0, Console.CursorTop);
                                    Console.WriteLine("input the numbr of the flight");
                                    string_for_input = Console.ReadLine();
                                    for (int i = 0; i < 30; i++)
                                    {
                                        if (flight[i].Flight_num == string_for_input)
                                        {
                                            flight[i].Add_flight();
                                            break;
                                        }
                                    }
                                    Print(flight);
                                    break;
                                case "D3":
                                    Console.SetCursorPosition(0, Console.CursorTop);
                                    Console.WriteLine("input the numbr of the flight");
                                    string_for_input = Console.ReadLine();
                                    for (int i = 0; i < 30; i++)
                                    {
                                        if (flight[i].Flight_num == string_for_input)
                                        {
                                            flight[i].Delete_flight();
                                            break;
                                        }
                                    }
                                    Print(flight);
                                    break;
                                case "D4":
                                    Search(flight);
                                    break;
                                case "D5":
                                    Print(flight);
                                    break;
                                case "D6":
                                    if (f_class_list.Count != 0)
                                    {
                                        Console.SetCursorPosition(0, Console.CursorTop);
                                        Console.WriteLine("flight classes:");
                                        Console.Write("{0,8:G}" + " ", "№");
                                        Console.Write("{0,8:G}" + " ", "name");
                                        Console.Write("{0,8:G}" + " ", "cost");
                                        Console.WriteLine();
                                        for (int i = 0; i < f_class_list.Count; i++)
                                        {
                                            Console.Write("{0,8:G}" + " ", i+1);
                                            Console.Write("{0,8:G}" + " ", f_class_list[i].Name);
                                            Console.Write("{0,8:G}" + " ", f_class_list[i].Cost);
                                            Console.WriteLine();
                                        }
                                        Console.WriteLine("input the name of the flight class");
                                        string searched_name = Console.ReadLine();
                                        FlightClass result = f_class_list.Find(
                                        delegate(FlightClass fc)
                                        {
                                            return fc.Name == searched_name;
                                        }
                                        );
                                        try
                                        {
                                            Console.WriteLine("{0} is successfully found and costs {1}", result.Name, result.Cost);
                                        }
                                        catch (NullReferenceException)
                                        {
                                            Console.WriteLine("{0} was not found", searched_name);
                                        }
                                        Print(flight);
                                        Console.WriteLine("input the numbr of the flight");
                                        string_for_input = Console.ReadLine();
                                        for (int i = 0; i < 30; i++)
                                        {
                                            if (flight[i].Flight_num == string_for_input)
                                            {
                                                flight[i].Flight_Class = result;
                                            }
                                        }
                                    }
                                    break;
                                case "D7":
                                    Console.WriteLine("input the numbr of the flight");
                                    string_for_input = Console.ReadLine();
                                    Flight temp_flight = new Flight();
                                    for (int i = 0; i < 30; i++)
                                    {
                                        if (flight[i].Flight_num == string_for_input && flight[i].Flight_Class != null)
                                        {
                                            Console.WriteLine("flight class: {0}", flight[i].Flight_Class.Name);
                                            Console.WriteLine("flight price: {0}", flight[i].Flight_Class.Cost);
                                        }
                                        if (flight[i].Flight_num == string_for_input)
                                        {
                                            temp_flight = flight[i];
                                        }
                                    }
                                    if (temp_flight.Flight_num == null)
                                    { }
                                    break;
                                case "D8":
                                    bool passenger_exit = true;
                                    bool wrong_flight = true;
                                    Print(flight);
                                    Console.WriteLine("input the numbr of the flight");
                                    var p_flight = new Flight();
                                    string_for_input = Console.ReadLine();
                                    for (int i = 0; i < 30; i++)
                                    {
                                        if (flight[i].Flight_num == string_for_input)
                                        {
                                            p_flight = flight[i];
                                            wrong_flight = false;
                                        }
                                    }
                                    if (wrong_flight)
                                    {
                                        Console.WriteLine("wrong number of the flight, try again");
                                        break;
                                    }
                                    do
                                    {
                                        Console.WriteLine("1) add passenger\n2) change passenger \n3) delete passenger \n4) search \n5) show passengers \n6) back");
                                        ConsoleKeyInfo case_switch_passenger = Console.ReadKey();
                                        switch (case_switch_passenger.Key.ToString())
                                        {
                                            case "D1":

                                                //Print(flight);
                                                Console.SetCursorPosition(0, Console.CursorTop);
                                                for (int i = 0; i < 30; i++)
                                                {
                                                    if (people[i].Surname == null)
                                                    {
                                                        people[i].Add_passenger(p_flight);
                                                        break;
                                                    }
                                                }
                                                Print(people);
                                                break;
                                            case "D2":
                                                Console.SetCursorPosition(0, Console.CursorTop);
                                                Console.WriteLine("input the surname of the passenger");
                                                string_for_input = Console.ReadLine();
                                                for (int i = 0; i < 30; i++)
                                                {
                                                    if (people[i].Surname == string_for_input)
                                                    {
                                                        people[i].Add_passenger(p_flight);
                                                        break;
                                                    }
                                                }
                                                Print(people);
                                                break;
                                            case "D3":
                                                Console.SetCursorPosition(0, Console.CursorTop);
                                                Console.WriteLine("input the surname of the passenger");
                                                string_for_input = Console.ReadLine();
                                                for (int i = 0; i < 30; i++)
                                                {
                                                    if (people[i].Surname == string_for_input)
                                                    {
                                                        people[i].Delete_passenger();
                                                        break;
                                                    }
                                                }
                                                Print(people);
                                                break;
                                            case "D4":
                                                Search(people);
                                                break;
                                            case "D5":
                                                Console.SetCursorPosition(0, Console.CursorTop);
                                                Print(people);
                                                break;
                                            case "D6":
                                                passenger_exit = false;
                                                break;
                                        }
                                    } while (passenger_exit);
                                    break;
                                case "D9":
                                    //Menu(ref flight, ref depature, ref people,ref f_class, ref num);
                                    exit = false;
                                    break;
                                default:
                                    Console.WriteLine("wrong input");
                                    break;
                            }
                        } while (exit);
        }

    }
}
