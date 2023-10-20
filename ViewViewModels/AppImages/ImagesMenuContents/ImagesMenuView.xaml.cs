namespace MyFirstMobileApp.ViewViewModels.AppImages.ImagesMenuContents;

public partial class ImagesMenuView : ContentPage
{
	public ImagesMenuView()
	{
		InitializeComponent();
		BindingContext = new ImagesMenuViewModel();
	}
}