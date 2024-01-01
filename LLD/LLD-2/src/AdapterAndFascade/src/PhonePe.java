public class PhonePe {
    private BankAPIAdapter bankAPI;
    public PhonePe(BankAPIAdapter bankAPI) {
        this.bankAPI = bankAPI;
    }

    double doSomething() throws InterruptedException {
        double currentBalance = bankAPI.getBalance("20186471230");

        Thread.sleep(24*1000);

        return currentBalance * 2;
    }
}
