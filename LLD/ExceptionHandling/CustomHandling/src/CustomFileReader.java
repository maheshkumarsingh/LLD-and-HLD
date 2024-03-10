public class CustomFileReader {
    public static void readFile(String filePath) throws FileNameIsWrongException
    {
        System.out.println("Custom Reading files");
        System.out.println("File actions");
        if(!isFileFound(filePath))
        {
            throw new FileNameIsWrongException("File nama is not found");
        }
    }

    public static boolean isFileFound(String filePath)
    {
        return false;
    }
}
