using System;

namespace Lab3DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool numberIsBad = true;
            int userNumber = 0;

            string userName = "";
            Console.Write("Hello beautiful human! Please tell me - what is your name? ");
            userName = Console.ReadLine();

            do
            {
                {
                    Console.WriteLine("{0}, pick a number from 1 - 100: ", userName);
                    userInput = Console.ReadLine();
                    userNumber = int.Parse(userInput);
                    if (userNumber > 100 || userNumber < 1)
                    {
                        numberIsBad = true;
                        Console.WriteLine("This number is not correct, Please try again.");
                    }
                    else
                    {
                        numberIsBad = false;
                    }
                    {
                        {
                            if (userNumber % 2 == 0 && userNumber < 25)
                            {
                                Console.WriteLine("Even and less than 25.");
                            }
                            else if (userNumber % 2 == 0 && userNumber >= 60)
                            {
                                Console.WriteLine("{0} Even.", userNumber);
                            }
                            else if (userNumber % 2 == 0 && userNumber > 25 && userNumber <= 60)
                            {
                                Console.WriteLine("Even.");
                            }
                            else
                            {
                                Console.WriteLine("{0} Odd", userNumber);
                            }
                            Console.ReadKey();
                        }
                    }
                }
            } while (numberIsBad == false);
        }
    }

}