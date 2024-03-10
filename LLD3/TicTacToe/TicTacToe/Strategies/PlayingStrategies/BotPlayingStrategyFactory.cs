using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Strategies.PlayingStrategies
{
    internal class BotPlayingStrategyFactory
    {
        public static IBotPlayingStrategy GetBotPlayingStrategy(BotDifficultyLevel difficultyLevel)
        {
            
            switch(difficultyLevel)
            {
                case BotDifficultyLevel.Easy:
                    return new EasyBotPlayingStrategy();
                case BotDifficultyLevel.Medium:
                    return new MediumBotPlayingStrategy();
                case BotDifficultyLevel.Hard:
                    return new HardBotPlayingStrategy();
                default:
                    return null;
            }
        }
    }
}
