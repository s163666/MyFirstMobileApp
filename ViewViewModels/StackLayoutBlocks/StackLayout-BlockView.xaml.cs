namespace MyFirstMobileApp.ViewViewModels.StackLayoutBlocks;

public partial class StackLayout_BlockView : ContentPage
{
	public StackLayout_BlockView()
	{
		InitializeComponent();
		BindingContext = new StackLayoutBlocksViewModel();
	}
}