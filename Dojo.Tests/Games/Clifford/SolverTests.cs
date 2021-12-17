using NUnit.Framework;

namespace Dojo.Games.Clifford.Tests
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
            var solver = new CliffordSolver();
            Assert.AreEqual("RIGHT", solver.Get(new CliffordBoard(message)));
        }
    }
}