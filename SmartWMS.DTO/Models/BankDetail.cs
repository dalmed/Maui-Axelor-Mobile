using System.Text.Json.Serialization;

namespace SmartWMS.DTO.Models
{
    public class BankDetail
    {
        [JsonPropertyName("code")]
        public object Code { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("$version")]
        public int? Version { get; set; }
    }



}
