using DevicesApi.Mappers;
using DevicesApi.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevicesApi.Controllers
{
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        public readonly IUsersService _usersService;

        public UserController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet, Route("")]
        public List<UserModel> GetUsers()
        {
            var users = _usersService.GetAllUsers();
            return users.Select(_=>_.ToUserModel()).ToList();
        }
    }
}
