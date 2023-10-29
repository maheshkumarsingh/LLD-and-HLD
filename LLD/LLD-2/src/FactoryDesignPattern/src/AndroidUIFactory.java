import components.buttons.AndroidButton;
import components.buttons.Button;
import components.dropdowns.AndroidDropDown;
import components.dropdowns.DropDown;
import components.menus.AndroidMenu;
import components.menus.Menu;

public class AndroidUIFactory implements UIFactory{
    @Override
    public AndroidButton createButton() {
        return  new AndroidButton();
    }

    @Override
    public AndroidMenu createMenu() {
        return new AndroidMenu();
    }

    @Override
    public AndroidDropDown createDropDown() {
        return new AndroidDropDown();
    }
}
