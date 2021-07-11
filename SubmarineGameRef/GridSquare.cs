﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineGameRef
{
   public class GridSquare
    {
        private const string IsLandReturnText = "Move Rejected. This Space is land";
        private const string IsMineReturnText = "You hit a mine! Take 1 damage";
        private const string ValidMoveReturnText = "You have successfully moved";

        private Coordinate coordinates;
        private string ResidentPlayerName;
        private bool HasLand;
        private bool HasPlayer;
        private bool HasMine; 


        public GridSquare(Coordinate coordinate)
        {
            this.coordinates = coordinate;
        }

        public string PlayerEnters()
        {
            if (HasLand)
            {
                return IsLandReturnText;
            }
            if (HasMine)
            {
                HasMine = false;
                return IsMineReturnText;
            }
            this.HasPlayer = true;
            return ValidMoveReturnText;
        }
    }
}
