using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo
{
    public abstract class AbstractLayeredBoard<TEnum> : IBoard
    {
        public IBoard ForString(string input)
        {
            return this;
        }
    }
}
