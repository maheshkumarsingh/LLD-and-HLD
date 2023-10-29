public class DBConnection {
    private static DBConnection dbConnection = new DBConnection();
    public String name;
    private DBConnection() { }
    //One object is already created and why my remaining threads should wait. thats why we should use synchronized
    public synchronized static DBConnection creaConnection()
    {
        return dbConnection;
    }
}
