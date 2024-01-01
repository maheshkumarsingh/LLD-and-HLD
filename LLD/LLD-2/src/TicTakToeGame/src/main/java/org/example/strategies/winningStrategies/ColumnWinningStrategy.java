package org.example.strategies.winningStrategies;

import org.example.models.Board;
import org.example.models.Move;
import org.example.models.Symbol;

import java.util.HashMap;
import java.util.Map;

public class ColumnWinningStrategy implements WinningStrategy{
    private Map<Integer, Map<Symbol, Integer>> colMaps = new HashMap<>(); //Map for every col, which symbol is at what
    // columns
    @Override
    public boolean checkWinner(Move move, Board board) {
        int col = move.getCell().getCol();
        Symbol symbol = move.getPlayer().getSymbol();

        //Logic

        if(!colMaps.containsKey(col)) //symbol comes in any new row initialization
        {
            colMaps.put(col, new HashMap<>());
        }
        Map<Symbol, Integer> currentRowMap = colMaps.get(col);

        if(currentRowMap.containsKey(symbol))
        {
            currentRowMap.put(symbol, currentRowMap.get(symbol) + 1);
        }
        else {
            currentRowMap.put(symbol, 1);
        }

        return currentRowMap.get(symbol) == board.getSize();
    }
}
