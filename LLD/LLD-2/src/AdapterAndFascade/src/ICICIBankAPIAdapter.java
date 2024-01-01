import thirdParty.icici.ICICIBankAPI;

public class ICICIBankAPIAdapter implements BankAPIAdapter{
    private ICICIBankAPI iciciBankAPI;
    @Override
    public double getBalance(String accountNumber) {
        double balance = Double.parseDouble(iciciBankAPI.getBalance());
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
