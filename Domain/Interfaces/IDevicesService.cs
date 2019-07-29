using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDevicesService
    {
        bool AddDevice(int userId);
        void DeletDevice(int userId, int deviceId);
        List<DomainDevice> GetUserDevices(int userId);
    }
}
