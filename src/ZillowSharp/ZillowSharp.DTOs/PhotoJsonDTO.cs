using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZillowSharp.DTOs
{
    public class PhotoJsonDTO
    {
        [DataMember(Name = "sort_order")]
        public int SortOrder { get; set; }

        [DataMember(Name = "main_photo")]
        public bool MainPhoto { get; set; }

        [DataMember(Name = "thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [DataMember(Name = "full_size_url")]
        public string FullSizeUrl { get; set; }
    }
}
