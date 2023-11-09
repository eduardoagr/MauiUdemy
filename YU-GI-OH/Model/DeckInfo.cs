namespace YU_GI_OH.Model {
    public class DeckInfo {

        public string deckName { get; set; }

        public string imageURL => $"http://yugiohprices.com/api/set_image/{deckName}";
    }
}
