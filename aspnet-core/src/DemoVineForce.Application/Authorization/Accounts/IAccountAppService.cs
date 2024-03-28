using System.Threading.Tasks;
using Abp.Application.Services;
using DemoVineForce.Authorization.Accounts.Dto;

namespace DemoVineForce.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
