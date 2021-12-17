using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Games.Mollymage.Tests
{
    [TestFixture]
    [Category("mollymage")]
    public class SolverTests
    {
        [Test]
        public void Test_Answer()
        {
            var message = "board=" +
                "☼☼☼☼☼" +
                "☼   ☼" +
                "☼ ☺ ☼" +
                "☼   ☼" +
                "☼☼☼☼";
            var solver = new MollymageSolver();
            Assert.AreEqual("ACT", solver.Get(new MollymageBoard(message)));
        }
    }
}
