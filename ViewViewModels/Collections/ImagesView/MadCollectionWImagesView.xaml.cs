namespace MyFirstMobileApp.ViewViewModels.Collections.ImagesView;

public partial class MadCollectionWImagesView : ContentPage
{
	public MadCollectionWImagesView()
	{
		InitializeComponent();
        BindingContext = new MadCollectionWImagesViewModel();
    }
}