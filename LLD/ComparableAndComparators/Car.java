package LLD.ComparableAndComparators;

public class Car implements Comparable<Car>{

    private int speed;
    private int engineCapacity;

    public Car(int speed , int engineCapacity)
    {
        this.speed = speed;
        this.engineCapacity = engineCapacity;
    }

    public int getSpeed(){
        return this.speed;
    }
    public int getEngineCapacity(){
        return this.engineCapacity;
    }

    public void setSpeed(int speed)
    {
        this.speed = speed;
    }

    public void setEngineCapacity(int engineCapacity)
    {
        this.engineCapacity = engineCapacity;
    }
    @Override
    public int compareTo(Car o) {
       return (this.speed - o.getSpeed());
    }
    @Override
    public String toString()
    {
        return getClass().getName() + " "+   getSpeed() + " " + getEngineCapacity();
    }
}
