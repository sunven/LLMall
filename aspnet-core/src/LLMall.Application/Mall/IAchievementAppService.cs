using System.Collections.Generic;
using Abp.Application.Services;

namespace LLMall.Mall
{
    public interface IAchievementAppService:IApplicationService
    {
        List<string> UpLoad();
    }
}