using MyFirstMobileApp.Models;

namespace MyFirstMobileApp.ViewViewModels.StackLayoutContents;

public class StackLayoutViewModel : ContentView
{
    //This is the ViewModel

    //References the data from TitleLayouts
    public String BtnStackLayout { get; set; } = TitleLayout.StackLayoutTitle;
    public String BtnVerticalStack { get; set; } = TitleLayout.VerticalStackTitle;
    public String BtnHorizontalStack { get; set; } = TitleLayout.HorizontalStackTitle;
    public String BtnAbsoluteLayout { get; set; } = TitleLayout.AbsoluteLayoutTitle;

    public StackLayoutViewModel()
	{
    }
}