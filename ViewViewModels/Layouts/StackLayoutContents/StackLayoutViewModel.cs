using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewViewModels.Layouts.AbsoluteLayoutContents;
using MyFirstMobileApp.ViewViewModels.Layouts.FlexLayoutContents;
using MyFirstMobileApp.ViewViewModels.Layouts.HorizontalStackContents;
using MyFirstMobileApp.ViewViewModels.Layouts.StackLayoutBlocks;
using MyFirstMobileApp.ViewViewModels.Layouts.VerticalStackContents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Layouts.StackLayoutContents;
public class StackLayoutViewModel : ContentView
{
    //This is the ViewModel

    //References the data from TitleLayouts
    public string TitleStackLayout { get; set; } = TitleLayout.StackLayoutTitle;
    public string TitleVerticalStack { get; set; } = TitleLayout.VerticalStackTitle;
    public string TitleHorizontalStack { get; set; } = TitleLayout.HorizontalStackTitle;
    public string TitleAbsolutestack { get; set; } = TitleLayout.AbsoluteLayoutTitle;
    public string TitleFlexStack { get; set; } = TitleLayout.FlexLayoutTitle;

    //public string Layouts { get; set; }

    public ICommand OnLayoutsClicked { get; set; }
    public ICommand OnVerticalClicked { get; set; }
    public ICommand OnHorizontalClicked { get; set; }
    public ICommand OnAbsoluteClicked { get; set; }
    public ICommand OnFlexClicked { get; set; }

    public StackLayoutViewModel()
    {
        //Set Commands
        OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        OnVerticalClicked = new Command(OnVerticalClickedAsync);
        OnHorizontalClicked = new Command(OnHorizontalClickedAsync);
        OnAbsoluteClicked = new Command(OnAbsoluteClickedAsync);
        OnFlexClicked = new Command(OnFlexClickedAsync);
    }

    private async void OnLayoutsClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayout_BlockView());
    }

    private async void OnVerticalClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new VerticalStackView());
    }

    private async void OnHorizontalClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new HorizontalStackView());
    }

    private async void OnAbsoluteClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutView());
    }

    private async void OnFlexClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new FlexLayoutView());
    }
}
