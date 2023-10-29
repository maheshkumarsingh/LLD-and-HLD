public class Builder {
    private String name;
    private String univName;
    private int age;
    private String phone;
    private double psp;

    public String getName() {
        return name;
    }

    public Builder setName(String name) {
        this.name = name;
        return this;
    }

    public String getUnivName() {
        return univName;
    }

    public Builder setUnivName(String univName) {
        this.univName = univName;
        return this;
    }

    public int getAge() {
        return age;
    }

    public Builder setAge(int age) {
        this.age = age;
        return this;
    }

    public String getPhone() {
        return phone;
    }

    public Builder setPhone(String phone) {
        this.phone = phone;
        return this;
    }

    public double getPsp() {
        return psp;
    }

    public Builder setPsp(double psp) {
        this.psp = psp;
        return this;
    }

    public Student build()
    {
        return new Student(this);
    }
}
