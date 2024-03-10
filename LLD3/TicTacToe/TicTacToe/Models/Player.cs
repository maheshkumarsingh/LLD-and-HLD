using System;
using System.Linq.Expressions;

namespace TicTacToe.Models
{
    public class Player
    {
        //private int _id;

        private string _name;

        private Symbol _symbol;

        private PlayerType _playerType;

        
        public Player(string name, Symbol symbol, PlayerType playerType)
        {
            this._name = name;
            this._symbol = symbol;
            this._playerType = playerType;
        }
        //public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        internal Symbol Symbol { get => _symbol; set => _symbol = value; }
        internal PlayerType PlayerType { get => _playerType; set => _playerType = value; }


        public virtual Move MakeMove(Board board)
        {
            Console.WriteLine("Please select (X,Y) coordinate to make move :)");
            int rowNumber = Convert.ToInt16(Console.ReadLine());
            int colNumber = Convert.ToInt16(Console.ReadLine());

            return new Move(this, new Cell(rowNumber, colNumber));
        }
    }
}