
using System;

namespace SubmarineGameRef
{
    class Game
    {
        public Player[] players;
        public void PlayGame(int NumPlayers, int GridSize)
        {
            GameBoard Game = new GameBoard(GridSize);
            Console.WriteLine(Game.ToString());
            
            //players pick name and starting position
            players = new Player[NumPlayers];
            for (int i = 0; i < NumPlayers; i++)
            {
                Console.WriteLine("Input Player Name:");
                string Name = Console.ReadLine();
                
                Console.WriteLine("Input starting x pos:");
                int xPos = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input starting y pos:");
                int yPos = Int32.Parse(Console.ReadLine());

                //This is where you would check if it is a valid spot
                GridSquare startingPos = Game.PlayerStartsAtGridSquare(xPos,yPos);

                players[i] = new Player(Name,startingPos);
            }
            
            //players take turns

        }
    }
}
