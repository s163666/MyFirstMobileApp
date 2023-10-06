using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewViewModels.StackLayoutBlocks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.StackLayoutContents;

public class StackLayoutViewModel : ContentView
{
    //This is the ViewModel

    //References the data from TitleLayouts
    public String BtnStackLayout { get; set; } = TitleLayout.StackLayoutTitle;
    public String BtnVerticalStack { get; set; } = TitleLayout.VerticalStackTitle;
    public String BtnHorizontalStack { get; set; } = TitleLayout.HorizontalStackTitle;
    public String BtnAbsoluteLayout { get; set; } = TitleLayout.AbsoluteLayoutTitle;

    public string Layouts { get; set; }

    public ICommand OnLayoutsClicked { get; set; }


    public StackLayoutViewModel()
    {
        //Set Commands
        OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
    }

    private async void OnLayoutsClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayout_BlockView());
    }
}