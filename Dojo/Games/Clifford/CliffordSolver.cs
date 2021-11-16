using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Games.Clifford
{
    public class CliffordSolver : ISolver
    {
        public string Get(IBoard gameBoard)
        {
            return Get(gameBoard as CliffordBoard);
        }

        private string Get(CliffordBoard gameBoard)
        {
            // Type here your code
            return Direction.Act.ToString();
        }
    }
}
