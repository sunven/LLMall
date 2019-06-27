using Abp.Application.Services.Dto;

namespace LLMall.Mall.Dto
{
    public class BannerSearchDto : PagedResultRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        public string SortStr { get; set; }
    }
}
