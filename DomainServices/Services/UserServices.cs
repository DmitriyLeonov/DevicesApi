using Domain.Interfaces;
using Domain.Models;
using Infrasturcture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainServices.Mappers;
using Infrasturcture.Models;

namespace DomainServices.Services
{
    public class UserServices : IUsersService
    {
        private readonly IUsresInterface _usresInterface;
        public IDevicesInterface devicesInterface;

        public UserServices(IUsresInterface usresInterface)
        {
            _usresInterface = usresInterface;
        }

        public List<DomainUser> GetAllUsers()
        {
            var users = _usresInterface.GetAllUsers();
            return users.Select(_ => _.UserToDomain()).ToList();
        }
    }
}
