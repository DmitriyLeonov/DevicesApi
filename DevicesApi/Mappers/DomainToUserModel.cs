using DevicesApi.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevicesApi.Mappers
{
    public static class DomainToUserModel
    {
        public static UserModel ToUserModel(this DomainUser @this)
        {
            return new UserModel
            {
                UserID = @this.UserID,
                UserName = @this.UserName
            };
        }
    }
}