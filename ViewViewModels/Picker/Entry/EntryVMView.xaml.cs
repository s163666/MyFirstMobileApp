namespace MyFirstMobileApp.ViewViewModels.Picker.Entry;

public partial class EntryVMView : ContentPage
{
    public EntryVMView()
    {
        InitializeComponent();
        BindingContext = new EntryVMViewModel();
    }
}
