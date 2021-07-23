using MilkTea68.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.ViewModels.Catelog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {        
        public int? CategoryId { get; set; }
    }
}
