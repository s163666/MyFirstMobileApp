using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.NewFolder
{
    internal class StackLayoutBlocks
    {
        public String StackLayoutTitle { get; set; } = TitleMain.TitleStackLayout;
        public String Button01Title { get; set; } = TitleMain.TitleButton01;
        public String Button10Title { get; set; } = TitleMain.TitleButton10;
        public String Button11Title { get; set; } = TitleMain.TitleButton11;

        public string Layouts { get; set; }

        public ICommand OnLayoutsClicked { get; set; }


        public MainViewModel()
        {
            Title = TitleMain.appTitle;

            //Set Commands
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }

        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutContents.StackLayoutView());
        }
    }
}
