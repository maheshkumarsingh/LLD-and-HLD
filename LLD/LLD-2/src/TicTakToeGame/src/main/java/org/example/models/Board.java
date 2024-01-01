package org.example.models;

import java.util.ArrayList;
import java.util.List;

public class Board {
    private int size;

    private List<List<Cell>> board;

    Board(int dimension)
    {
        //Initialize a board of size n

        this.size = dimension;
        board = new ArrayList<>(); // addind rows
        for(int i=0;i<size;i++)
        {
            board.add(new ArrayList<>());// adding columns
            for(int j=0;j<size;j++)
            {
                board.get(i).add(new Cell(i,j)); //adding cells for column
            }
        }
    }

    public void printBoard()
    {
        for(int i=0;i<size;i++)
        {
            for(int j=0;j<size;j++)
            {
                Cell cell = board.get(i).get(j);
                if(cell.getCellState().equals(CellState.EMPTY))
                    System.out.print("|  |");
                else
                    System.out.print("| " +cell.getPlayer().getSymbol().getSymbol() + " |");
            }
            System.out.println();
        }
    }

    public int getSize() {
        return size;
    }

    public void setSize(int size) {
        this.size = size;
    }

    public List<List<Cell>> getBoard() {
        return board;
    }

    public void setBoard(List<List<Cell>> board) {
        this.board = board;
    }
}
