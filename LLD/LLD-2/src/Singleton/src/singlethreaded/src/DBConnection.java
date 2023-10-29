public class DBConnection {

    private static DBConnection dbConnection;

    //why static??
    //below we will create a method that will be static and static method can have only static attributes/properties.

    private DBConnection(){ }  // constructor is private because we dont multiple objects. We cant stop anyone calling someone constructor.

    //why this static -> see we want to create ONLY one object if any object is not created. So this is static as we will not have to create
    //any object before creating any object.
    public static DBConnection creaConnection()
    {
        if(dbConnection == null)
            dbConnection = new DBConnection();
        return dbConnection;
    }
    //Is this code singleton -> this code is singleton because It will always create single object. It will keep in wait if more than
    //one thread comes.
}
