using System.Threading.Tasks;
using Abp.Application.Services;
using MyClub.Authorization.Accounts.Dto;

namespace MyClub.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
