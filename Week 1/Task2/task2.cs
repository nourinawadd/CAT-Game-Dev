using System;

namespace Tasks
{
    class MainClass
    {
        public static void Main(string [] args)
        {
            int[,] scores  = new int[10,4];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inputing the scores of player " + (i+1));
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Game " + (j+1) + "= ");
                    scores[i,j] = Convert.ToInt32( Console.ReadLine());
                }
            }
            DisplayHighscore(scores);

        }

        static void DisplayHighscore(int[,] scores)
        {
            int highestScore = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (scores[i,j] > highestScore){
                        highestScore = scores[i,j];
                    }
                }
                Console.WriteLine("Highest score in game " + (j+1) + " = " + highestScore);
            } 
        }
    }
}