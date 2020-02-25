using Newtonsoft.Json;

namespace International_Web_Form.Models
{
    public class DocumentLink
    {
        public Method Method { get; set; }

        public string Type { get; set; }

        [JsonProperty("rel")]
        public DocumentRelationship Relationship { get; set; }

        public string Reference { get; set; }
    }
}