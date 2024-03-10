using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Strategies.PlayingStrategies; 

namespace TicTacToe.Models
{
    public class Bot : Player
    {
        private BotDifficultyLevel _botDifficultyLevel;
        private IBotPlayingStrategy _botPlayingStrategy;

        public Bot(string name, Symbol symbol, PlayerType playerType, BotDifficultyLevel botDifficultyLevel) : base(name, symbol, playerType)
        {
            _botDifficultyLevel = botDifficultyLevel;
            _botPlayingStrategy = BotPlayingStrategyFactory.GetBotPlayingStrategy(botDifficultyLevel);
        }

        public IBotPlayingStrategy BotPlayingStrategy { get => _botPlayingStrategy; set => _botPlayingStrategy = value; }
        internal BotDifficultyLevel BotDifficultyLevel { get => _botDifficultyLevel; set => _botDifficultyLevel = value; }


        public override Move MakeMove(Board board)
        {
            Move move = _botPlayingStrategy.MakeMove(board);
            move.Player = this;
            return move;
        }


    }
}
