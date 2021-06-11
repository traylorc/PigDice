using System;

namespace PigDice
{
    class Program
    {
        static void Main(string[] args)
        {
            var pigdice = new PigDice();
            var result = pigdice.Play(500);
            Console.WriteLine($"HighScore is {result[0]} for {result[1]} games played");
        }
    }
}
