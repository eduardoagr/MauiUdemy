namespace YU_GI_OH.Model {
    public partial class CardDetail {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }
    }

    public partial class Datum {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("atk")]
        public long Atk { get; set; }

        [JsonProperty("def")]
        public long Def { get; set; }

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
}