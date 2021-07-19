using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.ViewModels.Common
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }
    }
}
