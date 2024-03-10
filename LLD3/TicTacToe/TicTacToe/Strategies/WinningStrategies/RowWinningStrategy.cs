using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Strategies.WinningStrategies
{
    internal class RowWinningStrategy : IWinningStrategy
    {
        private Dictionary<int, Dictionary<Symbol, int>> rowMap = new Dictionary<int, Dictionary<Symbol, int>>();
        public bool CheckForWinner(Move move, Board board)
        {
            int row = move.Cell.Row;
            Symbol symbol = move.Player.Symbol;

            if(!rowMap.ContainsKey(row))
            {
                rowMap.Add(row, new Dictionary<Symbol, int>());
            }

            Dictionary<Symbol, int> currentRowMap = rowMap[row];
            
            if(!currentRowMap.ContainsKey(symbol))
            {
                currentRowMap.Add(symbol, 1);
            }
            else
            {
                currentRowMap[symbol]++;
            }

            return currentRowMap[symbol] == board.Dimension;
        }
    }
}
