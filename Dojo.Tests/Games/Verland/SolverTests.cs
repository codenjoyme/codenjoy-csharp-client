using NUnit.Framework;

namespace Dojo.Games.Verland.Tests
{
    [Category("clifford")]
    public class SolverTests
    {
        [Test]
        public void Test_Answer()
        {
            var message = "board=" +
                "☼☼☼☼☼" +
                "☼   ☼" +
                "☼ ⊳ ☼" +
                "☼   ☼" +
                "☼☼☼☼";
            var solver = new VerlandSolver();
            Assert.AreEqual("Right", solver.Get(new VerlandBoard(message)));
        }
    }
}