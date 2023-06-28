using System;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings Gamer !");
            Console.WriteLine("Welcome to thee Rock, Paper, Scissor game !");
            Console.WriteLine("TO START PLEASE FOLLOW THE GIVEN INSTRUCTIONS !");
            
            bool continuePlaying = true;

            while (continuePlaying)
            {
                int draws = 0;
                int wins = 0;
                int loses = 0;

                Console.WriteLine("Pick an input to play \n 'Rock', 'Paper', or 'Scissors'.");
                string playerInput = Console.ReadLine().ToLower();

                while (playerInput != "rock" && playerInput != "paper" && playerInput != "scissors")
                {
                    Console.WriteLine("INCORRECT!!!!!!!PLEASE INSERT CORRECT INPUT!");
                    playerInput = Console.ReadLine().ToLower();

                }

                Random random = new Random();
                int computerInput = random.Next(1, 4);

                switch (computerInput)
                {
                    case 1:
                        Console.WriteLine("The computer played Rock.");
                        if (playerInput == "rock")
                        {
                            Console.WriteLine("It's a draw!\n");
                            Console.WriteLine("You both picked the same input");
                            draws++;
                        }
                        else if (playerInput == "paper")
                        {
                            Console.WriteLine("CONGRATS!!!! You win!");
                            Console.WriteLine("Paper covers Rock!\n");
                            wins++;
                        }
                        else if (playerInput == "scissors")
                        {
                            Console.WriteLine("OHHH SORRY !!!Computer wins!\n");
                            Console.WriteLine("Rock crushes Scissors!\n");
                            loses++;
                        }
                        break;

                    case 2:
                        Console.WriteLine("The computer played Paper.");
                        if (playerInput == "paper")
                        {
                            Console.WriteLine("It's a draw!\n");
                            Console.WriteLine("You both picked the same input");
                            draws++;
                        }
                        else if (playerInput == "rock")
                        {
                            Console.WriteLine("OHHH SORRY!!Computer wins!\n");
                            Console.WriteLine("Paper covers Rock!\n");
                            loses++;
                        }
                        else if (playerInput == "scissors")
                        {
                            Console.WriteLine("CONGRATS!!!!You win!\n");
                            Console.WriteLine("Scissors cuts Paper!\n");
                            wins++;
                        }
                        break;

                    case 3:
                        Console.WriteLine("The computer played Scissors.");
                        if (playerInput == "scissors")
                        {
                            Console.WriteLine("It's a draw!\n");
                            Console.WriteLine("You both picked the same input");
                            draws++;
                        }
                        else if (playerInput == "rock")
                        {
                            Console.WriteLine("CONGRATS !!!!You win!\n");
                            Console.WriteLine("Rock crushes Scissors!\n");
                            wins++;
                        }
                        else if (playerInput == "paper")
                        {
                            Console.WriteLine("OHHHH SORRY !!!!Computer wins!\n");
                            Console.WriteLine("Scissors cut Paper!\n");
                            loses++;
                        }
                        break;
                }
                Console.WriteLine("Results: Wins: {0}, Loses: {1}, Draws: {2}", wins, loses, draws);

                bool validinput = false;
                while (!validinput)
                {
                    Console.WriteLine("Do you want to play again? (y/n)");
                    string loop = Console.ReadLine().ToLower();


                    if (loop == "y")
                    {
                        validinput = true;
                    }
                    else if (loop == "n")
                    {
                        validinput = true;
                        continuePlaying = false;
                        Console.WriteLine("Thank you for playing Rock, Paper, Scissors! See you next time! ,Press any key to log out. Have a great day!");
                    }
                    else
                    {
                        Console.WriteLine("INCORRECT INPUT ! PLEASE INSERT 'Y' OR 'N'");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

