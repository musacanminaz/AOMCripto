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
    public class BinanceViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            var binance = ConvertService.GetJsonRequest<Binance>("https://api.binance.com/api/v1/ticker/24hr?symbol=ETHUSDT");

            ETHPriceViewModel model = new ETHPriceViewModel
            {
                Binance = binance,

            };

            return View(model);
        }
    }
}
