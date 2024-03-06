using Abp.Application.Services;
using QuizT.MultiTenancy.Dto;

namespace QuizT.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

