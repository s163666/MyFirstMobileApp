using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Title = TitlesPicker.PickerResultsTitle;


        //Get Characters from ActorCharacterInfo Class to Populate Picker
        this.GetCharacterList();


        //Set Submit Button Command
        OnSubmitClicked = new Command(OnSubmitClickedAsync);
    }

    private void GetCharacterList()
    {
        var allCharacterInfo = ActorCharacterInfo.GetSampleCharacterData();

        //Filter and map the character names from the list of ActorCharacterInfo objects
        CharacterList = allCharacterInfo.Select(info=>info.CharacterName).ToList();
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
}

