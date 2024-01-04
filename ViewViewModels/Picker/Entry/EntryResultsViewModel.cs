using MyFirstMobileApp.Models.Picker;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Picker.Entry;

public class EntryResultsViewModel : BaseViewModel
{


    private String _entryText;


    public EntryResultsViewModel(string entryText)
    {
        Title = TitleEntry.EntryResultTitle;
        _entryText = entryText;
    }


    public string EntryText
    {

        get
        {
            return _entryText;
        }


        set
        {
            if (_entryText != value)
            {
                SetProperty(ref _entryText, value);
            }
        }

    }

}

