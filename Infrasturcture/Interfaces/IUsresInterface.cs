using Infrasturcture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrasturcture.Interfaces
{
    public interface IUsresInterface
    {
        IEnumerable<InfrastructureUser> GetAllUsers();
        List<InfrastructureDevice> GetUserDevices(int userId);
        bool AddDevice(int userId);
        void DeletDevice(int userId, int deviceId);
    }
}
