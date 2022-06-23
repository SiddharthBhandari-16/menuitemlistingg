using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListing.Models;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Yezdi", Active=true, DateOfLaunch=new DateTime(2022,10,27), FreeDelivery=false,Price=250000},
                new MenuItem() {Id=2, Name="Jawa", Active=false, DateOfLaunch=new DateTime(2022,11,23), FreeDelivery=false,Price=230000}

            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Yezdi", Active=true, DateOfLaunch=new DateTime(2022,10,27), FreeDelivery=false,Price=250000},
                new MenuItem() {Id=2, Name="Jawa", Active=false, DateOfLaunch=new DateTime(2022,11,23), FreeDelivery=false,Price=230000}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;
            
        }

    }
}
