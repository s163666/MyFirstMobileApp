using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Layouts.StackLayoutContents;
using MyFirstMobileApp.ViewViewModels.AppImages.ImagesMenuContents;
using System.Windows.Input;
using MyFirstMobileApp.ViewViewModels.Collections.CollectionsView;

namespace MyFirstMobileApp.ViewViewModels.Main;
public class MainViewModel : BaseViewModel
{

    public String StackLayoutTitle { get; set; } = TitleMain.TitleStackLayout;
    public String ImagesTitle { get; set; } = TitleMain.TitlImages;
    public String CollectionsTitle { get; set; } = TitleMain.TitleCollections;
    public String ControlsTitle { get; set; } = TitleMain.TitleControls;
    public String SQLLiteTitle { get; set; } = TitleMain.TitleSQLLite;


    public string Layouts { get; set; }

    public ICommand OnLayoutsClicked { get; set; }
    public ICommand OnImagesClicked { get; set; }
    public ICommand OnCollectionsClicked { get; set; }


    public MainViewModel()
    {
        Title = TitleMain.appTitle;

        //Set Commands
        OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        OnImagesClicked = new Command(OnImagesClickedAsync);
        OnCollectionsClicked = new Command(OnCollectionsClickedAsync);
    }

    private async void OnLayoutsClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
    }
    private async void OnImagesClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ImagesMenuView());
    }
    private async void OnCollectionsClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CollectionsMenuView());
    }

}
