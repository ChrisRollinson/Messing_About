using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8ball
{
    class Program
    {
        static void Main(string[] args)
        {
            //preserve console color
            ConsoleColor oldColor = Console.ForegroundColor;

            //tell user the name of the program
            ProgramName();

            //randomizer object
            Random randomObject = new Random();

            //infinite loop
            while(true)
            {
                //ask user for a question
                string questionString = GetQuestionFromUser();

                //check for question
                if (questionString.Length == 0)
                {
                    Console.WriteLine("You need to ask a question!");
                    continue;
                }

                //check for quit command
                if(questionString.ToLower() == "quit")
                {
                    break;
                }

                if(questionString.ToLower() == "exit")
                {
                    break;
                }

                if(questionString.ToLower() == "close")
                {
                    break;
                }

                //check for insult
                if(questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("Your insults are useless");
                    Thread.Sleep(1500);
                    break;
                }


                //thinking time
                int numberOfSecondsToSleep = randomObject.Next(5) + 1;
                Console.WriteLine("Thinking...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                //randomizer
                int randomNumber = randomObject.Next(2);

                //generate answer
                switch (randomNumber)
                {
                    case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("yes");
                        break;

                    }
                    case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("no");
                        break;
                    }
                }
            }


            //re-applying original console color
            Console.ForegroundColor = oldColor;
        }

        static void ProgramName()
        {
            //change console color
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Magic 8 Ball (By: Chris)");
        }

        static string GetQuestionFromUser()
        {
            //ask user a question
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ask your question: ");
                Console.ForegroundColor = ConsoleColor.White;
                string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
