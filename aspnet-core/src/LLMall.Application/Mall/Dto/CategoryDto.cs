using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LLMall.Mall.Dto
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDto : EntityDto<int>
    {
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
    }
}
