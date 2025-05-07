using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Travail3_TestsUnitaires.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Unit_Test_Travail3
{
    public class Test_WelcomeController
    {
        [Fact]
        public void Test_WelcomeDefault()
        {
            // Arrange
            var welcomeController = new WelcomeController();
            // Act
            var result = welcomeController.WelcomeDefault();
            // Assert
            var viewResult = Assert.IsType<ContentResult>(result);
        }

        [Fact]
        public void Test_WelcomeName()
        {
            // Arrange
            var welcomeController = new WelcomeController();
            // Act
            var result = welcomeController.WelcomeName("Bob", "Cashflow");
            //Assert    
            var viewResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Salut Bob Cashflow ! Bienvenue dans ma nouvelle application!", viewResult.Content);
        }
    }
}
