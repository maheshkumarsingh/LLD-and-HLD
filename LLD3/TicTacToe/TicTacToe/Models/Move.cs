namespace TicTacToe.Models
{
    public class Move
    {
        private Player _player;
        private Cell _cell;


        public Move(Player player, Cell cell)
        {
            this._player = player;
            this._cell = cell;
        }
        public Player Player { get => _player; set => _player = value; }
        public Cell Cell { get => _cell; set => _cell = value; }
    }
}