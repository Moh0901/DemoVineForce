using System.Threading.Tasks;
using DemoVineForce.Models.TokenAuth;
using DemoVineForce.Web.Controllers;
using Shouldly;
using Xunit;

namespace DemoVineForce.Web.Tests.Controllers
{
    public class HomeController_Tests: DemoVineForceWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}