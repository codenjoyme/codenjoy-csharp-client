using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Games.Verland
{
    public class VerlandSolver : ISolver
    {
        public string Get(IBoard gameBoard)
        {
            return Get(gameBoard as VerlandBoard);
        }

        private string Get(VerlandBoard gameBoard)
        {
            // Type here your code
            return Direction.Right.ToString();
        }
    }
}
