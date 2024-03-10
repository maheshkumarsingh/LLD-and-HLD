using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Strategies.WinningStrategies
{
    internal class DiagonalWinningStrategy : IWinningStrategy
    {
        public bool CheckForWinner(Move move, Board board)
        {

            int row = move.Cell.Row;
            int col = move.Cell.Col;
            bool left = false;
            bool right = false;
            if (row == col)
                left = LeftDiagonalCheck(move.Player.Symbol, board.Dimension);
            else if (row + col == board.Dimension)
                right = RightDiagonalCheck(move.Player.Symbol, board.Dimension);

            return left || right;
        }

        public bool LeftDiagonalCheck(Symbol symbol, int dimension)
        {
            Dictionary<Symbol, int> leftDiagonal = new Dictionary<Symbol, int>();

            if (!leftDiagonal.ContainsKey(symbol))
                leftDiagonal.Add(symbol, 1);
            else
                leftDiagonal[symbol]++;

            return leftDiagonal[symbol] == dimension;
        }

        public bool RightDiagonalCheck(Symbol symbol, int dimension)
        {

            Dictionary<Symbol, int> rightDiagonal = new Dictionary<Symbol, int>();

            if (!rightDiagonal.ContainsKey(symbol))
                rightDiagonal.Add(symbol, 1);
            else
                rightDiagonal[symbol]++;

            return rightDiagonal[symbol] == dimension;
        }
    }

}

