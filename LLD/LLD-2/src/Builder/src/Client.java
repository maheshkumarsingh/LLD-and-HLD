package Builder.src;

public class Client {

    public static void main(String[] args) {
         Builder builder1 = new Builder();
         Builder builder = Student.getBuilder();
         builder.setName("Mahesh");
         builder.setAge(20);

         Student student = new Student(builder);
         System.out.println("Reach here");

        Student student2 = builder.build();
        Student studentNew = Student.getBuilder()
                                    .setName("Mahesh")
                                    .setAge(13)
                                    .setUnivName("DYP")
                                    .build();
        System.out.println("Reach here");
        StringBuilder stringBuilder = new StringBuilder();

    }
}
