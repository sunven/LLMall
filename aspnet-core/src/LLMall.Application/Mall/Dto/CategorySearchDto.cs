using Abp.Application.Services.Dto;

namespace LLMall.Mall.Dto
{
    public class CategorySearchDto : PagedDto
    {
        public int? ParentId { get; set; }
    }
}
