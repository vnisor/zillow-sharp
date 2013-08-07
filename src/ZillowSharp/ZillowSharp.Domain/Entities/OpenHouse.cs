using System;
using System.Collections.Generic;
using System.Linq;

namespace ZillowSharp.Domain.Entities
{
    public class OpenHouse : IEntity
    {
        #region Properties

        public string Agent { get; set; }

        public DateTime? Date { get; set; }

        public string Email { get; set; }

        public string EndTime { get; set; }

        public string MobilePhone { get; set; }

        public string Notes { get; set; }

        public string OfficePhone { get; set; }

        public string StartTime { get; set; }

        #endregion

    }
}
