namespace YU_GI_OH.Model;

public class Rootobject {
    public string status { get; set; }
    public Data data { get; set; }
}

public class Data {
    public Card[] cards { get; set; }
}

public class Card {
    public string name { get; set; }
    public string card_type { get; set; }
    public string property { get; set; }
    public string family { get; set; }
    public string type { get; set; }
    public string cardImageUrl { get; set; }

    public byte[] ImageBytes { get; set; }
}