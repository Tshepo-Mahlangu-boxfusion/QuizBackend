using System.Threading.Tasks;
using Abp.Application.Services;
using QuizT.Sessions.Dto;

namespace QuizT.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
