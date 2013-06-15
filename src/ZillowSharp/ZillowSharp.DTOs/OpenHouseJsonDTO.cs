using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ZillowSharp.DTOs
{
    public class OpenHouseJsonDTO
    {
        #region Properties

        [DataMember(Name = "agent")]
        public string Agent { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "end_time")]
        public string EndTime { get; set; }

        [DataMember(Name = "mobile_phone")]
        public string MobilePhone { get; set; }

        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        [DataMember(Name = "office_phone")]
        public string OfficePhone { get; set; }

        [DataMember(Name = "start_time")]
        public string StartTime { get; set; }

        #endregion

    }
}
