using System.Threading.Tasks;
using Abp.Application.Services;
using MyClub.Sessions.Dto;

namespace MyClub.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
