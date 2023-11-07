using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.Models.Entities
{
    public class MadagascarMovies
    {

        public string NameofMovie { get; set; }

        //ImageButtons - Used for UpdatableCollections
        public ImageSource EditButton { get; } = Buttons.ButtonEdit;
        public ImageSource DeleteButton { get; } = Buttons.ButtonDelete;


        public MadagascarMovies() { }

        public MadagascarMovies(string name)
        {
            NameofMovie = name;
        }

        //Used for Collections
        public static List<MadagascarMovies> GetMovies()
        {
            return new List<MadagascarMovies>
            {
                new MadagascarMovies("Madagascar"),
                new MadagascarMovies("Madagascar: Escape 2 Africa"),
                new MadagascarMovies("Madagascar 3: Europe's Most Wanted"),
                new MadagascarMovies("Madly Madagascar"),
                new MadagascarMovies("Penguins of Madagascar"),
                new MadagascarMovies("Madagascar 4")
            };
        }

    }

}
