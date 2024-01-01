public class ChocoChips implements IceCreamConeConstituents{
    private IceCreamConeConstituents iceCreamConeConstituents;

    public ChocoChips(IceCreamConeConstituents iceCreamConeConstituents)
    {
        this.iceCreamConeConstituents = iceCreamConeConstituents;
    }

    @Override
    public int getCost() {
        return iceCreamConeConstituents.getCost() + 10;
    }

    @Override
    public String getDescription() {
        return iceCreamConeConstituents.getDescription() + " + Choco chips";
    }
}