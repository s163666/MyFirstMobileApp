using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Picker;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModels.Picker.DatePicker
{
    public class DatePickerXAMLViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; } = Buttons.ButtonSubmit;

        public DatePickerXAMLViewModel()
        {
            Title = TitleDatePicker.DatePickerXAMLTitle;
        }
    }
}
