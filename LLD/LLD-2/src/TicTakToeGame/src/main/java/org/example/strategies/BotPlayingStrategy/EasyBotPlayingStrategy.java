package org.example.strategies.BotPlayingStrategy;

import org.example.models.Board;
import org.example.models.Cell;
import org.example.models.CellState;
import org.example.models.Move;

import java.util.List;

public class EasyBotPlayingStrategy implements BotPlayingStrategy{
    @Override
    public Move makeMove(Board board) {
        //In easy bot playing strategy we will make move in first available cell

        for(List<Cell> row : board.getBoard())
        {
            for(Cell cell : row)
            {
                if(cell.getCellState().equals(CellState.EMPTY))
                {
                    //Bot can make a move in this cell
                    return new Move(cell, null);
                }
            }
        }
        return null;
    }
}
