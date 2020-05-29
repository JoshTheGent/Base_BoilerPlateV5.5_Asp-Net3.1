using System.Threading.Tasks;
using Abp.Application.Services;
using JoshTheGent.Sessions.Dto;

namespace JoshTheGent.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
