using Infrasturcture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasturcture.Interfaces
{
    public interface IDevicesInterface
    {
        bool CreateDevice(int userId);
        IEnumerable<InfrastructureDevice> GetDevices();
        void DeleteDevice(int deviceId);
        List<InfrastructureDevice> GetUserDevices(int userId);
    }
}
