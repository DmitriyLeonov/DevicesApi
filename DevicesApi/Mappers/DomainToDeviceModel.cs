using DevicesApi.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevicesApi.Mappers
{
    public static class DomainToDeviceModel
    {
        public static DeviceModel ToDeviceModel(this DomainDevice @this)
        {
            return new DeviceModel{
                DeviceID = @this.DeviceID,
                DeviceName = @this.DeviceName,
                UserID = @this.UserID
                };
        }
    }
}