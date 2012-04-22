using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystemLibrary
{
    public class RMALib
    {
        public static RMASvc.RMAticket submitRMA(string orderId, string userId)
        {
            var RMASvcClient = new RMASvc.ReqdServicesClient();
                return RMASvcClient.submitRMA(userId, orderId);


        }
    }
}
