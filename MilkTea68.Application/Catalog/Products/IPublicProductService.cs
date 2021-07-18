using MilkTea68.Application.Catalog.Products.Dtos;
using MilkTea68.Application.Catalog.Products.Dtos.Manage;
using MilkTea68.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using MilkTea68.Application.Catalog.Products.Dtos;


namespace MilkTea68.Application.Catalog.Products
{
    interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
