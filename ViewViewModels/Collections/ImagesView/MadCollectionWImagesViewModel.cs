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

namespace MyFirstMobileApp.ViewViewModels.Collections.ImagesView
{

    internal class MadCollectionWImagesViewModel : BaseViewModel
    {

        public ObservableCollection<CharacterInfo> MadagascarCollection { get; }

        private readonly List<CharacterInfo> _madagascar;

        public MadCollectionWImagesViewModel()
        {
            Title = TitleCollectionWImages.CollectionWImagesTitle;

            //Instantiate Obervable GuardiansCollection
            MadagascarCollection = new ObservableCollection<CharacterInfo>();
            _madagascar = CharacterInfo.GetSampleCharacterData();
            this.LoadMadagascar();
        }

        private void LoadMadagascar()
        {
            try
            {
                MadagascarCollection.Clear();
                foreach (var g in _madagascar)
                {
                    MadagascarCollection.Add(g);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }

}
