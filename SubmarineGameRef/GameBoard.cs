using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineGameRef
{
   public class GameBoard
    {
        public GridSquare[,] MasterGameBoard { get; set; }
        private int size;
        public GameBoard(int size)
        {
            this.size = size;
            var tempGameboard = new GridSquare[size, size];

            for (int i = 0; i < size; i++)
            {
      
                for (int j = 0; j < size; j++)
                {
                    tempGameboard[i, j] = new GridSquare(i,j);
                }
            }
            MasterGameBoard = tempGameboard;
        }
        public new string ToString() 
        {
            string retStr = "";
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    retStr += "[";
                    retStr += MasterGameBoard[i, j].ToString();
                    retStr += "],";
                }
                retStr += "\n";
            }
            return retStr;
        }

        public GridSquare GetGridSquare(int x, int y)
        {
            return MasterGameBoard[x, y];
        }
        public GridSquare SetGridSquare(GridSquare UpdatedSquare)
        {
            MasterGameBoard[UpdatedSquare.xpos, UpdatedSquare.ypos] = UpdatedSquare;
            return UpdatedSquare;
        }
        public GridSquare PlayerStartsAtGridSquare(int x, int y)
        {
            MasterGameBoard[x, y].PlayerEnters();
            return MasterGameBoard[x, y];
        }

    }
}
