package org.example.models;

import org.example.exceptions.GameInvalidException;
import org.example.strategies.winningStrategies.WinningStrategy;

import java.util.ArrayList;
import java.util.List;

public class Game {
    private Board board;
    List<Player> players;

    private GameStatus gameStatus;

    private Player winner;

    private int nextMovePlayerIndex;  //which player is having next turn

    private List<Move> moves;

    private List<WinningStrategy> winningStrategies;

    //private because of builder dp
    //Builder --> HW

    public static Builder getBuilder()
    {
        return new Builder();
    }
    private Game(int dimension, List<Player> players, List<WinningStrategy> winningStrategies) {
        this.board = new Board(dimension);
        this.gameStatus = GameStatus.IN_PROGRESS;
        this.nextMovePlayerIndex =0;
        this.moves = new ArrayList<>();
        this.winningStrategies = winningStrategies;
        this.players = players;
    }

    //Builder inner class
    public static class Builder
    {
        private int dimension;
        private List<Player> players;
        private List<WinningStrategy> winningStrategies;

        private Builder()
        {
            this.players = new ArrayList<>();
            this.winningStrategies = new ArrayList<>();
            this.dimension =0;
        }

        public Builder setDimension(int dimension) {
            this.dimension = dimension;
            return this;
        }

        public Builder setPlayers(List<Player> players) {
            this.players = players;
            return this;
        }

        public Builder setWinningStrategies(List<WinningStrategy> winningStrategies) {
            this.winningStrategies = winningStrategies;
            return this;
        }

        private static boolean validate()
        {
            //Validations
            //1. Only one Bot is allowed per game.
            //2. NO 2 players should have the same symbol
            return true;
        }
        public Game build() throws Exception {
            if(!validate())
                throw new Exception();
            return new Game(this.dimension, this.players, this.winningStrategies);
        }
    }

    public Board getBoard() {
        return board;
    }

    public void setBoard(Board board) {
        this.board = board;
    }

    public List<Player> getPlayers() {
        return players;
    }

    public void setPlayers(List<Player> players) {
        this.players = players;
    }

    public GameStatus getGameStatus() {
        return gameStatus;
    }

    public void setGameStatus(GameStatus gameStatus) {
        this.gameStatus = gameStatus;
    }

    public Player getWinner() {
        return winner;
    }

    public void setWinner(Player winner) {
        this.winner = winner;
    }

    public int getNextMovePlayerIndex() {
        return nextMovePlayerIndex;
    }

    public void setNextMovePlayerIndex(int nextMovePlayerIndex) {
        this.nextMovePlayerIndex = nextMovePlayerIndex;
    }

    public List<Move> getMoves() {
        return moves;
    }

    public void setMoves(List<Move> moves) {
        this.moves = moves;
    }

    public void printBoard()
    {
        board.printBoard();
    }

    public void undo()
    {

    }
    private boolean validateMove(Move move)
    {
        int row = move.getCell().getRow();
        int col = move.getCell().getCol();

/*
        if(row >= board.getSize() || row <0 || col >= getBoard().getSize() || col < 0
        || !board.getBoard().get(row).get(col).getCellState().equals(CellState.EMPTY))
        {
            return false;
        }
        return true;
*/

        return row < board.getSize() && row >= 0 && col < getBoard().getSize() && col >= 0
                && board.getBoard().get(row).get(col).getCellState().equals(CellState.EMPTY);
    }
    public void makeMove(Board board)
    {
        //Current Player to make the move
        Player currentPlayer = players.get(nextMovePlayerIndex);

        System.out.println("It is "+ currentPlayer.getName()+"'s move");

        Move move = currentPlayer.makeMove(this.board);

        System.out.println(currentPlayer.getName() + "has a made a move at Row: "+ move.getCell().getRow()
        + "and at Column: "+ move.getCell().getCol()+" .");

        //Validate the move before we apply the move on board.
        if(!validateMove(move))
        {
            System.out.println("Invalid move by player: " + currentPlayer.getName());
            return;
        }
        int row = move.getCell().getRow();
        int col = move.getCell().getCol();

        Cell finalCell = board.getBoard().get(row).get(col);
        finalCell.setCellState(CellState.FILLED);
        finalCell.setPlayer(currentPlayer);

        Move finalMove = new Move(finalCell, currentPlayer); //valid move some moves might not be valid
        moves.add(move);

        nextMovePlayerIndex +=1;
        nextMovePlayerIndex %= players.size();

        //Once player has made a move, check the winner
        //checkWinner

        if(checkWinner(board, finalMove))
        {
            gameStatus = GameStatus.ENDED;
            winner = currentPlayer;
        } else if(moves.size() == board.getSize() * board.getSize())
        {
            gameStatus = GameStatus.DRAW;
        }
    }
    private boolean checkWinner(Board board, Move move)
    {
        for(WinningStrategy winningStrategy : winningStrategies)
        {
            if(winningStrategy.checkWinner(move , board))
            {
                return true;
            }
        }
        return false;
    }
}
