using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Strategies.PlayingStrategies
{
    public interface IBotPlayingStrategy
    {
        Move MakeMove(Board board);
    }
}
