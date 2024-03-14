using Email_Application.IServer;
using Email_Application.Serveces;
using Email_Domen.Entity.DTOs;
using Email_Domen.Entity.Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EmailTest
{
    public class UserTest
    {
        private readonly ILoginServece _loginServece;
        private readonly Mock<IloginRepository> _repositoryMock;

        public UserTest()
        {
            _repositoryMock = new Mock<IloginRepository>();
            _loginServece = new LoginServece(_repositoryMock.Object);
        }

        [Fact]
        public async Task Add_ShouldReturnCreateUser()
        {
            //Arrange 
            var login = new LoginDTO
            {
                Email = "xushnudegamberdiyev0@gmail.com",
                Password = "777777"
            };

            var expectedLogin = new Login
            {
                Id = 1,
                Email = "xushnudegamberdiyev0@gmail.com",
                Password = "7777777",
                SendCode = "90099"
            };

            _repositoryMock.Setup(r => r.)
        }
    }
}
