public class TA extends User{
    public static void main(String[] args) {
        TA ta = new TA();
        changePassword(ta);
        System.out.println(ta.password);
    }
}
