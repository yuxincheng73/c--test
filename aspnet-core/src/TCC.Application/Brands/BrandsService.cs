using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;
using Newtonsoft.Json.Linq;
using TCC.Brands.Dto;
using TCC.Models;

namespace TCC.Brands
{
    public class BrandsService : TCCAppServiceBase, IBrandsService 
    {
        private readonly IRepository<Brand> _brandRepository;

        public BrandsService(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<int> CreateBrand(BrandDto input)
        {
            if(input == null)
            {
                return -1;
            }
            var brand = ObjectMapper.Map<Brand>(input);
            brand.Discoverable = false;
            brand.SortingOrder = brand.Id;
            brand.TimeZone = DateTime.UtcNow.ToString();
            var brandId = await _brandRepository.InsertAndGetIdAsync(brand);
            return brandId;
        }

        public async Task<int> DeleteBrand(EntityDto input)
        {
            if(input == null)
            {
                return 0;
            }
            await _brandRepository.DeleteAsync(input.Id);
            return 1;
        }

        public async Task<BrandDto> GetBrand(int id)
        {
            var brand = await _brandRepository.FirstOrDefaultAsync(c => c.Id == id);
            if (brand == null)
            {
                return null;
            }
            var brandToReturn = ObjectMapper.Map<BrandDto>(brand);
            return brandToReturn;
        }

        public async Task<BrandDto> GetBrandbyName(string name)
        {
            var brand = await _brandRepository.FirstOrDefaultAsync(c => c.Name == name);
            if(brand == null)
            {
                return null;
            }
            var brandToReturn = ObjectMapper.Map<BrandDto>(brand); ;
            return brandToReturn;
        }

        public async Task<List<BrandDto>> GetBrands()
        {
            var brands = await _brandRepository.GetAllListAsync();
            if(brands == null)
            {
                return null;
            }
            //iterate through each Brand object in brands & if missing Name, remove from list to return
            foreach(Brand brand in brands)
            {
                if(brand.Name == null)
                {
                    brands.Remove(brand);
                }
            }
            var brandsToReturn = ObjectMapper.Map<List<BrandDto>>(brands);
            return brandsToReturn;
        }

        public async Task<BrandDto> UpdateBrand(BrandDto input)
        {
            if (input == null)
            {
                return null;
            }
            var brand = ObjectMapper.Map<Brand>(input);
            var updatedBrand = await _brandRepository.UpdateAsync(brand);
            var brandToReturn = ObjectMapper.Map<BrandDto>(updatedBrand);
            return brandToReturn;
        }
    }
}
