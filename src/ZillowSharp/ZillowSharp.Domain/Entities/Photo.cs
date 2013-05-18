﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZillowSharp.Domain.Entities
{
    public class Photo
    {
        public int SortOrder { get; set; }
        public bool MainPhoto { get; set; }
        public string ThumbnailUrl { get; set; }
        public string FullSizeUrl { get; set; }
    }
}
