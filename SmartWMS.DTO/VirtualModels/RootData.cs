using System.Text.Json.Serialization;
using SmartWMS.DTO.Models;

namespace SmartWMS.DTO.VirtualModels
{
    public class RootData<T>
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("data")]
        public List<T> Data { get; set; }
    }


}
