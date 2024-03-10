using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Strategies.WinningStrategies
{
    internal class ColWinningStrategy : IWinningStrategy
    {
        private Dictionary<int, Dictionary<Symbol, int>> colMaps = new Dictionary<int, Dictionary<Symbol, int>>();
        public bool CheckForWinner(Move move, Board board)
        {
            int col = move.Cell.Col;
            Symbol symbol = move.Player.Symbol;

            if(!colMaps.ContainsKey(col))
            {
                   colMaps.Add(col, new Dictionary<Symbol, int>());
            }

            Dictionary<Symbol, int> currentColMap = colMaps[col];

            if(currentColMap.ContainsKey(symbol))
            {
                currentColMap[symbol]++;
            }else
            {
                currentColMap.Add(symbol, 1);
            }
            return currentColMap[symbol] == board.Dimension;
        }
    }
}
