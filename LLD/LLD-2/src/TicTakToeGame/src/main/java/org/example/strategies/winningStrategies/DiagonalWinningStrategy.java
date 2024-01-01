package org.example.strategies.winningStrategies;

import org.example.models.Board;
import org.example.models.Move;
import org.example.models.Symbol;

import java.util.HashMap;
import java.util.Map;

public class DiagonalWinningStrategy implements WinningStrategy{
    private Map<Symbol, Integer> leftDiagonalMap = new HashMap<>();
    private Map<Symbol, Integer> rightDiagonalMap = new HashMap<>();

    @Override
    public boolean checkWinner(Move move, Board board) {
        int row = move.getCell().getRow();
        int col = move.getCell().getCol();

        Symbol symbol = move.getPlayer().getSymbol();
        if(row == col)
        {
            //cell is present on left diagonal
            if(leftDiagonalMap.containsKey(symbol))
            {
                leftDiagonalMap.put(symbol,leftDiagonalMap.get(symbol) + 1);
            }
            else
            {
                leftDiagonalMap.put(symbol, 1);
            }
        }
        if(row + col == board.getSize() -1)
        {
            if(rightDiagonalMap.containsKey(symbol))
            {
                rightDiagonalMap.put(symbol, rightDiagonalMap.get(symbol) + 1);
            }
            else
            {
                rightDiagonalMap.put(symbol, 1);
            }
        }

        if(row == col && leftDiagonalMap.get(symbol) == board.getSize())
            return true;
        if(row + col == board.getSize() - 1 && rightDiagonalMap.get(symbol) == board.getSize())
            return true;
        return false;
    }
}
