namespace MyFirstMobileApp.ViewViewModels.InteractiveControls.ControlsMenu;

public partial class ControlsMenuView : ContentPage
{
	public ControlsMenuView()
	{
		InitializeComponent();
        BindingContext = new ControlsMenuViewModel();
    }
}