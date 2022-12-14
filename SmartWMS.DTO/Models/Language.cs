using System.Text.Json.Serialization;

namespace SmartWMS.DTO.Models
{
    public class Language
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("$version")]
        public int? Version { get; set; }
    }



}
