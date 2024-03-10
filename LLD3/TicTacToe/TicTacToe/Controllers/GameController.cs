using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;
using TicTacToe.Strategies.WinningStrategies;

namespace TicTacToe.Controllers
{
    internal class GameController
    {
        public Game StartGame(int dimension, List<Player> players, List<IWinningStrategy> winning)
        {

            return Game.GetBuilder()
                            .SetDimension(dimension)
                            .SetPlayers(players)
                            .SetWinningStretegies(winning)
                            .Build();
        }

        public void MakeMove(Game game)
        {
            game.MakeMove();
        }

        public void DisplayBoard(Game game)
        {
            game.DisplayBoard();
        }

        public Player GetWinner(Game game)
        {
            return game.Winner;
        }

        public void Undo(Game game)
        {
            game.Undo();
        }
        public GameStatus GetStatus(Game game)
        {
            return game.GameStatus;
        }
    }
}
