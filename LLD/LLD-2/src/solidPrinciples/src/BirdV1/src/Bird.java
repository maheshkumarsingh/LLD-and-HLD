import java.util.Objects;

public class Bird {
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

    public void fly()
    {

    }

    public void makeSound()
    {
        if(Objects.equals(this.type, "SPARROW"))
        {
            System.out.println("Make Sound like a sparrow");
        }
        else if(Objects.equals(this.type, "CROW"))
        {
            System.out.println("Make sound like a crow");
        }
        else
        {
            System.out.println("Not a bird");
        }
    }

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
