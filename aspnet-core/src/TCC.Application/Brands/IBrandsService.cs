using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TCC.Brands.Dto;
using TCC.Models;

namespace TCC.Brands
{
    public interface IBrandsService : IApplicationService
    {
        Task<List<BrandDto>> GetBrands();
        Task<BrandDto> GetBrand(int id);
        Task<BrandDto> GetBrandbyName(string name);
        Task<int> CreateBrand(BrandDto input);
        Task<BrandDto> UpdateBrand(BrandDto input);
        Task<int> DeleteBrand(EntityDto input);
    }
}
