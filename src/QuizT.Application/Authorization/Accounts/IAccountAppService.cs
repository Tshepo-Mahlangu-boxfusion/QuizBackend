using System.Threading.Tasks;
using Abp.Application.Services;
using QuizT.Authorization.Accounts.Dto;

namespace QuizT.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
