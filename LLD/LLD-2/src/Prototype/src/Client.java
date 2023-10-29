public class Client {

    public static void fillStudentRegistry(StudentRegistry studentRegistry)
    {
        Student apr22Prototype = new Student();

        apr22Prototype.setAverageBatchPSP(89.0);
        apr22Prototype.setBatch("apr22Prototype");

        studentRegistry.register("apr22Batch", apr22Prototype);

        IntelligentStudent sep22Prototype = new IntelligentStudent();
        sep22Prototype.setAverageBatchPSP(98.0);
        sep22Prototype.setBatch("Intelligent sep 22");
        sep22Prototype.setIq(180);

        studentRegistry.register("sep22IntelligentStudentBatch", sep22Prototype);

    }

    public static void main(String[] args) {


        StudentRegistry studentRegistry = new StudentRegistry();
        fillStudentRegistry(studentRegistry);

        Student nishita = studentRegistry.get("apr22Batch").clone();
        nishita.setName("Nishita");
        nishita.setAge(24);
        nishita.setPsp(91.0);

        Student mahesh = studentRegistry.get("sep22IntelligentStudentBatch").clone();
        mahesh.setName("Mahesh");
        mahesh.setAge(25);
        mahesh.setPsp(25.0);

        //prototype cannot have name and psp because general dummmy cannot have all this
//        Student apr22Prototype = new Student();
//
//        apr22Prototype.setAverageBatchPSP(89.0);
//        apr22Prototype.setBatch("apr22Prototype");
//
//        Student payal = apr22Prototype.clone();
//        payal.setName("Payal");
//        payal.setAge(21);
//        payal.setPsp(90.0);
//
//        Student sep22Prototype = new Student();
//        sep22Prototype.setAverageBatchPSP(89.0);
//        sep22Prototype.setBatch("sep22Prototype");
//
//        Student amit = sep22Prototype.clone();
//        amit.setName("Amit");
//        amit.setAge(22);
//        amit.setPsp(98.0);
//
//        Student mahesh = apr22Prototype.clone();
//        mahesh.setName("Mahesh");
//        mahesh.setAge(24);
//        mahesh.setPsp(80.0);

        System.out.println("DEBUG");
    }
}
