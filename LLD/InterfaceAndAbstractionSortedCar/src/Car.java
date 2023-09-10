import java.util.ArrayList;

public class Car implements Comparable<Car>{
    public int Price;
    public int Speed;
    
    public Car(){

    }

    public Car(int Price, int Speed)
    {
        this.Price = Price;
        this.Speed = Speed;
    }
    @Override
    public int compareTo(Car other) {
        return this.Price - other.Price;
    }

}
