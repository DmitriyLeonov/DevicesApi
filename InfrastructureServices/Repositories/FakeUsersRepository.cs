using Infrasturcture.Interfaces;
using Infrasturcture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureServices.Repositories
{
    public class FakeUsersRepository : IUsresInterface
    {
        public List<InfrastructureUser> users = new List<InfrastructureUser>
        {
            new InfrastructureUser{UserID = 1, UserName = "Ivan"},
            new InfrastructureUser{UserID = 2, UserName = "Stas"},
            new InfrastructureUser{UserID = 3, UserName = "Oleg"}
        };

        public bool AddDevice(int userId)
        {
            FakeDevicesRepository fakeDevices = new FakeDevicesRepository();
            if (fakeDevices.CreateDevice(userId))
                return true;
            else 
                return false;
        }

        public void DeletDevice(int userId, int deviceId)
        {
            FakeDevicesRepository devices = new FakeDevicesRepository();
            devices.DeleteDevice(deviceId);
        }

        public IEnumerable<InfrastructureUser> GetAllUsers()
        {
            return users;
        }

        public List<InfrastructureDevice> GetUserDevices(int userId)
        {
            FakeDevicesRepository fakeDevices = new FakeDevicesRepository();
            var devices = fakeDevices.Current();
            return devices.FindAll(_=>_.UserID == userId);
        }
    }
}
