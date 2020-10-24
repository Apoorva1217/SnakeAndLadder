using System;

namespace Snake_and_Ladder
{
    class Program
    {
        /// <summary>
        /// Snake and Ladder Game Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");
            //Constants
            const int START_POSITION = 0;
            const int FINAL_POSITION = 100;
	    //Variable
            int positionOfPlayer = START_POSITION;
			
	    //The player rolls a die to get a number between 1 to 6
            Random random = new Random();
            int diceNumber = random.Next(0, 7);
            Console.WriteLine("Number occured on Dice is:" + diceNumber);
        }
    }
}
