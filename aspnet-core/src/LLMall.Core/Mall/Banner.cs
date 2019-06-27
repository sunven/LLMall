using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace LLMall.Mall
{
    public class Banner : Entity<int>, ISoftDelete
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
        [Required, MaxLength(512)]
        public string PicUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MaxLength(512)]
        public string TurnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Seq { get; set; }

        public bool IsDeleted { get; set; }
    }
}
