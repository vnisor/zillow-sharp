using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZillowSharp.DTOs
{
    [DataContract]
    public class ContactJsonDTO
    {
        [DataMember(Name = "company")]
        public string Company { get; set; }
        
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
