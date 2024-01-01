public class Sparrow extends Bird implements Flyable, Dance {
    @Override
    public void eat() {
        System.out.println("Sparrow is eating");
    }

    @Override
    public void dance() {
        System.out.println("Sparrow can dance");
    }

    @Override
    public void fly() {
        System.out.println("Sparrow can fly");
    }
}
