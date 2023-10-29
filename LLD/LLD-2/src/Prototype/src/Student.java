public class Student implements Prototype<Student>{
    private String name;
    private int age;

    private double psp;

    private double averageBatchPSP;

    private String batch;

    private String internalState = "success";

    public Student() { };
    public Student(Student student)
    {
        this.name = student.name;
        this.age  = student.age;
        this.psp  = student.psp;
        this.averageBatchPSP = student.averageBatchPSP;
        this.batch = student.batch;
        this.internalState = student.internalState;
    }
    @Override
    public Student clone() {
        return new Student(this);
    }
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public double getPsp() {
        return psp;
    }

    public void setPsp(double psp) {
        this.psp = psp;
    }

    public double getAverageBatchPSP() {
        return averageBatchPSP;
    }

    public void setAverageBatchPSP(double averageBatchPSP) {
        this.averageBatchPSP = averageBatchPSP;
    }

    public String getBatch() {
        return batch;
    }

    public void setBatch(String batch) {
        this.batch = batch;
    }

}
