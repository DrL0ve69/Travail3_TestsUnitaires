﻿using Microsoft.AspNetCore.Mvc;

namespace Travail3_TestsUnitaires.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string WelcomeDefault() 
        {
            return "Bienvenue dans ma nouvelle application! ";
        }
        public IActionResult WelcomeName(string nom,string prenom) 
        {
            return Content($"Salutions {nom}, {prenom}.\nBienvenue dans ma nouvelle application!!!");
        }
    }
}
