namespace MyFirstMobileApp.ViewViewModels.Picker.Entry;

public partial class EntryResultsView : ContentPage
{


    public EntryResultsView(string entryText)
    {
        InitializeComponent();
        BindingContext = new EntryResultsViewModel(entryText);
    }

}

