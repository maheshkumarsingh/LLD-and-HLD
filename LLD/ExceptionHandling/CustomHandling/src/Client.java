public class Client {
    public static void main(String[] args) throws FileNameIsWrongException{
        CustomFileReader customFileReader = new CustomFileReader();
        CustomFileReader.readFile("text.txt");
    }
}
