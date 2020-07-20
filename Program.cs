using System;

namespace Lab4._1Dice
{
    class Program
    {
        static int RandNum(int x)
        {
            Random rand = new Random();
            int randNum = rand.Next(1, x + 1);
            return randNum;
        }

        static void DiceRollGame()
        {
            string userCont = "y";
            while (userCont != "n")
            {
                Console.WriteLine("How many sides?");
                int sides = int.Parse(Console.ReadLine());
                string userContSize = "y";
                while (userContSize != "n")
                {

                    int firstDie = RandNum(sides);
                    int secondDie = RandNum(sides);
                    

                    Console.WriteLine(   GameMessage(firstDie, secondDie, sides));
                    Console.WriteLine("\n\nDo you want to roll the same size again? (y/n)");
                    userContSize = Console.ReadLine();
                }

            }
            Console.WriteLine($"\n\nDo you want roll a new set of dice (y/n)");
            userCont = Console.ReadLine();
        }

        static string GameMessage(int x, int y, int z)
        {
            int firstDie = x;
            int secondDie = y;
            int sides = z;
            int total = x + y;

            string diceRoll = $"First Die: {firstDie}\nSecond Die: {secondDie}\nTotal: {total}";

            if (sides == 6)
            {
                //Console.WriteLine(diceRoll);
                // Console.WriteLine($"{diceRoll}\nFirst Die: {firstDie}\nSecond Die: {SecondDie}");
                if (total == 12 || total == 3 || total == 2)
                {

                    //Box cars
                    if (firstDie == 6 && secondDie == 6)
                    {
                        return  $"\nBox Cars";
                    }
                    //Ace Deuce
                    else if (firstDie == 1 && secondDie == 2 || firstDie == 2 && secondDie == 1)
                    {
                        return  ($"{diceRoll}\nAce Deuce");
                    }
                    //Snake eyes
                    else if (firstDie == 1 && secondDie == 1)
                    {
                        return ($"{diceRoll}\nSnake eyes");
                    }
                    return ($"{diceRoll}\nCraps!");
                }
                else if (total == 7 || total == 11)
                {
                    return  ($"{diceRoll}\nWin!");
                }
                else
                {
                    return diceRoll;
                }
            }
            else
            {
                return diceRoll;
            }


        }
        static void Main(string[] args)
        {
            DiceRollGame();

        }


    }
}
