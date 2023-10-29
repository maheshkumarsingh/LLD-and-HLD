public class Sparrow extends Bird implements Flyable, Dance{


    public Sparrow() {
    }

    public Sparrow(String type, String name, int weight)
    {
        super(type, name, weight);
    }
    @Override
    public void eat() {
        System.out.println("Sparrow eats");
    }

    @Override
    public void dance() {
        System.out.println("Sparrow Dance");
    }

    @Override
    public void fly() {
        System.out.println("Sparrow fly");
    }
}
