using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TCC.Models
{
    public class Brand : Entity, IHasCreationTime, ISoftDelete
    {
        [Column("company_id")]
        public int CompanyId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("name_tc")]
        public string Name_TC { get; set; }
        [Column("name_sc")]
        public string Name_SC { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("description_tc")]
        public string Description_TC { get; set; }
        [Column("description_sc")]
        public string Description_SC { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [Column("url_tc")]
        public string Url_TC { get; set; }
        [Column("url_sc")]
        public string Url_SC { get; set; }
        [Column("logo")]
        public string Logo { get; set; }
        [Column("cover_image")]
        public string CoverImage { get; set; }
        [Column("discoverable")]
        public bool Discoverable { get; set; }
        [Column("sorting_order")]
        public int SortingOrder { get; set; }
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
        [Column("created_at")]
        public DateTime CreationTime { get; set; }
        [Column("updated_at")]
        public DateTime UpdationTime { get; set; }
        [Column("deleted_at")]
        public DateTime DeletionTime { get; set; }
        [Column("time_zone")]
        public string TimeZone { get; set; }
        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        public Brand()
        {
            CreationTime = Clock.Now;
        }
    }
}
