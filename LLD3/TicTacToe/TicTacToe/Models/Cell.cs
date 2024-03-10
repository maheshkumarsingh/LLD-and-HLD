using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Cell
    {
        private int _row;
        private int _col;
        private CellState _state;
        private Player _player;


        public Cell(int row, int col)
        {
            this._row = row;
            this._col = col;
            this._state = CellState.Empty;
        }

        public int Row { get => _row; set => _row = value; }
        public int Col { get => _col; set => _col = value; }
        public CellState State { get => _state; set => _state = value; }
        public Player Player { get => _player; set => _player = value; }
    }
}
