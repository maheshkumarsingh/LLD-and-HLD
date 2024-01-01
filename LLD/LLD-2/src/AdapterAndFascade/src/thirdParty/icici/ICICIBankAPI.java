package thirdParty.icici;

public class ICICIBankAPI {

    private String balance;
    private String accountNumber;

    public ICICIBankAPI(String accountNumber)
    {
        this.accountNumber = accountNumber;
    }

    public String getBalance()
    {
        return "0.0";
    }
}
