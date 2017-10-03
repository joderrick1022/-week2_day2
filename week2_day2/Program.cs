using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////for loop
            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}
            //string greetings = " Hi my name is JD";
            //string[] words = greetings.Split();
            //for (int i = 0; i < words.Length ; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            // list favfoods throuh a loop

            //string[] favFoods = { "pizza", "chicken", "burgers", "salmon", "Roast", };
            //for(int i = 0; i < favFoods.Length; i++)
            //{
            //    Console.WriteLine(favFoods[i]);
            //}




            // lucy numbers call numers through foreach loop

            //int[] luckyNum = {1,2,4,6,34,5,7,23,9, };

            //foreach (int numer in luckyNum)
            //{
            //    Console.WriteLine("Your lucky number is :" + " "+ numer);
            //}

            // call days of the week usi
            string days =  "mon tues wen thur fri sat sun" ;
            string[] day = days.Split();
           
          // foreach(string d in day)
            //{
                Console.WriteLine(day[0]);
           // }



        }
    }
}
