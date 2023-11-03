namespace MyFirstMobileApp.Models.Entities
{
    public class CharacterInfo
    {
        //Properties - Initialized to an Empty String
        public string ActorName { get; set; } = string.Empty;
        public ImageSource ActorImage { get; set; } = null;
        public string CharacterName { get; set; } = string.Empty;

        public CharacterInfo()
        {
            //Constructor
        }

        public CharacterInfo(string actorName, ImageSource actorImage, string characterName)
        {
            //Constructor with Parameters
            ActorName = actorName;
            ActorImage = actorImage;
            CharacterName = characterName;
        }

        ///<summary>
        /// Retrieves a list of sample character data, each representing an actor's name, an image URL, and the character they portray.
        ///</summary>
        ///<returns>A list of ActorCharacterInfo objects containing sample data.</returns>
        public static List<CharacterInfo> GetSampleCharacterData()
        {
            var actors = new List<CharacterInfo>
            {
                // Create ActorCharacterInfo objects with sample data
                new CharacterInfo("David Schwimmer", ImageSource.FromFile("Images/MAD/melvin.jpg"), "Melvin"),
                new CharacterInfo("Sacha Baron Cohen", ImageSource.FromFile("Images/MAD/kingJulien.jpg"), "King Julien"),
                new CharacterInfo("Chris Rock", ImageSource.FromFile("Images/MAD/marty.jpg"), "Marty"),
                new CharacterInfo("Ben Stiller", ImageSource.FromFile("Images/MAD/alex.jpg"), "Alex"),
                new CharacterInfo("Jada Pinkett Smith", ImageSource.FromFile("Images/MAD/gloria.jpg"), "Gloria")
            };

            return actors;
        }

        ///<summary>
        ///Retrieves a list of character names from the sample character data.
        ///</summary>
        ///<returns>A list of character names extracted from the sample data.</returns>
        public static List<string> GetCharacterNames()
        {
            // Get the sample character data
            var sampleData = GetSampleCharacterData();

            // Select and convert character names to a list
            return sampleData.Select(info => info.CharacterName).ToList();
        }
    }
}
