using Infrasturcture.Interfaces;
using Infrasturcture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureServices.Repositories
{
    public class FakeDevicesRepository : IDevicesInterface
    {
        public List<InfrastructureDevice> devices = new List<InfrastructureDevice>
        {
            new InfrastructureDevice{DeviceID = 1, DeviceName = "Lamp", UserID = 1}  ,
            new InfrastructureDevice{DeviceID = 2, DeviceName = "Lamp", UserID = 2},
            new InfrastructureDevice{DeviceID = 3, DeviceName = "Camera", UserID = 1},
            new InfrastructureDevice{DeviceID = 4, DeviceName = "Sensor", UserID =3}
        };

        public List<InfrastructureDevice> Current()
        {
            return devices;
        }

        public bool CreateDevice(int userId)
        {
            InfrastructureDevice device = new InfrastructureDevice()
            {
                DeviceID = devices.Max(_=>_.DeviceID)+1,
                DeviceName = "Sensor",
                UserID = userId
            };
            devices.Add(device);
            return true;
        }

        public IEnumerable<InfrastructureDevice> GetDevices()
        {
            return devices;
        }

        public void DeleteDevice(int deviceId)
        {
            devices.RemoveAll(_=>_.DeviceID == deviceId);
        }

         public List<InfrastructureDevice> GetUserDevices(int userId)
        {
            return devices.FindAll(_=>_.UserID == userId);
        }
    }
}
