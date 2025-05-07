using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail3_TestsUnitaires.Controllers;

namespace Unit_Test_Travail3
{
    public class Test_Exercie2Controller
    {
        [Fact]
        public void Test_Bienvenue()
        {
            // Arrange
            var exercice2Controller = new Exercice2Controller();
            // Act
            var result = exercice2Controller.Bienvenue();
            // Assert
            var viewResult = Assert.IsType<string>(result);
            Assert.Equal("<h2>Bienvenu dans mon site web</h2>", viewResult.ToString());
        }

        [Fact]
        public void Test_Bienvenue2()
        {
            // Arrange
            var exercice2Controller = new Exercice2Controller();
            // Act
            var result = exercice2Controller.Bienvenue2();
            // Assert
            var viewResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("<h2>Bienvenu dans mon site web</h2>", viewResult.Content);
        }

        [Fact]
        public void Test_AfficherVue()
        {
            // Arrange
            var exercice2Controller = new Exercice2Controller();
            // Act
            var result = exercice2Controller.AfficherVue();
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Test_AfficherPdf()
        {
            // Arrange
            var exercice2Controller = new Exercice2Controller();
            // Act
            var result = exercice2Controller.AfficherPdf();
            // Assert
            var viewResult = Assert.IsType<FileContentResult>(result);
            Assert.Equal("application/pdf", viewResult.ContentType);
        }
    }
}
