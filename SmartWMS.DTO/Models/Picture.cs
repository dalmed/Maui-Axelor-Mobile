using System.Text.Json.Serialization;

namespace SmartWMS.DTO.Models
{
    public class Picture
    {
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("$version")]
        public int? Version { get; set; }
    }



}
