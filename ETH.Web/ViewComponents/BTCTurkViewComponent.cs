using ETH.Business;
using ETH.Entities;
using ETH.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ETH.Web.ViewComponents
{
    public class BTCTurkViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            var btcTurk = ConvertService.GetJsonRequest<BTCTurk>("https://www.btcturk.com/api/ticker?pairSymbol=ETHTRY");

            ETHPriceViewModel model = new ETHPriceViewModel
            {
                BTCTurk = btcTurk,

            };
            return View(model);
        }
    }
}
