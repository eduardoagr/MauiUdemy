namespace YU_GI_OH.Model;

public class CardInfo {
    public string status { get; set; }
    public Data data { get; set; }
}

public class Data {
    public Card[] cards { get; set; }
}

public class Card {

    public long id { get; set; }

    public string name { get; set; }

    public long atk { get; set; }

    public long def { get; set; }

    public string description { get; set; }

    public string image_url => $"https://images.ygoprodeck.com/images/cards/{id}.jpg";

    public string image_url_small => $"https://images.ygoprodeck.com/images/cards_small/{id}.jpg";

    public byte[] imageBytes { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("frameType")]
    public string FrameType { get; set; }

    [JsonProperty("level")]
    public long Level { get; set; }

    [JsonProperty("race")]
    public string Race { get; set; }

    [JsonProperty("attribute")]
    public string Attribute { get; set; }

}