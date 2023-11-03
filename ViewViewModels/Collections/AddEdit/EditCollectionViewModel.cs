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

namespace MyFirstMobileApp.ViewViewModels.Collections.AddEdit
{
    public class EditCollectionViewModel : BaseViewModel
    {
        public ICommand UpdateBtnClicked { get; set; }
        private string _movieName = string.Empty;

        public EditCollectionViewModel()
        {
            Title = TitlesMisc.EditTitle;
            UpdateBtnClicked = new Command(PerformSave);
        }

        public string MovieName
        {
            get { return _movieName; }

            set
            {
                if (_movieName != value)
                    // Use the SetProperty method to update the private field _movies
                    // and trigger property change notifications when the Movies property value changes.
                    SetProperty(ref _movieName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_movieName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.EditTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            MadagascarMovies movies = new MadagascarMovies();
            movies.NameofMovie = _movieName;

            MessagingCenter.Send<MadagascarMovies>(movies, "UpdateMovies");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
