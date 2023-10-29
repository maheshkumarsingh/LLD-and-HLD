public class Student {
    private String name;
    private String univName;
    private int age;
    private String phone;
    private double psp;

    public Student(Builder builder)
    {
        //starts validations
        if(builder.getAge() > 100)
            throw new IllegalArgumentException("this age is greater than 100");

        this.name = builder.getName();
        this.univName = builder.getUnivName();
        this.age = builder.getAge();
        this.phone= builder.getPhone();
        this.psp = builder.getPsp();
    }


    public String getName() {
        return name;
    }

    public String getUnivName() {
        return univName;
    }

    public int getAge() {
        return age;
    }

    public String getPhone() {
        return phone;
    }

    public double getPsp() {
        return psp;
    }
    
    public static Builder getBuilder()
    {
        return new Builder();
    }
}
