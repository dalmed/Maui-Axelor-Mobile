using System.Text.Json.Serialization;

namespace SmartWMS.DTO.Models
{
    public class SupplierCatalog
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("$version")]
        public int? Version { get; set; }
    }



}
