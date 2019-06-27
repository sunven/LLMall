using Abp.Application.Services;
using LLMall.Mall.Dto;
using System.Threading.Tasks;

namespace LLMall.Mall
{
    public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto, int>
    {
        
    }
}
