using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Tests
{
    public class TestBoard : AbstractBoard<TestElements>
    {
        public TestBoard(string boardString) : base(boardString)
        {
        }
    }
}
