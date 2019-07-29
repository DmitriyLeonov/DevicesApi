using Domain.Models;
using Infrasturcture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Mappers
{
    public static class UserInfrastructureToDomain
    {
        public static DomainUser UserToDomain(this InfrastructureUser @this)
        {
            return new DomainUser
            {
                UserID = @this.UserID,
                UserName = @this.UserName
            };
        }
    }
}
