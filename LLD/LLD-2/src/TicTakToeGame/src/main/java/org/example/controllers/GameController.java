package org.example.controllers;

import org.example.models.Game;
import org.example.models.GameStatus;
import org.example.models.Player;
import org.example.strategies.winningStrategies.WinningStrategy;

import java.util.List;

public class GameController {
    public Game startGame(int boardSize, List<Player> players, List<WinningStrategy> winningStrategies) throws Exception {
        return Game.getBuilder()
                        .setDimension(boardSize)
                        .setPlayers(players)
                        .setWinningStrategies(winningStrategies)
                        .build();

    }

    public void makeMoves(Game game)
    {
        game.makeMove(game.getBoard());
    }

    public void displayBoard(Game game)
    {
        game.printBoard();
    }

    public Player checkWinner(Game game)
    {
        return game.getWinner();
    }

    public void undo(Game game)
    {
        game.undo();
    }

    public GameStatus getGameStatus(Game game)
    {
        return game.getGameStatus();
    }
}
