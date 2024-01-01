package solidPrinciples.src.BirdV1.src;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Client {
    public static void main(String[] args) {
       Bird b1 = new Bird("SPARROW","LittleSparrow",2.89,"Yellow",2);
       b1.makeSound();
       Bird b2 = new Bird("CROW", "CROW1",3.09,"Black",2);
       b2.makeSound();
       System.out.println("Wait here");
    }
}