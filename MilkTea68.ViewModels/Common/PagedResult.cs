using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.ViewModels.Common
{
    public class PagedResult<T> : PagingRequestBase
    {
        public List<T> Items { set; get; }

    }
}
