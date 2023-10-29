import components.buttons.Button;
import components.dropdowns.DropDown;
import components.menus.Menu;

// Abstract Factory
public interface UIFactory {  //DBFactory
    public Button createButton();

    public Menu createMenu();

    public DropDown createDropDown();


}
