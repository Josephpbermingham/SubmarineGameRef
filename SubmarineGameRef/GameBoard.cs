using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmarineGameRef
{
   public class GameBoard
    {
        public GridSquare[,] MasterGameBoard { get; set; };

        public GameBoard(int size)
        {
            MasterGameBoard = new GridSquare[size,size];
        }
        
    }
}
