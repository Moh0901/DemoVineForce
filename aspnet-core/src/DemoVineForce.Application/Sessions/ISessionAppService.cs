using System.Threading.Tasks;
using Abp.Application.Services;
using DemoVineForce.Sessions.Dto;

namespace DemoVineForce.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
