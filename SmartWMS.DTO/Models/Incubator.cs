using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartWMS.DTO.Models
{
    public class Incubator
    {
        [JsonPropertyName("hatchery")]
        public Hatchery Hatchery { get; set; }

        [JsonPropertyName("statusDate")]
        public object StatusDate { get; set; }

        [JsonPropertyName("note")]
        public object Note { get; set; }

        [JsonPropertyName("processInstanceId")]
        public object ProcessInstanceId { get; set; }

        [JsonPropertyName("importOrigin")]
        public object ImportOrigin { get; set; }

        [JsonPropertyName("updatedBy")]
        public User UpdatedBy { get; set; }

        [JsonPropertyName("statusColor")]
        public string StatusColor { get; set; }

        [JsonPropertyName("updatedOn")]
        public DateTime? UpdatedOn { get; set; }

        [JsonPropertyName("createdOn")]
        public DateTime? CreatedOn { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("attrs")]
        public object Attrs { get; set; }

        [JsonPropertyName("$wkfStatus")]
        public object WkfStatus { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("importId")]
        public object ImportId { get; set; }

        [JsonPropertyName("strTrolleysList")]
        public string StrTrolleysList { get; set; }

        [JsonPropertyName("createdBy")]
        public User CreatedBy { get; set; }

        [JsonPropertyName("trolleysList")]
        public List<object> TrolleysList { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("exitDate")]
        public DateTime? ExitDate { get; set; }

        [JsonPropertyName("selected")]
        public bool Selected { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }
    }
}