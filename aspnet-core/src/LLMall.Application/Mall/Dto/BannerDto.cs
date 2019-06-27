using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LLMall.Mall.Dto
{
    [AutoMapFrom(typeof(Banner))]
    public class BannerDto : EntityDto<int>
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PicUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TurnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Seq { get; set; }

        public bool IsDeleted { get; set; }
    }
}
