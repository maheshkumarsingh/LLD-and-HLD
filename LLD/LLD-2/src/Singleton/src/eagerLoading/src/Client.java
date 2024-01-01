package eagerLoading.src;

import eagerLoading.DBConnection;

public class Client {
    public static void main(String[] args) {
        DBConnection connection = DBConnection.getDBInstance();
        DBConnection connection2 = DBConnection.getDBInstance();
    }
}
