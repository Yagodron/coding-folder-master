using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Hello_Debug_Trace
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
                    //do something
                    Console.WriteLine(@"Please,  type the number:                 
                        1.  Debugging                    
                        2.  Tracing
                        3.  Windows logging. Only as Windows administrator.
                        4.  Performance counters  
                        5.  Dispose 
                        ");
                    try
                    {                        
                        a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                Console.WriteLine("Debugging");
                                HelloDebug();
                                break;
                            case 2:
                                Console.WriteLine("Tracing");
                                HelloTrace();
                                HelloTrace_file();                               
                                break;
                            case 3:
                                Console.WriteLine("Windows logging. Only as Windows administrator.");
                                HelloLogging();
                                break;
                            case 4:
                                Console.WriteLine("Performance counters");
                                HelloPerf();
                                break;
                            case 5:
                                Console.WriteLine("Dispose");
                                HelloDisp();
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("Error");
                    }
                    finally
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void HelloDisp()
        {
            Console.WriteLine("File reading 1");
            TextReader rdr = null;
            try
            {
                rdr = new StreamReader("Hello_Debug_Trace.txt");
                string s = rdr.ReadToEnd();
                Console.WriteLine(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine("StreamReader: "+ex.Message);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Dispose();
                }
            }
            Console.WriteLine("File reading 2");
            TextReader rdr1 = null;             
            try
            {
                using (rdr1 = new StreamReader("Hello_Debug_Trace.txt"))
                {
                    string s = rdr1.ReadToEnd();
                    Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("StreamReader: " + ex.Message);
            }
            Console.WriteLine("File reading 3");
            Disp_ex rdr2 = null;
            try
            {
                rdr2 = new Disp_ex("Hello_Debug_Trace.txt");
                rdr2.Show();
            }
            finally
            {
                rdr2.Dispose();
            }
        }
        static void HelloPerf()
        {
            //This counter provides a measure of how much time the processor actually spends working on productive threads and how often it was busy servicing requests
            PerformanceCounter theCPUCounter =
                new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
            // This is the current size of the memory area that the process is utilizing for code, threads, and data.
            PerformanceCounter theMemCounter =
                new PerformanceCounter("Process", "Working Set", Process.GetCurrentProcess().ProcessName);
            theCPUCounter.NextValue();
            theMemCounter.NextValue();       
            Console.WriteLine("Press Spacebar key to stop");

            {
                string str = "CPU, Memory:";
            Console.Write(str);
            do
            {
            while (!Console.KeyAvailable)
            {
                Console.Write(" "+theCPUCounter.RawValue +", "+theMemCounter.RawValue);
                Console.SetCursorPosition(str.Length, Console.CursorTop);
            }
            } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
            }

        }

        static void HelloLogging()
        {
            if (!EventLog.SourceExists("LogSource"))
            {
                EventLog.CreateEventSource("LogSource", "Hello_Debug_TraceV_Log");
                Console.WriteLine("Created_EventSource");
                Console.WriteLine("Please press any key :)");
                Console.ReadKey();
                return;
            }
            EventLog evLog = new EventLog();
            evLog.Source = "LogSource";
            evLog.WriteEntry("Logging and tracing events");
        }
        static void HelloDebug()
        {
            Debug.WriteLine("Starting application");
            Debug.Indent();
            int j = 1 + 2;
            Debug.Assert(j == 3);
            Debug.WriteLineIf(j > 0, "i > 0");
        }

        static void HelloTrace()
        {
            TraceSource traceSource = new TraceSource("TraceSource",
            SourceLevels.All);
            traceSource.TraceInformation("Tracing");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical");
            traceSource.TraceData(TraceEventType.Information, 1,
            new object[] { "x", "y", "z" });
            traceSource.Flush();
            traceSource.Close();
        }

        static void HelloTrace_file()
        {
            Stream TrFile = File.Create("Hello_Debug_Trace.txt");
            TextWriterTraceListener txtLstnr =
            new TextWriterTraceListener(TrFile);
            TraceSource traceSource = new TraceSource("TraceSource",
            SourceLevels.All);
            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(txtLstnr);
            traceSource.TraceInformation("Trace output");
            traceSource.Flush();
            traceSource.Close();

        }
    }
}
