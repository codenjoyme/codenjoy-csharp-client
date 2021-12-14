using NUnit.Framework;
using System;

namespace Dojo.Games.Verland.Tests
{
    [TestFixture]
    [Category("verland")]
    public class BoardTests
    {
        [Test]
        public void Test_IsGameOver()
        {
            var board = new VerlandBoard("☼☼☼" + "☼☼♥" + "☼☼☼");
            Assert.False(board.IsGameOver);

            board = new VerlandBoard("☼☼☼" + "X☼☼" + "☼☼☼");
            Assert.True(board.IsGameOver);
        }

        [Test]
        public void Test_FindHero()
        {
            var board = new VerlandBoard("☼♥☼" + "☼☼☼" + "☼☼☼");
            Assert.AreEqual(new Point(1, 2), board.GetHero());

            board = new VerlandBoard("☼☼☼" + "☼♥☼" + "☼☼☼");
            Assert.AreEqual(new Point(1, 1), board.GetHero());

            board = new VerlandBoard("☼☼☼" + "☼☼☼" + "☼♥☼");
            Assert.AreEqual(new Point(1, 0), board.GetHero());

            board = new VerlandBoard("☼☼♥" + "☼☼☼" + "☼☼☼");
            Assert.AreEqual(new Point(2, 2), board.GetHero());
        }
        
        [Test]
        public void Test_FindHero_NoResult()
        {
            var board = new VerlandBoard("☼☼☼" + "☼☼☼" + "☼☼☼");

            var ex = Assert.Throws<NullReferenceException>(() => board.GetHero());
            Assert.That(ex.Message, Is.EqualTo("Hero element has not been found."));
        }

        [Test]
        public void Test_GetOtherHeroes()
        {
            var board = new VerlandBoard("☼Y☼" + "☼♠☼" + "☼☼☼");
            CollectionAssert.AreEquivalent(new[] { new Point(1, 1), new Point(1, 2)},
                board.GetOtherHeroes());
        }

        [Test]
        public void Test_GetEnemyHeroes()
        {
            var board = new VerlandBoard("☼Z☼" + "☼♣☼" + "☼☼☼");
            CollectionAssert.AreEquivalent(new[] { new Point(1, 1), new Point(1, 2)},
                board.GetEnemyHeroes());
        }
        
        
        [Test]
        public void Test_BoardCountContagions()
        {
            var board = new VerlandBoard("***" + "***" + "8**");
            Assert.AreEqual(8, board.CountContagions(new Point(0, 0)));
        }
        
        [Test]
        public void Test_Report()
        {
            var board = new VerlandBoard("board=" +
                                         "☼☼☼☼☼☼☼☼☼" +
                                         "☼1 Y   y☼" +
                                         "☼*2  x  ☼" +
                                         "☼o 3 ♠ +☼" +
                                         "☼♥  4   ☼" +
                                         "☼   Z  ♣☼" +
                                         "☼z  5678☼" +
                                         "☼  !  X ☼" +
                                         "☼☼☼☼☼☼☼☼☼");

            Assert.AreEqual("☼☼☼☼☼☼☼☼☼\n"+
                            "☼1 Y   y☼\n"+
                            "☼*2  x  ☼\n"+
                            "☼o 3 ♠ +☼\n"+
                            "☼♥  4   ☼\n"+
                            "☼   Z  ♣☼\n"+
                            "☼z  5678☼\n"+
                            "☼  !  X ☼\n"+
                            "☼☼☼☼☼☼☼☼☼\n"+
                            "\nHero at: [1,4]"+
                            "\nOther heroes at: [3,7],[5,5]"+
                            "\nEnemy heroes at: [4,3],[7,3]"+
                            "\nOther stuff at: [0,0],[0,1],[0,2],[0,3],[0,4],[0,5],[0,6],[0,7],[0,8],[1,0],[1,5],[1,6],[1,8],[2,0],[2,8],"+
                            "[3,0],[3,8],[4,0],[4,8],[5,0],[5,8],[6,0],[6,8],[7,0],[7,8],[8,0],[8,1],[8,2],[8,3],[8,4],[8,5],[8,6],"+
                            "[8,7],[8,8]\n", board.ToString());
        }
    }
}
