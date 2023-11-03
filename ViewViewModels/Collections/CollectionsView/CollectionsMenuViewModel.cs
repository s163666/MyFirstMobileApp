using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.Collections.CollectionsUpdatable;
using MyFirstMobileApp.ViewViewModels.Collections.ImagesView;
using MyFirstMobileApp.ViewViewModels.Collections.MenuView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Collections.CollectionsView
{
    public class CollectionsMenuViewModel : BaseViewModel
    {
        //Button Commands
        public ICommand OnCollectionViewClicked { get; set; }
        public ICommand OnCollectionWImagesViewClicked { get; set; }
        public ICommand OnCollectionViewButtonsClicked { get; set; }
        public ICommand OnCollectionViewIconClicked { get; set; }

        public CollectionsMenuViewModel()
        {
            Title = TitleCollectionMenu.CollectionTitle;

            //Set Commmands
            OnCollectionViewClicked = new Command(OnCollectionViewClickedAsync);
            OnCollectionWImagesViewClicked = new Command(OnCollectionWImagesViewClickedAsync);
            OnCollectionViewButtonsClicked = new Command(OnCollectionViewButtonsClickedAsync);
            OnCollectionViewIconClicked = new Command(OnCollectionViewIconClickedAsync);
        }

        private async void OnCollectionViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MadagascarCollectionView());
        }

        private async void OnCollectionWImagesViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MadCollectionWImagesView());
        }

        private async void OnCollectionViewButtonsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UpdatableCollectionWButtonsView());
        }

        private async void OnCollectionViewIconClickedAsync(object obj)
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new UpdatableCollectionWIconsView());
        }
    }
}
