using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZillowSharp.Domain.Entities
{
    public class OpenHouse
    {
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string EndTime { get; set; }
        public string StartTime { get; set; }
        public string Notes { get; set; }
        public DateTime Date { get; set; }
        public string Agent { get; set; }
        public string OfficePhone { get; set; }
    }
}
