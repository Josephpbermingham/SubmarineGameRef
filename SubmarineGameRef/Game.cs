
using System;

namespace SubmarineGameRef
{
    class Game
    {
        public GameBoard ActiveGameBoard;
        public bool hasWinner;
        public Player[] players;
        public void PlayGame(int NumPlayers, int GridSize)
        {
            ActiveGameBoard = new GameBoard(GridSize);
            hasWinner = false;
            SetUpPlayers(NumPlayers);
            

            //players take turns
            while(hasWinner == false)
            {
                foreach (var player in players)
                {
                    TakeTurn(player);
                }
            }
        }
        private void TakeTurn(Player player)
        {
            //do a if else tree to determine what a player wants to do
            player.goNorth(ActiveGameBoard);
            
        }
        public void SetUpPlayers(int NumPlayers)
        {
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
                GridSquare startingPos = ActiveGameBoard.PlayerStartsAtGridSquare(xPos, yPos);

                players[i] = new Player(Name, startingPos);
            }
        }
    }
}
