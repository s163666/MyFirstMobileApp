using MyFirstMobileApp.Models;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Collections.MenuView
{

    public class MadagascarCollectionViewModel : BaseViewModel
    {
        // ViewModel: Private fields
        private readonly List<MadagascarMovies> _madagascarmovies;

        // ViewModel: Observable collection bound to the View
        // We use ObservableCollection to automatically update the View when the collection changes.
        public ObservableCollection<MadagascarMovies> MadagascarMoviesCollection { get; }

        public MadagascarCollectionViewModel()
        {
            // ViewModel: Setting the page title for the View
            Title = TitleMadagascarMoviesCollection.MadagascarMoviesTitle;

            // ViewModel: Initialize the ObservableCollection
            MadagascarMoviesCollection = new ObservableCollection<MadagascarMovies>();

            _madagascarmovies = MadagascarMovies.GetMovies();
            this.LoadMovies();
        }

        // ViewModel: Load movies into the ObservableCollection
        private void LoadMovies()
        {
            try
            {
                // Clear the collection in the ViewModel
                MadagascarMoviesCollection.Clear();

                // Loop through all the movies in the ViewModel collection
                foreach (var p in _madagascarmovies)
                {
                    // Add the NameofMovie property of the individual movie to the ViewModel collection
                    MadagascarMoviesCollection.Add(new MadagascarMovies { NameofMovie = p.NameofMovie });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }

}
