using System;
using System.Collections.Generic;
using System.Linq;

namespace ZillowSharp.Domain.Entities
{
    public class Photo : IEntity
    {
        #region Properties

        public string FullSizeUrl { get; set; }

        public string MainPhoto { get; set; }

        public int? SortOrder { get; set; }

        public string ThumbnailUrl { get; set; }

        #endregion

    }
}
