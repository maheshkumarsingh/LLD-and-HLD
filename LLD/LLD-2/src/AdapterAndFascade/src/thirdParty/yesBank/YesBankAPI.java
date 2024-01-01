package thirdParty.yesBank;

public class YesBankAPI {
    private String balance;
    private String accountNumber;

    public YesBankAPI(String accountNumber)
    {
        this.accountNumber = accountNumber;
    }

    public String getBalance()
    {
        return "0.0";
    }
}
