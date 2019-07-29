using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevicesApi.Models
{
    public class DeviceModel
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public int UserID { get; set; }
    }
}