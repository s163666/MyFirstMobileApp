using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Collections.AddEdit;

public partial class AddCollectionView : ContentPage
{
    public class AddCollectionViewModel : BaseViewModel
    {
        public ICommand SaveBtnClicked { get; set; }
        private string _movieName = string.Empty;

        public AddCollectionViewModel()
        {
            Title = TitlesMisc.AddTitle;
            SaveBtnClicked = new Command(PerformSave);
        }

        public string MovieName
        {
            get { return _movieName; }

            set
            {
                if (_movieName != value)
                    SetProperty(ref _movieName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_movieName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.AddTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            MadagascarMovies movies = new MadagascarMovies();
            movies.NameofMovie = _movieName;

            MessagingCenter.Send<MadagascarMovies>(movies, "AddMovies");

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.Navigation.PopAsync();
            }
        }
    }
}