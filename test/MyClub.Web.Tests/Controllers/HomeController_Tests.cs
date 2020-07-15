using System.Threading.Tasks;
using MyClub.Models.TokenAuth;
using MyClub.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyClub.Web.Tests.Controllers
{
    public class HomeController_Tests: MyClubWebTestBase
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