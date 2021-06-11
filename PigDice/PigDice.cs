using System;
using System.Collections.Generic;
using System.Text;

namespace PigDice
{
    class PigDice
    {
        Random rnd = new Random();

        public int[] Play(int ScoreToBeat=0) 
        {
            var NumberOfGames = 0;
            var HighScore = 0;           
            while(HighScore <= ScoreToBeat)
            {
                NumberOfGames++;
                var score = PlayOneGame();
                if (score > HighScore)
                {
                    HighScore = score;
                }
            }
            return new int[] { HighScore, NumberOfGames };
            
            
        }

        int PlayOneGame()
        {
            var score = 0;
            var die = Roll();
            while(die !=1)
            {
                score += die;
                die = Roll();
            }
            return score;
        }

        int Roll()
        {
            return rnd.Next(1, 7);
        }






















        public PigDice() { }
    }
}
