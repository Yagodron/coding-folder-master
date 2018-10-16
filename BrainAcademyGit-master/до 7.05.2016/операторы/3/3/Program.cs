using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a word, try теплая, холодная, снежная, дождливая, ветренная, солнечная," + '\n' + "туманная, сырая, хорошая, плохая'");
            string word = Console.ReadLine();
            switch (word)
            {
                case "теплая":
                    Console.WriteLine("translation: warm");
                    break;
                case "холодная":
                    Console.WriteLine("translation: cold");
                    break;
                case "снежная":
                    Console.WriteLine("translation: snowy");
                    break;
                case "дождливая":
                    Console.WriteLine("translation: rainy");
                    break;
                case "ветренная":
                    Console.WriteLine("translation: windy");
                    break;
                case "солнечная":
                    Console.WriteLine("translation: sunny");
                    break;
                case "туманная":
                    Console.WriteLine("translation: foggy");
                    break;
                case "сырая":
                    Console.WriteLine("translation: soggy");
                    break;
                case "хорошая":
                    Console.WriteLine("translation: good");
                    break;
                case "плохая":
                    Console.WriteLine("translation: bad");
                    break;
                default:
                    Console.WriteLine("not in the dictionary");
                    break;
            }
            Console.ReadLine();

        }
    }
}
