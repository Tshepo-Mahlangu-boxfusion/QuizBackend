using System.Threading.Tasks;
using QuizT.Models.TokenAuth;
using QuizT.Web.Controllers;
using Shouldly;
using Xunit;

namespace QuizT.Web.Tests.Controllers
{
    public class HomeController_Tests: QuizTWebTestBase
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