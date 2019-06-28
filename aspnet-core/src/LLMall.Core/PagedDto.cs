using Abp.Application.Services.Dto;

namespace LLMall
{
    public class PagedDto:PagedResultRequestDto
    {
        public string SortStr { get; set; }
    }
}