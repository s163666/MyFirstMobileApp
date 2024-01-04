namespace MyFirstMobileApp.ViewViewModels.Collections.CollectionsUpdatable;

public partial class UpdatableCollectionWIconsView : ContentPage
{
	public UpdatableCollectionWIconsView()
	{
        InitializeComponent();
        BindingContext = new UpdateableCollectionViewModel();
    }
}
