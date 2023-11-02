using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

public class SurveyController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("results")]
    public IActionResult Survey(Survey survey)
    {
        if (ModelState.IsValid)
        {
            return View("results", survey);
        }
        else
        {
            return View("Index");
        }
    }

}