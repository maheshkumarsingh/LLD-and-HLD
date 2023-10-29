public class Sparrow extends Bird{

    public Sparrow() { }

    public Sparrow(String type, String name, double weight,
                   String color, int noOfWings) {
        super(type, name, weight, color, noOfWings);
    }

    @Override
    public void fly() {

    }

    @Override
    public void makeSound() {
        System.out.println("Sparrow is making sound");
    }
}
