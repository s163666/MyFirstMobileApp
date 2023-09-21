using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.ViewViewModels.Main
{
    public class MainViewModel : BaseViewModel 

    {
        public String StackLayoutTitle { get; set; } = TitleMain.TitleStackLayout;
        public MainViewModel()
        {
            Title = TitleMain.appTitle;

        }
    }
}
