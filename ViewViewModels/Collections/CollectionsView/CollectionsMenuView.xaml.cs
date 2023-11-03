namespace MyFirstMobileApp.ViewViewModels.Collections.CollectionsView;

public partial class CollectionsMenuView : ContentPage
{
	public CollectionsMenuView()
	{
		InitializeComponent();
        BindingContext = new CollectionsMenuViewModel();
    }
}