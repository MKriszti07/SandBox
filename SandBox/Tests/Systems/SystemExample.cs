using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Systems
{
    public class SystemExample
    {
        //You can use the System folder to create test for controllers, services or any other section of project.
        //[Fact]
        //public async Task Get_OnSuccess_ReturnsStatusCode200()
        //{
        //    //Arrange
        //    var mockUsersControllerLogger = new Mock<ILogger<UsersController>>();
        //    var mockUsersService = new Mock<IUsersService>();

        //    mockUsersService
        //       .Setup(service => service.GetAllUsers())
        //       .ReturnsAsync(UsersFixture.GetTestUsers());

        //    var sut = new UsersController(mockUsersControllerLogger.Object
        //        , mockUsersService.Object);

        //    //Act
        //    var result = (OkObjectResult)await sut.Get();

        //    //Assert
        //    result.StatusCode.Should().Be(200);
        //}
    }
}
