using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.Application.Dtos
{
    public class PagedResult<T>:PagingRequestBase
    {
        public List<T> Items { set; get; }
       
    }
}
