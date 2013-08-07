using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZillowSharp.DTOs
{
    public class ListingsJsonResponse
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "page")]
        public int? Page { get; set; }

        [DataMember(Name = "count")]
        public string Count { get; set; }

        [DataMember(Name = "total_count")]
        public string TotalCount { get; set; }

        [DataMember(Name = "listings")]
        public List<ListingJsonDTO> Listings { get; set; }
    }
}
