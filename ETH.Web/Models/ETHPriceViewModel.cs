using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETH.Entities;

namespace ETH.Web.Models
{
    public class ETHPriceViewModel
    {
        public HitBTC HitBTC { get; set; }
        public BTCTurk BTCTurk { get; set; }
        public BitStamp BitStamp { get; set; }
    }
}
