using Domain.Models;
using Infrasturcture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Mappers
{
    public static class DeviceInfrastructureToDomainMapper
    {
        public static DomainDevice DeviceToDomain(this InfrastructureDevice @this)
        { return new DomainDevice
            {
            DeviceID = @this.DeviceID,
            DeviceName = @this.DeviceName,
            UserID = @this.UserID
        };
        }
    }
}
