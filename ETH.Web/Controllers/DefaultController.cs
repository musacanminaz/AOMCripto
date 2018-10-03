using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETH.Business;
using ETH.Entities;
using ETH.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETH.Web.Controllers
{
    public class DefaultController : Controller
    {
        //private ConvertService _convertService;

        //public DefaultController(ConvertService convertService)
        //{
        //    _convertService = convertService;
        //}
        [HttpGet]
        public IActionResult Index()
        {
           
            

            return View();
        }


        

    }


}