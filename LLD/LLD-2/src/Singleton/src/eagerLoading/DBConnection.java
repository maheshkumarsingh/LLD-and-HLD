package eagerLoading;

public class DBConnection {
    private static DBConnection instance = new DBConnection();

    public static DBConnection getDBInstance()
    {
        return instance;
    }
    
}
