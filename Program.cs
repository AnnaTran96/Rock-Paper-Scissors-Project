using System;

namespace RockPaperScissors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string player, cpu;
            int randomNum;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose ROCK, PAPER OR SCISSORS:     ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                    Random rnd = new Random();
                    randomNum = rnd.Next(1, 4);

                    switch (randomNum)
                    {
                        case (1):
                            cpu = "ROCK";
                            Console.WriteLine("Computer chooses ROCK");

                            if (player == "ROCK")
                            {
                                Console.WriteLine("You both draw!\n\n");
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("You Win!\n\n");
                                scorePlayer++;
                            }
                            else if (player == "SCISSORS")
                            {
                                Console.WriteLine("You Lose!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case (2):
                            cpu = "PAPER";
                            Console.WriteLine("Computer chooses PAPER");

                            if (player == "PAPER")
                            {
                                Console.WriteLine("You both draw!\n\n");
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("You Lose!\n\n");
                                scoreCPU++;
                            }
                            else if (player == "SCISSORS")
                            {
                                Console.WriteLine("You Win!\n\n");
                                scorePlayer++;
                            }
                            break;

                        case (3):
                            cpu = "SCISSORS";
                            Console.WriteLine("Computer chooses SCISSORS");

                            if (player == "SCISSORS")
                            {
                                Console.WriteLine("You both draw!\n\n");
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("You Win!\n\n");
                                scorePlayer++;
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("You Lose!\n\n");
                                scoreCPU++;
                            }
                            break;

                        default:
                            player = "Invalid Entry. Please Try Again.";
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer,scoreCPU);


                }
                if (scoreCPU == 3)
                {
                    Console.WriteLine("You Lose! Computer Wins");
                }
                else if (scorePlayer == 3)
                {
                    Console.WriteLine("You won the game!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again? Yes or No? \n");
                string contGame;
                contGame = Console.ReadLine();
                contGame = contGame.ToLower();

                if (contGame == "yes")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (contGame == "no")
                {
                    playAgain = false;
                }
                else
                {

                }

            }
        }
    }
}
