using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartWMS.DTO.VirtualModels
{
    /*
     {
       "offset": 0,
       "limit": 10,
       "fields": ["fullName", "email"],
       "sortBy": ["fullName", "-createdOn"],
       "data": {
         "_domain": "self.email like :email",
         "_domainContext": {
           "email": "%gmail.com"
         },
         "_archived": true
       }
     }
     */

    public class SearchRequest
    {
        [JsonPropertyName("offset")]
        public int? Offset { get; set; }

        [JsonPropertyName("limit")]
        public int? Limit { get; set; }

        [JsonPropertyName("fields")]
        public List<string> Fields { get; set; }

        [JsonPropertyName("sortBy")]
        public List<string> SortBy { get; set; }

        [JsonPropertyName("data")]
        public SearchData SearchData { get; set; }
    }

    //public class DomainContext
    //{
    //    [JsonPropertyName("email")]
    //    public string Email { get; set; }
    //}


}
