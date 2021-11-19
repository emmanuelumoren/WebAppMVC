using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class GameRandom
    {
        public static string MatchGuess(int guess, int rnd)
        {
            if (guess < rnd)
            {
                return "HigherTemp!";
            }
            else if (guess > rnd)
            {
                return "LowerTemp!";
            }
            else
            {
                return "Yes!! You won!";
            }
        }
        public static int GetRandom(int max)
        {
            Random rnd = new Random();
            return rnd.Next(1, max);
        }
    }
}
