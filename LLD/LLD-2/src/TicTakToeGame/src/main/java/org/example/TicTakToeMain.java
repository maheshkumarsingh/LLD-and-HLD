package org.example;

import org.example.controllers.GameController;
import org.example.models.*;
import org.example.strategies.BotPlayingStrategy.EasyBotPlayingStrategy;
import org.example.strategies.winningStrategies.ColumnWinningStrategy;
import org.example.strategies.winningStrategies.DiagonalWinningStrategy;
import org.example.strategies.winningStrategies.RowWinningStrategy;
import org.example.strategies.winningStrategies.WinningStrategy;

import java.sql.SQLOutput;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class TicTakToeMain {
    public static void main(String[] args) throws Exception {
        System.out.println("Hello Mahesh!!!!");

        GameController gameController = new GameController();
        Scanner scanner = new Scanner(System.in);
        int size = 3;

        int numberOfPlayers = size - 1;
        List<Player> players = new ArrayList<>();

        players.add(new Player("Mahesh", new Symbol('X'), PlayerType.HUMAN, 1L));
        players.add(new Bot("BotPlayer", new Symbol('0'), PlayerType.BOT, 2L,BotDifficultyLevel.EASY, new EasyBotPlayingStrategy()));

        List<WinningStrategy> winningStrategies = new ArrayList<>();
        winningStrategies.add(new RowWinningStrategy());
        winningStrategies.add(new ColumnWinningStrategy());
        winningStrategies.add(new DiagonalWinningStrategy());

        //Start the game
        Game game = gameController.startGame(size, players, winningStrategies);

        //start playing the game
        while(gameController.getGameStatus(game).equals(GameStatus.IN_PROGRESS))
        {
            //Display the board
            System.out.println("This is the board: ");
            gameController.displayBoard(game);
            //Do you want to undo? If, yes call the UNDO functionality
            gameController.makeMoves(game);
        }

        //checkWinner

        if(gameController.getGameStatus(game).equals(GameStatus.ENDED))
        {
            gameController.makeMoves(game);
            System.out.println("Winner is : "+ gameController.checkWinner(game).getName());
        }
        else
        {
            System.out.println("Game has DRAWN");
        }
    }
}