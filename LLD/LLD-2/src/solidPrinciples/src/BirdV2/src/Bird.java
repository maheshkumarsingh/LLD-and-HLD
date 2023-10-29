import java.util.Objects;
//Earlier Bird version was having issue that If we want to add a new bird make sound in make
// sound method we will have to modify existing code of make sound method
//Thats why we will make Bird as interface or abstract class so that whenever we need to add new bird we will extend or implement existing one
public abstract class Bird {
    private String type;
    private String name;

    private double weight;

    private String color;

    private int noOfWings;

    public Bird() { }
    public Bird(String type, String name, double weight, String color, int noOfWings) {
        this.type = type;
        this.name = name;
        this.weight = weight;
        this.color = color;
        this.noOfWings = noOfWings;
    }

    public abstract void fly();

    public abstract void makeSound();

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public int getNoOfWings() {
        return noOfWings;
    }

    public void setNoOfWings(int noOfWings) {
        this.noOfWings = noOfWings;
    }
}
