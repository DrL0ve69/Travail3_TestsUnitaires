using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Travail3_TestsUnitaires.Controllers;
using Xunit;

namespace Unit_Test_Travail3;

public class TestEnseignante
{
    [Fact]
    public void WelcomeHtml_ReturnsString()
    {
        // Arrange
        var controller = new Exercice2Controller();

        // Act
        var result = controller.Bienvenue();

        // Assert
        Assert.IsType<String>(result);
    }

    [Fact]
    public void WelcomeHtmlContentResult_ReturnsContentResult()
    {
        // Arrange
        var controller = new Exercice2Controller();

        // Act
        var result = controller.Bienvenue2();

        // Assert
        Assert.IsType<ContentResult>(result);
    }

    [Fact]
    public void ShowView_ReturnsViewResult()
    {
        // Arrange
        var controller = new Exercice2Controller();

        // Act
        var result = controller.AfficherVue();

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public void GetPdf_ReturnsFileResult()
    {
        // Arrange
        var controller = new Exercice2Controller();

        // Act
        var result = controller.AfficherPdf();

        // Assert
        Assert.IsType<VirtualFileResult>(result);
    }

    [Fact]
    public void GetClientsJson_ReturnsJsonResult()
    {
        // Arrange
        var controller = new Exercice2Controller();

        // Act
        var result = controller.AfficherClients();

        // Assert
        Assert.IsType<JsonResult>(result);
    }

    [Fact]
    public void RedirectToWelcomeHtml_ReturnsRedirectToActionResult()
    {
        // Arrange
        var controller = new Exercice2Controller();

        // Act
        var result = controller.Rediriger();

        // Assert
        Assert.IsType<RedirectToActionResult>(result);
    }
}
