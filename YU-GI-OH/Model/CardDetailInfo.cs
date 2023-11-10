namespace YU_GI_OH.Model {

    public class ParentObj {
        public string status { get; set; }
        public CardDetail data { get; set; }
    }

    public class CardDetail {
        public string name { get; set; }
        public string text { get; set; }
        public string card_type { get; set; }
        public string type { get; set; }
        public string family { get; set; }
        public int? atk { get; set; }
        public int? def { get; set; }
        public int? level { get; set; }
        public object property { get; set; }
    }

}
