using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Strategies.WinningStrategies
{
    public interface IWinningStrategy
    {
        bool CheckForWinner(Move move, Board board);
    }
}
