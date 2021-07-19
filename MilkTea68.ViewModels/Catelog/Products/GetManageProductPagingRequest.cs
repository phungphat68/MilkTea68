using MilkTea68.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.ViewModels.Catelog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
