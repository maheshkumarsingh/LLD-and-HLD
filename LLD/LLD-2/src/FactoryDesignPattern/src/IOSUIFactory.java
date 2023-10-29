import components.buttons.Button;
import components.buttons.IOSButton;
import components.dropdowns.DropDown;
import components.dropdowns.IOSDropDown;
import components.menus.IOSMenu;
import components.menus.Menu;

public class IOSUIFactory implements UIFactory{
    @Override
    public IOSButton createButton() {
        return new IOSButton();
    }

    @Override
    public IOSMenu createMenu() {
        return new IOSMenu();
    }

    @Override
    public IOSDropDown createDropDown() {
        return new IOSDropDown();
    }
}
