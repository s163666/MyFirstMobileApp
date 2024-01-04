using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{

    public class Buttons
    {
        //Edit,  Delete & Submit
        public static ImageSource ButtonEdit { get; } = ImageSource.FromFile("Resources/Images/ImageButtons/iconsedit.png");
        public static ImageSource ButtonDelete { get; } = ImageSource.FromFile("Resources/Images/ImageButtons/iconsdelete.png");
        public static ImageSource ButtonSubmit { get; } = ImageSource.FromFile("Resources/Images/ImageButtons/buttonsubmit.png");

        //DatePicker
        public static ImageSource ButtonDatePickerBlue { get; } = ImageSource.FromFile("Resources/Images/ImageButtons/dpbuttonblue.png");
        public static ImageSource ButtonDatePickerRed { get; } = ImageSource.FromFile("Resources/Images/ImageButtons/dpbuttonred.png");

        //Picker
        public static ImageSource ButtonPickerBlue { get; } = ImageSource.FromFile("Resources/Images/ImageButtons/buttonblue.png");
        public static ImageSource ButtonPickerRed { get; } = ImageSource.FromFile("Resources/Images/ImageButtons/buttonred.png");
    }

}
