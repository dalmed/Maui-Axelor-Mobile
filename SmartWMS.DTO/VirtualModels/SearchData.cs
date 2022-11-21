using System.Text.Json.Serialization;

namespace SmartWMS.DTO.VirtualModels
{
    public class SearchData
    {
        [JsonPropertyName("_domain")]
        public string Domain { get; set; }

        [JsonPropertyName("_domainContext")]
        public Dictionary<string, string> DomainContext { get; set; }

        [JsonPropertyName("_archived")]
        public bool? Archived { get; set; }
    }

    //public class DomainContext
    //{
    //    [JsonPropertyName("email")]
    //    public string Email { get; set; }
    //}


}
