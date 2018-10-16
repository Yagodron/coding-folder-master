using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Hello_Class_lect;
using PersonClass;

namespace Hello_Operators_lect
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"Please,  type the number:
                    1.  My first class
                    2.  Constructors 
                    3.  Structure and class   
                    4.  Destructors   
                    5.  Arrays
                    6.  Indexers
                    7.  Properties
                    8.  Abstract classes
                    9.  Interfaces
                    ");
                        try
                        {
                            a = (int)uint.Parse(Console.ReadLine());
                            switch (a)
                            {
                                case 1:
                                    First_Class();
                                    Console.WriteLine("");
                                    break;
                                case 2:
                                    Constr_Class();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    Struct_Class();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    Destr_Class();
                                    Console.WriteLine("");
                                    break;
                                case 5:
                                    Arr_Class();
                                    Console.WriteLine("");
                                    break;
                                case 6:
                                    Ind_Class();
                                    Console.WriteLine("");
                                    break;
                                case 7:
                                    Prop_Class();
                                    Console.WriteLine("");
                                    break;
                                case 8:
                                    Abstr_Class();
                                    Console.WriteLine("");
                                    break;
                                case 9:
                                    Inter_Class();
                                    Console.WriteLine("");
                                    break; 
                                default:
                                    Console.WriteLine("Exit");
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error");
                        }
                        finally
                        {

                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Fin_write()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        #region Reg1
        static void First_Class()
        {
            Console.WriteLine("First class");
            First_class cl = new First_class();
            cl.write_hello();
            Fin_write();
        }
        #endregion

        #region Reg3
        static void Person_class()
        {
            Console.WriteLine("Person class");
            Person p = new Person("Andy", "Silverberg");
            Console.WriteLine(p.ToString());
            Object o = p;
            Console.WriteLine(o.ToString());

            Person p1 = new Person("John", "Martin");
            Person p2 =  new Person("Mary", "Stown");
            Console.WriteLine("First name = "+p1.FirstName + " , last name = "+p1.LastName);
            Console.WriteLine("First name = " + p2.FirstName + " , last name = " + p2.LastName);
            Fin_write();
        }

        #endregion

        #region Reg2
        static void Constr_Class()
        {
            Employee p = new Employee("Valery", "Lode", "first");
            Console.WriteLine("First name = " + p.FirstName + " , last name = " + p.LastName+ " rank = "+p.rank);
        }
        #endregion

        #region Reg3
        static void Struct_Class()
        {
            Console.WriteLine("The value types and reference types \n");
            Assign_ValueType();
            Assign_ReferenceType();
            ValueType_RefType();       
        }

        #region Structure
        struct Point_struct
        {
            //Structure
            public int x;
            public int y;

            //Constructor
            public Point_struct(int x_struct, int y_stuct)
            {
                x = x_struct;
                y = y_stuct;
            }

            //Addition  1 
            public void Inc_struct()
            {
                x++; y++;
            }

            //Subtraction 1
            public void Decr_struct()
            {
                x--; y--;
            }

            //Display 
            public void Disp_struct()
            {
                Console.WriteLine("Struct point  x = {0}, y = {1}", x, y); 
            }
        }
        #endregion

        #region Reference type
        //Class 
        class Point_class
        {
            //fields
            public int x;
            public int y;

            //Addition 1 
            public void Incr_class()
            {
                x++; y++;
            }

            //Subtraction
            public void Decr_class()
            {
                x--; y--;
            }

            //Display
            public void Disp_class()
            {
                Console.WriteLine("Class point  x = {0}, y = {1}", x, y);
            }

            //Constructor
            public Point_class(int x_class, int y_class)
            {
                x = x_class;
                y = y_class;
            }
        }
        #endregion

        #region Value type with reference type
        class About_figure
        {
            public string About_str;
            public About_figure(string abt)
            {
                About_str = abt;
            }
        }

        struct Box
        {
            //Box structure with a reference type member
            public About_figure box_abt;

            public int box_Top, box_Left, box_Bottom, box_rectRight;

            public Box(string abt, int top, int left, int bottom, int right)
            {
                box_abt = new About_figure(abt);
                box_Top = top; box_Bottom = bottom;
                box_Left = left; box_rectRight = right;
            }

            public void Disp_box()
            {
                Console.WriteLine("About = {0}, top = {1}, bottom = {2}, " +
                  "left = {3}, right = {4}",
                  box_abt.About_str, box_Top, box_Bottom, box_Left, box_rectRight);
            }
        }
        #endregion    

        #region Assignment (value type)
        //Assigning two intrinsic value types results in  two independent variables on the stack
        static void Assign_ValueType()
        {
            Console.WriteLine("Assign, value type\n");

            Point_struct p1 = new Point_struct(10, 10);
            Point_struct p2 = p1;

            //Points display
            p1.Disp_struct();
            p2.Disp_struct();

            //Changing
            p1.x = 50;
            Console.WriteLine("\n=> to p1.x\n");
            p1.Disp_struct();
            p2.Disp_struct();
        }
        #endregion

        #region Assignment (reference type)
        static void Assign_ReferenceType()
        {
            Console.WriteLine("Assign, reference type \n");
            Point_class p1 = new Point_class(10, 10);
            Point_class p2 = p1;

            //Display points
            p1.Disp_class();
            p2.Disp_class();

            // Changing
            p1.x = 50;
            Console.WriteLine("\n=> to p1.x\n");
            p1.Disp_class();
            p2.Disp_class();
        }
        #endregion

        #region Assignment (value type containing ref type)
        static void ValueType_RefType()
        {
            //First box
            Console.WriteLine("-> Creating b1");
            Box b1 = new Box("First box", 10, 10, 25, 25);

            //New box
            Console.WriteLine("-> Assign b2 to b1");
            Box b2 = b1;

            //
            Console.WriteLine("-> Changing b2");
            b2.box_abt.About_str = "About new ...";
            b2.box_Bottom = 3000;

            //Display
            b1.Disp_box();
            b2.Disp_box();
        }
        #endregion

        #endregion

        #region Reg4
        static void Destr_Class()
        { 
            Car p = new Car("Blue");
        }
        #endregion

        #region Reg5
        static void Arr_Class()
        {
            var int_Arr = new[] { 0, 1, 2 };
            var str_Arr = new[] { "Hello", "Array", null };
            var nullable_intArr = new[] { 0, (int?)1, 2 };

            Console.WriteLine(int_Arr.GetType());
            Console.WriteLine(str_Arr.GetType());
            Console.WriteLine(nullable_intArr.GetType());
            Console.WriteLine(nullable_intArr.GetLength(0));

        }
        #endregion

        #region Reg6
        static void Ind_Class()
        {
            Indexed_students stud_list = new Indexed_students();
            stud_list[0] = "Andy";
            stud_list[1] = "Mary";
            stud_list[2] = "John";
            stud_list[3] = "Rebecca";
            stud_list[4] = "Robert";
            stud_list[5] = "Peter";
            stud_list[6] = "Mishel";
            for (int i = 0; i < Indexed_students.stud_cnt; i++)
            {
                Console.WriteLine(stud_list[i]);
            }
        }
        #endregion

        #region Reg7
        static void Prop_Class()
        {
            Slot myFirstShed = new Slot();
            myFirstShed.slot_Height = 5;
            myFirstShed.slot_Width = 5;
            myFirstShed.slot_Lengthwise = myFirstShed.slot_Width*3;

            Console.WriteLine("Slot height = " + myFirstShed.slot_Height);
            Console.WriteLine("Slot wight = " + myFirstShed.slot_Width);
            Console.WriteLine("Slot lengthwise = : " + myFirstShed.slot_Lengthwise);
        }
        #endregion

        #region Reg8
        static void Abstr_Class()
        {
            UserGroup user_1 = new UserGroup ("Albert", "Moon", 1);
            Console.WriteLine("User information: "+user_1.User_Info());
        }
        #endregion

        #region Reg9
        static void Inter_Class()
        {
            Stud_message p1 = new Stud_message ("test 1","11/05/2015" , 1.00);
            Stud_message p2 = new Stud_message("test 2", "12/05/2015", 2.00);
         
            p1.show_message();
            p2.show_message();
        }
        #endregion
    }
}
