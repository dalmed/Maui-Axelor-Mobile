using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartWMS.DTO.Models
{

    public class Hatchery
    {
        [JsonPropertyName("numberOfIncubationDays")]
        public int NumberOfIncubationDays { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("importOrigin")]
        public string ImportOrigin { get; set; }

        [JsonPropertyName("numberOfIncubationHours")]
        public int NumberOfIncubationHours { get; set; }

        [JsonPropertyName("numberOfHatchingDays")]
        public int NumberOfHatchingDays { get; set; }

        [JsonPropertyName("numberOfHoursOfHatching")]
        public int NumberOfHoursOfHatching { get; set; }

        [JsonPropertyName("hatcherCleaningTime")]
        public int HatcherCleaningTime { get; set; }

        [JsonPropertyName("numberOfHatchers")]
        public int NumberOfHatchers { get; set; }

        [JsonPropertyName("capacityOfATrolleyInTrays")]
        public int CapacityOfATrolleyInTrays { get; set; }

        [JsonPropertyName("capacityOfAnEggBasket")]
        public int CapacityOfAnEggBasket { get; set; }

        [JsonPropertyName("createdOn")]
        public DateTime? CreatedOn { get; set; }

        [JsonPropertyName("numberOfHatchersPerIncubator")]
        public int NumberOfHatchersPerIncubator { get; set; }

        [JsonPropertyName("numberOfIncubators")]
        public int NumberOfIncubators { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("packagingProduct")]
        public object PackagingProduct { get; set; }

        [JsonPropertyName("incubatorCapacityInTrolleys")]
        public int IncubatorCapacityInTrolleys { get; set; }

        [JsonPropertyName("selected")]
        public bool Selected { get; set; }

        [JsonPropertyName("processInstanceId")]
        public object ProcessInstanceId { get; set; }

        [JsonPropertyName("capacityOfTheHatcherInTrolleys")]
        public int CapacityOfTheHatcherInTrolleys { get; set; }

        [JsonPropertyName("updatedBy")]
        public User UpdatedBy { get; set; }

        [JsonPropertyName("capacityOfACartInBaskets")]
        public int CapacityOfACartInBaskets { get; set; }

        [JsonPropertyName("updatedOn")]
        public DateTime? UpdatedOn { get; set; }

        [JsonPropertyName("incubatorCleaningTime")]
        public int IncubatorCleaningTime { get; set; }

        [JsonPropertyName("sameCapacityOfTrolleys")]
        public bool SameCapacityOfTrolleys { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("attrs")]
        public object Attrs { get; set; }

        [JsonPropertyName("$wkfStatus")]
        public object WkfStatus { get; set; }

        [JsonPropertyName("unit")]
        public Unit Unit { get; set; }

        [JsonPropertyName("importId")]
        public object ImportId { get; set; }

        [JsonPropertyName("numberOfIncubatorTrolleys")]
        public int NumberOfIncubatorTrolleys { get; set; }

        [JsonPropertyName("hatcheryRef")]
        public string HatcheryRef { get; set; }

        [JsonPropertyName("createdBy")]
        public User CreatedBy { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("capacityOfAnEggTray")]
        public int CapacityOfAnEggTray { get; set; }

        [JsonPropertyName("numberOfHatcherTrolleys")]
        public int NumberOfHatcherTrolleys { get; set; }
    }


}
