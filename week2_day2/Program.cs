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



            // call days of the week using a loop
            //string days =  "mon tues wen thur fri sat sun" ;
            //string[] day = days.Split();

            //foreach (string d in day)
            //{
            //    Console.WriteLine(day[0]);
            //}

            //string whatToSay = "once upon a time";

            //string[] storyWords = whatToSay.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            // lesson above using foreach loop
            //foreach(string i in storyWords){
            //    Console.WriteLine(i);
            //}

            //this is forfor each loop to count backwards
            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}



            //this is the while loop
            //this is the way you make a question reapear.
            //Console.WriteLine(  "do yoe want to playy again");
            //string playAgain = Console.ReadLine();
            //while (playAgain == "yes")
            //{
            //    Console.WriteLine("its a rematch");
            //    Console.WriteLine("do you want to play again? (yes/No)");
            //    playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("Hello would you like to check patient in for appointment (yes/no)");
            //string checIn = Console.ReadLine();
            //Console.WriteLine(checIn.ToLower());




            //while (checIn == "yes" ) 
            //{


            //    Console.WriteLine( "Patient Check IN System");
            //    Console.WriteLine(  "What is your full name EX first/last)");

            //   string fullName = Console.ReadLine();
            //    Console.WriteLine("what is patient six digit patient Id ex(000000)");
            //   int id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("what time is your appointment Ex(1:00)");
            //        string time = Console.ReadLine();
            //    Console.WriteLine("do you want to check patient in for appointment (yes/no)");
            //    string appointment = Console.ReadLine();



            //}


            // do while
            // do while loop is good for yes and no questions
            //string playAgain;


            //do
            //{

            //    Console.WriteLine("Great game");
            //    Console.WriteLine("Do you want to play again?");
            //    playAgain = Console.ReadLine();
            //    Console.WriteLine(playAgain.ToLower());
            //}
            //while (playAgain == "yes");

            //Console.WriteLine("thanks for playing");
            //{

            //}


            //ask the user the same question if the amswer is yes
            //string userClass;
            //string letterGrade;
            //do
            //{
            //    Console.WriteLine("what classes would you like to add to your GPA calculations");
            //    Console.ReadLine();



            //    Console.WriteLine("what Grade did you recieve in the class");
            //    letterGrade = Console.ReadLine();
            //    Console.WriteLine(letterGrade.ToLower());

            //    Console.WriteLine("would you like to add more classes to your GPA calculations");
            //    userClass = Console.ReadLine();
            //    Console.WriteLine(userClass.ToLower());




            //} while (userClass == "yes");

            //for(int i = 1; i <= 20; i++)
            //{

            //    if(i % 13 == 0)
            //    {
            //        break; // it is used to break a loop if condition is true
            //        //continue;  //this is skiping over even numbers and printing odds.
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 2; i++)
            //{
            //    for(int j = 1; j <= 8; j++)
            //    {
            //        Console.Write(j);
            //    }
            //   Console.WriteLine();
            //}



            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write(col + "");
                }
                Console.WriteLine();
            
            }


        }
    }
}
