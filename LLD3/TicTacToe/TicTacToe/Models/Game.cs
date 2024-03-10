using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Strategies.WinningStrategies;

namespace TicTacToe.Models
{
    public class Game
    {
        private List<Player> _players;

        private Board _board;

        private List<Move> _moves;

        private Player _winner;

        private GameStatus _gameStatus;

        private List<IWinningStrategy> _winningStrategies;

        private int _nextMovePlayerIndex;
        public List<Player> Players { get => _players; set => _players = value; }
        public Board Board { get => _board; set => _board = value; }
        public Player Winner { get => _winner; set => _winner = value; }
        public List<IWinningStrategy> WinningStrategies { get => _winningStrategies; set => _winningStrategies = value; }
        public GameStatus GameStatus { get => _gameStatus; set => _gameStatus = value; }
        public int NextMovePlayerIndex { get => _nextMovePlayerIndex; set => _nextMovePlayerIndex = value; }

        public static Builder GetBuilder()
        {
            return new Builder();
        }

        public class Builder
        {
            private int _dimension;

            private List<Player> _players;

            private List<IWinningStrategy> _winningStrategies;

            public Builder SetDimension(int dimension)
            {
                this._dimension = dimension;
                return this;
            }

            public Builder SetPlayers(List<Player> players)
            {
                this._players = players;
                return this;
            }

            public Builder SetWinningStretegies(List<IWinningStrategy> winningStrategies)
            {
                this._winningStrategies = winningStrategies;
                return this;
            }

            private bool Validate()
            {
                return true;
            }

            public Game Build()
            {
                if (!Validate())
                    throw new Exception("You are Idiot"); //TODO
                return new Game(_dimension, _players, _winningStrategies);
            }
        }

        private Game(int dimension, List<Player> players, List<IWinningStrategy> winningStrategies)
        {
            this._board = new Board(dimension);
            this._gameStatus = GameStatus.In_Progress;
            this._nextMovePlayerIndex = 0;

            this._moves = new List<Move>();

            this._winningStrategies = winningStrategies;
            this._players = players;
        }

        public void DisplayBoard()
        {
            _board.DisplayBoard();
        }

        public void Undo()
        {

        }

        private bool ValidateMove(Move move)
        {

            int row = move.Cell.Row;
            int col = move.Cell.Col;

            return row < _board.Dimension && row >= 0 && col < Board.Dimension && col >= 0 && _board.Boards[row, col].State.Equals(CellState.Empty);
        }
        private bool CheckWinner(Board board, Move move)
        {
            foreach (IWinningStrategy winningStrategy in _winningStrategies)
            {
                if (winningStrategy.CheckForWinner(move, board))
                    return true;
            }
            return false;
        }

        public void MakeMove()
        {
            Player currentPlayer = _players[_nextMovePlayerIndex];

            Console.WriteLine("It is " + currentPlayer.Name + "'s move");
            
            Move move = currentPlayer.MakeMove(this._board);

            Console.WriteLine(currentPlayer.Name + " has made a move at index row = " + move.Cell.Row + ", col = " + move.Cell.Col + ".");

            if (!ValidateMove(move))
            {
                Console.WriteLine("Invalid move by player: " + currentPlayer.Name);
            }

            int row = move.Cell.Row;
            int col = move.Cell.Col;

            Cell finalCellToMakeMove = _board.Boards[row, col];
            finalCellToMakeMove.State = CellState.Filled;
            finalCellToMakeMove.Player = currentPlayer;

            Move finalMove = new Move(currentPlayer, finalCellToMakeMove);
            _moves.Add(finalMove);

            _nextMovePlayerIndex += 1;
            _nextMovePlayerIndex %= _players.Count;

            if (CheckWinner(_board, finalMove))
            {
                _gameStatus = GameStatus.Ended;
                _winner = currentPlayer;
            }
            else if (_moves.Count == _board.Dimension * _board.Dimension)
            {
                _gameStatus = GameStatus.Draw;
            }
        }
    }
}
