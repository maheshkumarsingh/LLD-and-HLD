public class OrangeCone implements IceCreamConeConstituents{

    private IceCreamConeConstituents iceCreamConeConstituents;

    public OrangeCone() { }  // base cone of ice cream

    public OrangeCone(IceCreamConeConstituents iceCreamConeConstituents)
    {
        this.iceCreamConeConstituents = iceCreamConeConstituents;
    }
    @Override
    public int getCost() {
        return 30;
    }

    @Override
    public String getDescription() {
        return "Orange Cone";
    }
}
