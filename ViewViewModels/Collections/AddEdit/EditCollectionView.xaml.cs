using MyFirstMobileApp.Models.Entities;

namespace MyFirstMobileApp.ViewViewModels.Collections.AddEdit;

public partial class EditCollectionView : ContentPage
{
	public EditCollectionView(MadagascarMovies madagascar)
	{
		InitializeComponent();
        BindingContext = new EditCollectionViewModel();
        MovieTitle.Text = madagascar.NameofMovie;
    }
}