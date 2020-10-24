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
	    int[] Array = new int[7];
	    //Variable
            int positionOfPlayer = START_POSITION;
            int count = 0;
            int diceRoll = 0;
	    int player1 = 0;
	    int player2 = 0;
			
	    //The player rolls a die to get a number between 1 to 6
            Random random = new Random();
            int diceNumber = random.Next(0, 7);
            Console.WriteLine("Number occured on Dice is:" + diceNumber);
			
	    //The player checks for an option
            while (positionOfPlayer == FINAL_POSITION)
            {
                Random random1 = new Random();
                int checkOption = random1.Next(3);
                switch (checkOption)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        Console.WriteLine("Current position is:" + diceNumber);
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        positionOfPlayer = positionOfPlayer + diceNumber;
                        Console.WriteLine("Current position is:" + positionOfPlayer);
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        int result = positionOfPlayer - diceNumber;
                        if (result > 0)
                        {
                            positionOfPlayer = positionOfPlayer - diceNumber;
                            Console.WriteLine("Current position is:" + positionOfPlayer);
                        }
                        else
                        {
                            //positionOfPlayer = positionOfPlayer;
                            Console.WriteLine("Current position is:" + positionOfPlayer);
                        }
                        break;
                }
            }
			
	    //Repeat till the player reaches the winning position 100
            while (positionOfPlayer != FINAL_POSITION || positionOfPlayer > FINAL_POSITION)
            {
                if (positionOfPlayer < START_POSITION)
                {
                    positionOfPlayer = START_POSITION;
                    Console.WriteLine("Your current position is:" + positionOfPlayer);
                }
                else if(positionOfPlayer == FINAL_POSITION)
                {
                    Console.WriteLine("Your position is 100");
                    Console.WriteLine("You Won the Game!");
                }
                else if(positionOfPlayer > FINAL_POSITION)
                {
                    positionOfPlayer = positionOfPlayer - diceNumber;
                }
                Array[count] = positionOfPlayer;
                count=count+1;
				turn = 0;
            }
	    //Position after every die
            for(int positionOfBoard=0;positionOfBoard<diceRoll;positionOfBoard++)
            {
		if(turn == 0)
		{
			turn=1;
			Console.WriteLine(Turn of Dice:"+(positionOfBoard+1)+"player1:positionOfPlayer"+Array[positionOfBoard]);
		}
		else
		{
			turn=0;
			Console.WriteLine(Turn of Dice:"+(positionOfBoard+1)+"player2:positionOfPlayer"+Array[positionOfBoard]);
		}
            }
        }
    }
}
