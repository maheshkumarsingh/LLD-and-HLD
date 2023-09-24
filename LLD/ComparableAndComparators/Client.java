package LLD.ComparableAndComparators;

import java.io.IOException;
import java.util.Comparator;
import java.util.PriorityQueue;

public class Client {
    public static void main(String[] args) throws IOException {
        
        System.out.print("\033[H\033[2J");  
        System.out.flush();
        Car car1 = new Car(50,100);
        Car car2 = new Car(100,100);

        System.out.println(car1.compareTo(car2));
        
        
        // PriorityQueue<Car> priorityQueue = new PriorityQueue<>();
        //PriorityQueue priorityQueue = new PriorityQueue<>(new CarComparator());
        PriorityQueue priorityQueue = new PriorityQueue<>(new Comparator<Car>() {
            @Override
            public int compare(Car o1, Car o2){
            return o1.getEngineCapacity() - o2.getEngineCapacity();
            }
        });
        priorityQueue.add(new Car(100, 50));
        priorityQueue.add(new Car(50, 74));
        priorityQueue.add(new Car(75, 100));

        

        while(!priorityQueue.isEmpty())
        {
            System.out.println(priorityQueue.poll().toString());
        }
    }
}
