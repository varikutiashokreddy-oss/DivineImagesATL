using DivineImagesATL.Web.Models;
using DivineImagesATL.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DivineImagesATL.Web.Controllers
{
    public sealed class SiteController : Controller
    {
        private readonly ISiteContentService _contentService;

        public SiteController(ISiteContentService contentService)
        {
            _contentService = contentService;
        }

        [HttpGet("")]
        public IActionResult Index() =>
            Render("Index", site => site.Home, "Home");

        [HttpGet("services")]
        public IActionResult Services() =>
            Render("Services", site => site.Services, "Services");

        [HttpGet("patients")]
        public IActionResult Patients() =>
            Render("Patients", site => site.Patients, "Patients");

        [HttpGet("attorneys")]
        public IActionResult Attorneys() =>
            Render("Attorneys", site => site.Attorneys, "Attorneys");

        [HttpGet("about-us")]
        public IActionResult About() =>
            Render("About", site => site.About, "About Us");

        [HttpGet("mri")]
        public IActionResult Mri() =>
            Render("Mri", site => site.Mri, "MRI");

        private IActionResult Render<TModel>(string viewName, Func<SiteContent, TModel> selector, string title)
        {
            var site = _contentService.GetContent();
            ViewData["SiteContent"] = site;
            ViewData["Title"] = title;
            return View(viewName, selector(site));
        }
    }
}
