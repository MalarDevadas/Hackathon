using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
   
    public class ApplianceStatus
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    public class SensorData
    {
        public string id { get; set; }
        public string value { get; set; }

        public string dateTime { get; set; }
    }   
}