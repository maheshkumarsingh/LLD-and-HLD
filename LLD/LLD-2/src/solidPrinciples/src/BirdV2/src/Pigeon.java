public class Pigeon extends Bird{

    public Pigeon() { }

    public Pigeon(String type, String name,
                  double weight, String color,
                  int noOfWings) {
        super(type, name, weight, color, noOfWings);
    }


    @Override
    public void fly() {

    }

    @Override
    public void makeSound() {
        System.out.println("Pigeon is making sound77094549");
    }
}
