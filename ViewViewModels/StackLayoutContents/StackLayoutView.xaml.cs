namespace MyFirstMobileApp.ViewViewModels.StackLayoutContents;

public partial class StackLayoutView : ContentPage
{
	public StackLayoutView()
	{
		//Add binding and create StackLayoutView page 
		InitializeComponent();
		BindingContext = new StackLayoutViewModel();
	}
}