using SmartWMS.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartWMS.DTO.VirtualModels
{
    public class WmsQuery
    {
        public WmsQuery()
        {

        }
        public OperatorsModel Operator { get; set; }

        public int ObjectIdFilter { get; set; }
        public string ObjectCodeFilter { get; set; }
        public DateTime DateFilter { get; set; }


        public int ObjectIdFilter1 { get; set; }
        public string ObjectCodeFilter1 { get; set; }
        public DateTime DateFilter1 { get; set; }

        public int ObjectIdFilter2 { get; set; }
        public string ObjectCodeFilter2 { get; set; }
        public DateTime DateFilter2 { get; set; }

        public int ObjectIdFilter3 { get; set; }
        public string ObjectCodeFilter3 { get; set; }
        public DateTime DateFilter3 { get; set; }

        public int ObjectIdFilter4 { get; set; }
        public string ObjectCodeFilter4 { get; set; }
        public DateTime DateFilter4 { get; set; }

        public string JsonObject { get; set; }

        //
        // Summary:
        //     Gets or sets the filter.
        //
        // Value:
        //     The filter.
        public string Filter { get; set; }

        //
        // Summary:
        //     Gets or sets the filter parameters.
        //
        // Value:
        //     The filter parameters.
        public object[] FilterParameters { get; set; }

        //
        // Summary:
        //     Gets or sets the order by.
        //
        // Value:
        //     The order by.
        public string OrderBy { get; set; }

        //
        // Summary:
        //     Gets or sets the expand.
        //
        // Value:
        //     The expand.
        public string Expand { get; set; }

        //
        // Summary:
        //     Gets or sets the select.
        //
        // Value:
        //     The select.
        public string Select { get; set; }

        //
        // Summary:
        //     Gets or sets the skip.
        //
        // Value:
        //     The skip.
        public int? Skip { get; set; }

        //
        // Summary:
        //     Gets or sets the top.
        //
        // Value:
        //     The top.
        public int? Top { get; set; }

        //
        // Summary:
        //     Converts the query to OData query format.
        //
        // Parameters:
        //   url:
        //     The URL.
        //
        // Returns:
        //     System.String.
    }
}
