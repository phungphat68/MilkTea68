using MilkTea68.Application.Catalog.Products.Dtos;
using MilkTea68.Application.Catalog.Products.Dtos.Public;

using MilkTea68.Application.Dtos;
using System.Threading.Tasks;

namespace MilkTea68.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
