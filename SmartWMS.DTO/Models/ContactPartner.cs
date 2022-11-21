using System.Text.Json.Serialization;

namespace SmartWMS.DTO.Models
{
    public class ContactPartner
    {
        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("$version")]
        public int? Version { get; set; }
    }



}
