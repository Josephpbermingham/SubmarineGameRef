
using System;

namespace SubmarineGameRef
{
    class Game
    {
        public void PlayGame(int NumPlayers, int GridSize)
        {
            GameBoard Game = new GameBoard(GridSize);
            Console.WriteLine(Game.ToString());
            //chose player #
            //players pick name and starting position
            //players take turns
        }
    }
}
