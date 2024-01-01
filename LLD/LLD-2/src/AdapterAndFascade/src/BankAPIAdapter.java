public interface BankAPIAdapter {

    double getBalance(String accountNumber);

    boolean sendMoney(String fromAccount, String toAccount, double amount, String notes);

    boolean receiveMoney(String toAccount, String fromAccount, double amount, String notes);
}
