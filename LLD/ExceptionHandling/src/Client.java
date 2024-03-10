import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class Client {
    public static void main(String[] args){
        readFile("E:\\ProductBasedCompany\\Scaler\\ScalerLearning\\LLD\\ExceptionHandling\\src\\text.txt");
    }

    public static void readFile (String filePath){
        System.out.println("I am Mahesh and I am learning Exception Handling");
        String test = null;
        try {
            File file = new File(test);
            FileReader fileReader = new FileReader(file);
            int i;
            while((i=fileReader.read())!=-1)
                System.out.print((char)i);
            fileReader.close();

            System.out.println("\nIf errors occurred this will not get printed");
        }
        catch(NullPointerException ex)
        {
            System.out.println(ex.getCause());
        }
        catch (Exception ex)
        {
            System.out.println(ex.getCause());
        }
        finally
        {
            System.out.println("This will be printed anyway");
        }
    }
}
