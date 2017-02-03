using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public enum OrderStatus
    {
        Create, 
        InProgress,
        Shipped,
        Delivered
    }
}