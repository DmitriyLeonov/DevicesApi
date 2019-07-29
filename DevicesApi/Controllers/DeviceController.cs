using DevicesApi.Mappers;
using DevicesApi.Models;
using Domain.Interfaces;
using DomainServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevicesApi.Controllers
{
    [RoutePrefix("devices")]
    public class DeviceController : ApiController
    {
        public readonly IDevicesService _devicesService;

        public DeviceController(IDevicesService devicesService)
        {
            _devicesService = devicesService;
        }

        [HttpGet,Route("{userId:int}")]
        public List<DeviceModel> GetUserDevices(int userId)
        {
            var devices = _devicesService.GetUserDevices(userId);
            return devices.Select(_=>_.ToDeviceModel()).ToList();
        }

        [HttpPost, Route("post/{userId:int}")]
        public bool AddDevice (int userId)
        {
            var device = _devicesService.AddDevice(userId);
            return true;
        }

        [HttpDelete, Route("delete/{userId:int}/{deviceId:int}")]
        public void DeleteDevice (int userId, int deviceId)
        {
            _devicesService.DeletDevice(userId, deviceId);
        }
    }
}
