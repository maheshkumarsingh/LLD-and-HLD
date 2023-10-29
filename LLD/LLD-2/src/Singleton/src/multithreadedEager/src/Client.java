public class Client {
    public static void main(String[] args) {
        DBConnection dbConnection1 = DBConnection.creaConnection();
        DBConnection dbConnection2 = DBConnection.creaConnection();
        dbConnection1.name = "Mahesh";
        dbConnection2.name = "Change";
        Student s1 = new Student("Mahesh1", 24);
        Student s2 = new Student("Mahesh2", 23);
    }
}
