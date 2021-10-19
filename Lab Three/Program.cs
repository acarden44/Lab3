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
                numberIsBad = true;
                while (numberIsBad == true)
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
                            bool isEvenNumber;
                            if (userNumber % 2 == 0) //this isn't working and I am not really sure why. I obviously hate to do this but it is too late to try to do anything else. 
                            {
                                isEvenNumber = true;
                            }
                            else if (isEvenNumber = true && userNumber < 25)
                            {
                                Console.WriteLine("Even and less than 25.");
                            }
                            else if (isEvenNumber = true && userNumber > 60)
                            {
                                Console.WriteLine("{0} Even.", userNumber);
                            }
                            else if (isEvenNumber = true && userNumber > 25 && userNumber < 60)
                            {
                                Console.WriteLine("Even.");
                            }
                            else
                            {
                                isEvenNumber = false;
                                Console.WriteLine("{0} Odd", userNumber);
                            }
                            Console.ReadKey();
                        }
                    }
                }
            } while (numberIsBad = true);
        }
    }

}

