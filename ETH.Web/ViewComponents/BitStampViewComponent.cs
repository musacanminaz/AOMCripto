using ETH.Business;
using ETH.Entities;
using ETH.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ETH.Web.ViewComponents
{
    public class BitStampViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            var bitStamp = ConvertService.GetJsonRequest<BitStamp>("https://www.bitstamp.net/api/v2/ticker/ETHEUR");

            ETHPriceViewModel model = new ETHPriceViewModel
            {
                BitStamp = bitStamp,

            };
            return View(model);
        }
    }
}
