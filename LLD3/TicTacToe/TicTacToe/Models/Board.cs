using System;
using System.Collections.Generic;

namespace TicTacToe.Models
{
    public class Board
    {
        private Cell[,] _board;
        private int _dimension;

        public Board(int dimension)
        {
            _dimension = dimension;
            _board = new Cell[_dimension,_dimension];
            for(int i=0;i< _dimension;i++)
            {
                for(int j=0;j< _dimension;j++)
                {
                    _board[i,j] = new Cell(i,j);
                }
            }

        }

        public int Dimension { get => _dimension; set => _dimension = value; }
        public Cell[,] Boards { get => _board; }


        /*
         *  --------------
            |   |   |   |
            --------------
            |   |   |   |
            --------------
            |   |   |   |
            --------------
        */
        public void DisplayBoard()
        {
            Console.Write("------------------\n");
            

            for(int i=0;i<_dimension;i++)
            {
                for(int j=0;j<_dimension;j++)
                {
                    Cell cell = _board[i,j];
                    if(cell.State.Equals(CellState.Empty))
                    {
                        Console.Write("|  |");
                    }
                    else
                    {
                        Console.Write("|" + cell.Player.Symbol + "|");
                    }
                }
                Console.Write("\n");
                Console.Write("------------------\n");
            }
            Console.Write("\n");
        }
    }
}