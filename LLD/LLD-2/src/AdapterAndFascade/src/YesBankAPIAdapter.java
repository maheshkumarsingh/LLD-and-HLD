import thirdParty.yesBank.YesBankAPI;

public class YesBankAPIAdapter implements BankAPIAdapter{

    private YesBankAPI yesBankAPI;
    @Override
    public double getBalance(String accountNumber) {
        double balance = Double.parseDouble(yesBankAPI.getBalance());
        return balance;
    }

    @Override
    public boolean sendMoney(String fromAccount, String toAccount, double amount, String notes) {
        return false;
    }

    @Override
    public boolean receiveMoney(String toAccount, String fromAccount, double amount, String notes) {
        return false;
    }
}
