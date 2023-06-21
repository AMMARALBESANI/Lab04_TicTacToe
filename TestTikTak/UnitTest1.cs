using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("XO3,4X6,789", false)]
        [InlineData("XO3,4O6,7O9", true)]
        [InlineData("XO3,456,789", false)]
        public void TestForWinners(string input, bool expected)
        {
            string[] inputSplit = input.Split(',');
            string[,] gameBoard = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = inputSplit[i][j].ToString();
                }
            }

            // Arrange
            Player palyer1 = new Player();
            Player palyer2 = new Player();
            palyer1.Name = "ammar";
            palyer2.Name = "abd";
            palyer1.Marker = "X";
            palyer2.Marker = "O";
            palyer1.IsTurn = true;
            palyer2.IsTurn = false;
            Game Tictac = new Game(palyer1, palyer2);
            Tictac.Board.GameBoard = gameBoard;

            // Act
            bool result = Tictac.CheckForWinner(Tictac.Board);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSwitchPlayer()
        {
            // Arrange
            Player palyer1 = new Player();
            Player palyer2 = new Player();
            palyer1.Name = "ammar";
            palyer2.Name = "abd";
            palyer1.Marker = "X";
            palyer2.Marker = "O";
            palyer1.IsTurn = true;
            palyer2.IsTurn = false;
            Game Tictac = new Game(palyer1, palyer2);

            // Act
            Tictac.SwitchPlayer();

            // Assert
            Assert.False(palyer1.IsTurn);
            Assert.True(palyer2.IsTurn);
        }

        [Theory]
        [InlineData("8", 2, 1)]
        [InlineData("2", 0, 1)]
        [InlineData("3", 0, 2)]
        public void TestTakeTurn(string input, int expectedRow, int expectedColumn)
        {
            // Arrange
            Console.SetIn(new StringReader(input));
            Player palyer1 = new Player();
            Player palyer2 = new Player();
            palyer1.Name = "ammar";
            palyer2.Name = "abd";
            palyer1.Marker = "X";
            palyer2.Marker = "O";
            palyer1.IsTurn = true;
            palyer2.IsTurn = false;
            Game Tictac = new Game(palyer1, palyer2);

            // Act
            palyer1.TakeTurn(Tictac.Board);

            // Assert
            Assert.Equal("X", Tictac.Board.GameBoard[expectedRow, expectedColumn]);
        }
    }
}
