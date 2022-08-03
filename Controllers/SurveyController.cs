using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers;
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(string NameField, string LocationField, string FavLanguageField, string CommentField)
        {
            ViewBag.NameField = NameField;
            ViewBag.LocationField = LocationField;
            ViewBag.FavLanguageField = FavLanguageField;
            ViewBag.CommentField = CommentField;
            return View();
        }

    }