using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace LLMall.Mall
{
    public class Category : Entity<int>, ISoftDelete
    {
        /// <summary>
        /// 
        /// </summary>
        [Required, MaxLength(32)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MaxLength(512)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Seq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ParentCode { get; set; }

        public bool IsDeleted { get; set; }
    }
}
