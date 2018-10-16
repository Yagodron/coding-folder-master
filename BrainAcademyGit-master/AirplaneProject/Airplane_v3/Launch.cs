using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Speech.Synthesis;

namespace Airplane_v4
{
    class Launch
    {

        private Random randomisator = new Random();
        private void SetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(randomisator.Next(1,15));         
        }

        public void PlaneDrawing()
        {
            int i = 0;
            while (i < 6)
            {
                SetRandomConsoleColor();
                Console.WriteLine("                                    ¶¶       ");
                Console.WriteLine("                                  1¶¶¶¶      ");
                Console.WriteLine("                                ¶¶¶¶¶¶¶       ");
                Console.WriteLine("                              ¶¶¶¶¶¶¶¶¶       ");
                Console.WriteLine("                           1¶¶¶111¶¶¶¶        ");
                Console.WriteLine("         ¶1  1           1¶¶¶¶11111¶¶         ");
                Console.WriteLine("         ¶¶11111       1¶¶¶¶¶¶¶¶1¶¶¶          ");
                Console.WriteLine("         1¶¶1111¶1  11¶¶¶¶¶¶¶¶¶¶¶¶¶           ");
                Console.WriteLine("          ¶¶¶¶1111¶1¶¶¶¶¶¶¶¶¶¶¶¶¶¶            ");
                Console.WriteLine("           1¶¶¶¶¶11¶¶¶¶¶¶¶¶¶¶¶¶¶¶             ");
                Console.WriteLine("             1¶¶¶¶¶111¶¶¶¶¶¶¶¶¶¶              ");
                Console.WriteLine("             1¶¶¶¶¶¶111¶¶¶¶¶¶¶¶               ");
                Console.WriteLine("            ¶¶¶¶¶¶¶¶1   1¶¶¶¶¶                ");
                Console.WriteLine("           ¶¶¶¶¶¶¶¶¶¶111 1¶¶1                 ");
                Console.WriteLine("          ¶¶¶¶¶¶¶¶¶¶¶¶¶11 1¶                  ");
                Console.WriteLine("        1¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶1 11                ");
                Console.WriteLine("       ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶11¶¶¶¶¶1               ");
                Console.WriteLine("     1¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶1     ¶¶¶¶¶              ");
                Console.WriteLine("    1¶¶111¶¶¶¶¶¶¶¶1          ¶¶¶¶1         1  ");
                Console.WriteLine("   ¶¶¶1111¶¶¶¶¶1               1¶¶¶   11¶¶¶¶¶ ");
                Console.WriteLine(" 1¶¶¶¶¶¶¶¶¶¶1                    1¶  ¶¶¶¶¶¶¶¶ ");
                Console.WriteLine("¶¶¶¶¶¶¶¶¶1                        ¶¶1 1¶¶¶¶¶  ");
                Console.WriteLine(" 1¶¶¶11                          1¶¶¶¶11¶¶1   ");
                Console.WriteLine("                                 ¶¶¶¶¶¶1      ");
                Console.WriteLine("                                ¶¶¶¶¶¶¶       ");
                Console.WriteLine("                                ¶¶¶¶1         ");
                Console.WriteLine("         welcome to project airline           ");
                Thread.Sleep(500);
                Console.Clear();
                i++;
            }
        }

        public void Speech()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;
            synthesizer.Rate = -2;

            synthesizer.Speak("welcome to project airline");
        }
    }
}
