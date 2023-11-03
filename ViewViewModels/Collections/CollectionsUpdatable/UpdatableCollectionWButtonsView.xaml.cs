namespace MyFirstMobileApp.ViewViewModels.Collections.CollectionsUpdatable;

public partial class UpdatableCollectionWButtonsView : ContentPage
{
    public UpdatableCollectionWButtonsView()
    {
        InitializeComponent();
        BindingContext = new UpdateableCollectionViewModel();
    }
}