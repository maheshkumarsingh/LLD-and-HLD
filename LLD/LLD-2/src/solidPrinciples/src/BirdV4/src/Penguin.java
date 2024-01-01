public class Penguin extends Bird implements Dance {
    @Override
    public void eat() {
        System.out.println("Penguin is eating");
    }

    @Override
    public void dance() {
        System.out.println("Penguin can dance");
    }
}