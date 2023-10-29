// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Client {
    public static void main(String[] args) {
        IceCreamConeConstituents iceCreamConeConstituents =
                new ChocoChips(
                        new VanillaScoop(
                                new StrawberryScoop(
                                    new ChocolateCone(
                                        new ChocolateCone(
                                                new OrangeCone()
                                        )
                                    )
                                )
                        )
                );

        OrangeCone orangeCone = new OrangeCone();
        ChocolateCone chocolateCone = new ChocolateCone(orangeCone);
        ChocolateCone chocolateCone1 = new ChocolateCone(chocolateCone);
        StrawberryScoop strawberryScoop = new StrawberryScoop(chocolateCone1);
        VanillaScoop vanillaScoop = new VanillaScoop(strawberryScoop);
        ChocoChips chocoChips = new ChocoChips(vanillaScoop);


        System.out.println(iceCreamConeConstituents.getDescription());
        System.out.println(iceCreamConeConstituents.getCost());
    }
}