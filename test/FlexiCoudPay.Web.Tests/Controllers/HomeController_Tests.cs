using System.Threading.Tasks;
using FlexiCoudPay.Models.TokenAuth;
using FlexiCoudPay.Web.Controllers;
using Shouldly;
using Xunit;

namespace FlexiCoudPay.Web.Tests.Controllers
{
    public class HomeController_Tests: FlexiCoudPayWebTestBase
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