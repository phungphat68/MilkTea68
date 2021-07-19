
using MilkTea68.ViewModels.Catelog.Products;
using MilkTea68.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MilkTea68.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
