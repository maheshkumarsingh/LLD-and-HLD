public class DBConnection {
    
    private static DBConnection dbConnection;

    private DBConnection() { }
    //Here If T1 and T2 comes then T1 will take lock and make a connection. T1 releases the lock and T2 comes and sees that db is not null
    // so It will not be able to create object. This is also called double check.
    public static DBConnection createConnection()
    {
        if(dbConnection==null)
        {
            synchronized(DBConnection.class)
            {
                if(dbConnection==null)
                {
                    dbConnection = new DBConnection();
                }
            }
        }
        return dbConnection;
    }
}
