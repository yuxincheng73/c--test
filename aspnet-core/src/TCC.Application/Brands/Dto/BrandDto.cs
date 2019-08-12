using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TCC.Models;

namespace TCC.Brands.Dto
{
    [AutoMap(typeof(Brand))]
    public class BrandDto : EntityDto
    {
        public string Name { get; set; }
        public string Name_TC { get; set; }
        public string Name_SC { get; set; }
        public string Description { get; set; }
        public string Description_TC { get; set; }
        public string Description_SC { get; set; }
        public string Url { get; set; }
        public string Url_TC { get; set; }
        public string Url_SC { get; set; }
        public string Logo { get; set; }
        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }
    }
}
