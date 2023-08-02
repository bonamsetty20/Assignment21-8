using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
       public  static List<string> fruitsList = new List<string>()
        {
            "Apple", "Banana", "Orange", "Pineapple", "Blueberry", "Green Apple", "Grapes", "Strawberry", "Watermelon", "Mango"

        };

       public  static List<string> daysOfWeek = new List<string>()
        {
            "Sunday", "Monday","Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        };

       public  static List<string> monthsOfYear = new List<string>()
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };

        public static Dictionary<string, string> wordMeanings = new Dictionary<string, string>()
        {
            { "Apple", "A fruit with red or green skin and white inside." },
        { "Banana", "A long curved fruit with a yellow skin." },
        { "Orange", "A round fruit with orange skin and juicy inside." },
        { "Grapes", "Small juicy fruits that grow in bunches." },
        { "Pineapple", "A tropical fruit with spiky skin and sweet inside." }


        };

         public static void DisplayDays()
        {
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine("Day :" + day);
                Thread.Sleep(2000);

            }
        }

       public  static void DisplayMonths()
        {
            foreach (string month in monthsOfYear)
            {
                Console.WriteLine("Month: " + month);
                Thread.Sleep(2000);
            }
        }

        public static void DisplayFruits()
        {
            foreach (var fruit in fruitsList)
            {
                Console.WriteLine("Fruits: " + fruit);
                Thread.Sleep(1000);
            }
        }

      public static void DisplayWordsAndMeanings()
        {
            foreach (var word in wordMeanings)
            {
                Console.WriteLine($"Words: {word.Key} - Meaning: {word.Value}");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------------Welcome to Learning------------");
            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsThread = new Thread(DisplayFruits);
            Thread wordsThread = new Thread(DisplayWordsAndMeanings);

            daysThread.Start();
            daysThread.Join();

            Thread.Sleep(5000);

            monthsThread.Start();
            monthsThread.Join();

            fruitsThread.Start();
            wordsThread.Start();

            fruitsThread.Join();
            wordsThread.Join();

            Console.ReadKey();

        }
    }
}
    

