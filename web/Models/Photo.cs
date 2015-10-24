using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Web.Models
{
    public class Photo
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}