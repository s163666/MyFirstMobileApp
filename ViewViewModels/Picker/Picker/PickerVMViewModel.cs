﻿using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Picker;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModels.Picker.Picker;

public class PickerVMViewModel : BaseViewModel
{

    public ImageSource SubmitButton { get; set; } = Buttons.ButtonSubmit;


    //Property to bind the Picker Item Source 


    public List<string> CharacterList { get; set; }
    List<ActorCharacterInfo> _characters;
    string _selectedItem = string.Empty;


    public ICommand OnSubmitClicked { get; }


    public PickerVMViewModel()
    {
        //Set Title
        Title = TitlePicker.PickerVMTitle;


        //Get Characters from ActorCharacterInfo Class to Populate Picker
        this.GetCharacterList();


        //Set Submit Button Command
        OnSubmitClicked = new Command(OnSubmitClickedAsync);
    }

    private void GetCharacterList()
    {
        var allCharacterInfo = ActorCharacterInfo.GetSampleCharacterData();

        // Filter and map the character names from the list of ActorCharacterInfo objects
        CharacterList = allCharacterInfo.Select(info => info.CharacterName).ToList();
        _characters = allCharacterInfo;
    }

    public string SelectedCharacter
    {
        get { return _selectedItem; }
        set
        {
            if (_selectedItem != value)
                SetProperty(ref _selectedItem, value);
        }
    }

    private async void OnSubmitClickedAsync(object obj)
    {
        // Verify user made a selection
        if (String.IsNullOrEmpty(_selectedItem))
        {
            await Application.Current.MainPage.DisplayAlert(TitlePicker.PickerVMTitle, "A selection must be made!", "Ok");
            return;
        }

        //Get Selection
        var selectedCharacterName = _selectedItem;

        //Find the ActorCharacterInfo object based on the selected character name
        var selectedCharacterInfo = _characters.FirstOrDefault(info => info.CharacterName == selectedCharacterName);

        if (selectedCharacterInfo != null)
        {
            //Combining actor’s name and character’s name into a single string for display
            string name = $"{ selectedCharacterInfo.ActorName} As { selectedCharacterInfo.CharacterName}";

            //Use selectedCharacterInfo.ActorImage for the actor’s image
            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(name, selectedCharacterInfo.ActorImage));
        }
    }
}





