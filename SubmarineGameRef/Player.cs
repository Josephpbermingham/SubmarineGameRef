using System;

namespace SubmarineGameRef
{
    public class Player
    {
        private string Name;
        private int DamageTaken;
        private GridSquare CurrentLocation;
        public Player(string name, GridSquare curr)
        {
            this.DamageTaken = 0;
            this.Name = name;
            CurrentLocation = curr;
        }
        public void goNorth(GameBoard gameBoard)
        {
            //you need to:
                //call gameBoard[coordinates of player].PlayerLeaves on the old square,
                //call Player enters on the new square
                //update this.currentLocation

            //notes. There is a GameBoard.getGridSquare and a GameBoard.setGridSquare
        }
    }
}