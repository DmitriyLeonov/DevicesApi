using Domain.Interfaces;
using Infrasturcture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using DomainServices.Mappers;
using Infrasturcture.Models;

namespace DomainServices.Services
{
    public class DeviceServices : IDevicesService
    {
        private readonly IDevicesInterface _devicesInterface;

        public DeviceServices(IDevicesInterface devicesInterface)
        {
            _devicesInterface = devicesInterface;
        }
        public List<DomainDevice> Current()
        {
            var device = _devicesInterface.GetDevices();
            return device.Select(_ => _.DeviceToDomain()).ToList();
        }

        public bool AddDevice(int userId)
        {
            var device = _devicesInterface;
            if(device.CreateDevice(userId))
                return true;
            else
                return false;
        }

        public void DeletDevice(int userId, int deviceId)
        {
            _devicesInterface.DeleteDevice(deviceId);
        }

        public List<DomainDevice> GetUserDevices(int userId)
        {
            var devices = _devicesInterface.GetUserDevices(userId);
            return devices.Select(_=>_.DeviceToDomain()).ToList();
        }
    }
}
