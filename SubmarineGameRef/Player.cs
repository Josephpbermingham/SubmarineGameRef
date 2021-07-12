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
    }
}