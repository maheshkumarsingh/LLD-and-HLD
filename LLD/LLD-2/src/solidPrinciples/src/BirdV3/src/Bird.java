import java.util.List;

public abstract class Bird {
    private String type;
    private String name;
    private int weight;

    public Bird() {}
    public Bird(String type, String name, int weight) {
        this.type = type;
        this.name = name;
        this.weight = weight;
    }


    //more attributes

    public abstract void eat();
}
