public class Pigeon extends Bird implements Flyable, Dance{
    //FlyingBehaviour fb = new PSFB();
    FlyingBehaviour fb;

    public Pigeon(FlyingBehaviour fb)
    {
        this.fb = fb;
    }
    @Override
    public void eat() {

    }

    @Override
    public void dance() {

    }

    @Override
    public void fly() {
        fb.makeFly();
    }
}
