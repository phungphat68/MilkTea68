using MilkTea68.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public string LanguageId { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
