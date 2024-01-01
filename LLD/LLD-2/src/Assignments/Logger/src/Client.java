import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class Client {
    public static void main(String[] args){
        String filepath = "C:\\Users\\2100227\\OneDrive - Cognizant\\Desktop\\MyPersonal\\Scaler\\LLD\\LLD-2\\src\\Assignments\\Logger\\text.txt";
        PrintWriter writer = null;
        FileWriter fileWriter = null;
        try
        {
            fileWriter = new FileWriter(filepath);
            writer = new PrintWriter(fileWriter);
        }catch(IOException exception){
            exception.printStackTrace();
        }

        LocalDateTime localDateTime = LocalDateTime.now();
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss");
        String formattedTimeStamp = localDateTime.format(formatter);

        writer.println(" Mahesh Singh");
        System.out.println("Debug");

    }
}
