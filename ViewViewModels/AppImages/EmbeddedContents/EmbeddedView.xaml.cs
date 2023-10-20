namespace MyFirstMobileApp.ViewViewModels.AppImages.EmbeddedContents;

public partial class EmbeddedView : ContentPage
{
	public EmbeddedView()
	{
		InitializeComponent();
		BindingContext = new EmbeddedViewModel();
	}
}