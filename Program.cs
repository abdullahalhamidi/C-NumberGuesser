using System;

//Namespace 
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Run App Info
            GetAppInfo();

            //Greet Users 
            GreetUser();
            

            while(true) {
                // Init Correct Number 
                //int correctNumber = 7;

                //Create a New Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init Guess Var
                int guess = 0;


                // Ask User for Number 
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess not correct 
                while (guess != correctNumber)
                {
                    //Get User Input
                    string input = Console.ReadLine();

                    // Make Sure Its A Number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print Message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep Going 
                        continue;
                    }

                    //Cast to Int and Put in Guess 
                    guess = Int32.Parse(input);

                    //Match Guess to Correct Number 
                    if (guess != correctNumber)
                    {
                        //Change Text Color
                        Console.ForegroundColor = ConsoleColor.Red;


                        // Tell User Wrong Number 
                        Console.WriteLine("Wrong Number, please try again");

                        //Reset Text Color
                        Console.ResetColor();
                    }


                }

                //Change Text Color
                Console.ForegroundColor = ConsoleColor.Yellow;


                // Tell User Right Number 
                Console.WriteLine("Wrong Number, please try again");

                //Reset Text Color
                Console.ResetColor();

                // Ask to Play Again
                Console.WriteLine("Play Again? [Y or N]");

                //Get Answer 
                String answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }


 
        }
        
        //Display App Info
        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Abdullah Alhamidi";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;


            // Write Out App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

        //Ask Users Name
        static void GreetUser()
        {
            //Ask Users Name 
            Console.WriteLine("What is your name ?");

            //Get User Answer
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Pring Color Message 
        static void PrintColorMessage(ConsoleColor, ConsoleColor, string message)
        {
            //Change Text Color
            Console.ForegroundColor = color;


            // Tell User Not a Number 
            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }
    }
}
