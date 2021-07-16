using System;
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

        public int xpos { get; set; }
        public int ypos { get; set; }
        public string ResidentPlayerName { get; set; }
        public bool HasLand { get; set; }
        public bool HasPlayer { get; set; }
        public bool HasMine { get; set; }


        public GridSquare(int CurX, int CurY)
        {
            this.xpos = CurX;
            this.ypos = CurY;
        }
        public string ToString()
        {
            return this.xpos + " " + this.ypos;
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
        public void PlayerLeaves()
        {
            this.HasPlayer = false;
        }

    }
}
