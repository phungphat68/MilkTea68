using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MilkTea68.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MilkTea68.ViewModels.Common;
using MilkTea68.ViewModels.Catelog.Products;

namespace MilkTea68.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {

        private readonly MilkTea68DbContext _context;
        public PublicProductService(MilkTea68DbContext context)
        {
            _context = context;
        }

       

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryIds equals c.Id
                        where pt.LanguageId== languageId
                        select new { p, pt, pic };

            //2. filter

            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(p => p.pic.CategoryIds == request.CategoryId);
            }

            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount,
                    //ThumbnailImage = x.pi.ImagePath
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
    }
}
