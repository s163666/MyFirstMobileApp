namespace MyFirstMobileApp.ViewViewModels.Collections.AddEdit;

public partial class AddCollectionView : ContentPage
{
	public AddCollectionView()
	{
		InitializeComponent();
        BindingContext = new AddCollectionViewModel();
    }
}