using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubmarineGameRef
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GameBoard Game = new GameBoard(3);
            foreach (var item in Game.MasterGameBoard)
            {
                foreach (var subItem in Game.MasterGameBoard)
                {

                }
            }
        }
    }
}
