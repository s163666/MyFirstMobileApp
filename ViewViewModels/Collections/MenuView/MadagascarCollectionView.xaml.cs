namespace MyFirstMobileApp.ViewViewModels.Collections.MenuView;

public partial class MadagascarCollectionView : ContentPage
{
	public MadagascarCollectionView()
	{
		InitializeComponent();
        BindingContext = new MadagascarCollectionViewModel();
    }
}