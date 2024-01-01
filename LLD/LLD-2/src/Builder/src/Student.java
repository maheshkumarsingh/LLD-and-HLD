package Builder.src;

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

    public class Builder {
        private String name;
        private String univName;
        private int age;
        private String phone;
        private double psp;

        public String getName() {
            return name;
        }

        public Builder.src.Builder setName(String name) {
            this.name = name;
            return this;
        }

        public String getUnivName() {
            return univName;
        }

        public Builder.src.Builder setUnivName(String univName) {
            this.univName = univName;
            return this;
        }

        public int getAge() {
            return age;
        }

        public Builder.src.Builder setAge(int age) {
            this.age = age;
            return this;
        }

        public String getPhone() {
            return phone;
        }

        public Builder.src.Builder setPhone(String phone) {
            this.phone = phone;
            return this;
        }

        public double getPsp() {
            return psp;
        }

        public Builder.src.Builder setPsp(double psp) {
            this.psp = psp;
            return this;
        }

        public Student build()
        {
            return new Student(this);
        }
    }

}
