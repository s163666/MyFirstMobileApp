namespace MyFirstMobileApp.ViewViewModels.Main;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
        //MainModel model = new MainModel();
        //model.Title = "Main View";
        //model.ButtonText = "Click Me";
        //DataContext = model;
    }
}