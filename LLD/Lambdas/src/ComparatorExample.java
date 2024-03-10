package LLD.Lambdas.src;

import java.util.Comparator;

public class ComparatorExample {
    public static void main(String[] args) {

        Comparator<String> comparator = (String s1, String s2) ->{
            return s1.length() - s2.length();
        };
        
        Comparator<String> comparatorShort  = (s1, s2) -> s1.length() - s2.length();
        
        System.out.println(comparatorShort.compare("Mahesh", "Singhhhhhhhhh"));
    }
}
