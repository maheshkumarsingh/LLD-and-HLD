using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Strategies.PlayingStrategies
{
    internal class MediumBotPlayingStrategy : IBotPlayingStrategy
    {
        Random random = new Random();
        public Move MakeMove(Board board)
        {
            int dimension = board.Dimension;

            while(true)
            {
                int i = random.Next(dimension);
                int j = random.Next(dimension);

                Cell cell = board.Boards[i,j];

                if (cell.State.Equals(CellState.Empty))
                {
                    return new Move(null, cell);
                }
            }
            return null;
        }
    }
}

/*
 * // Assuming the same classes as in the previous response (Board, Cell, Move, CellState, etc.)

public class Board
{
    // Other methods and properties...

    public Move GetMediumBotMove(CellState botSymbol)
    {
        // Check for a winning move or block the opponent
        foreach (var cell in GetEmptyCells())
        {
            // Simulate the move
            cell.State = botSymbol;

            // Check for a win
            if (IsWinner(botSymbol))
            {
                cell.State = CellState.Empty; // Reset the move
                return new Move(null, cell);
            }

            // Reset the move
            cell.State = CellState.Empty;
        }

        // If no winning move or block, make a random move
        return GetEasyBotMove();
    }

    public Move GetHardBotMove(CellState botSymbol)
    {
        int bestScore = int.MinValue;
        Move bestMove = null;

        foreach (var cell in GetEmptyCells())
        {
            // Simulate the move
            cell.State = botSymbol;

            // Get the score for the current move
            int score = MiniMax(this, 0, false);

            // Reset the move
            cell.State = CellState.Empty;

            // Update the best move if the score is better
            if (score > bestScore)
            {
                bestScore = score;
                bestMove = new Move(null, cell);
            }
        }

        return bestMove;
    }

    private int MiniMax(Board board, int depth, bool isMaximizing)
    {
        CellState currentPlayer = isMaximizing ? CellState.O : CellState.X;

        if (board.IsWinner(CellState.X)) return -1;
        if (board.IsWinner(CellState.O)) return 1;
        if (board.IsBoardFull()) return 0;

        int bestScore = isMaximizing ? int.MinValue : int.MaxValue;

        foreach (var cell in board.GetEmptyCells())
        {
            // Simulate the move
            cell.State = currentPlayer;

            int score = MiniMax(board, depth + 1, !isMaximizing);

            // Reset the move
            cell.State = CellState.Empty;

            // Update the best score based on maximizing or minimizing player
            if (isMaximizing)
                bestScore = Math.Max(bestScore, score);
            else
                bestScore = Math.Min(bestScore, score);
        }

        return bestScore;
    }

    private IEnumerable<Cell> GetEmptyCells()
    {
        // Return a list of empty cells
        return // Implement logic to get empty cells
    }

    private bool IsBoardFull()
    {
        // Implement logic to check if the board is full
        return // Return true if the board is full
    }
}
*/
