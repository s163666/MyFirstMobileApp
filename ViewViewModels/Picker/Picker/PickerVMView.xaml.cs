namespace MyFirstMobileApp.ViewViewModels.Picker.Picker;

public partial class PickerVMView : ContentPage
{
	public PickerVMView()
	{
		InitializeComponent();
        BindingContext = new PickerVMViewModel();
    }
}