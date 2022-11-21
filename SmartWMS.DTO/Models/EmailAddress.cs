using System.Text.Json.Serialization;

namespace SmartWMS.DTO.Models
{
    public class EmailAddress
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("$version")]
        public int? Version { get; set; }
    }



}
