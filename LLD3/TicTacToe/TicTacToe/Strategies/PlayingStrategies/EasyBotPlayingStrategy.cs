using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Strategies.PlayingStrategies
{
    public class EasyBotPlayingStrategy : IBotPlayingStrategy
    {
        public Move MakeMove(Board board)
        {
            //In easy bot playing strategy bot will move in a first empty cell.
            for (int i = 0;i<board.Dimension;i++)
            {
                for(int j=0;j<board.Dimension;j++)
                {
                    Cell cell = board.Boards[i,j];
                    if(cell.State.Equals(CellState.Empty))
                    {
                        return new Move(null, cell);
                    }
                }
            }
            return null;
        }
    }
}
