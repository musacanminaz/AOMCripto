using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETH.Business;
using ETH.Entities;
using ETH.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ETH.Web.ViewComponents
{
    public class HitBTCViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            var hitBTC = ConvertService.GetJsonRequest<HitBTC>("https://api.hitbtc.com/api/2/public/ticker/ETHUSD");

            ETHPriceViewModel model = new ETHPriceViewModel
            {
                HitBTC = hitBTC,

            };
            return View(model);
        }
    }
}
