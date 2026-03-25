using DivineImagesATL.Web.Models;
using DivineImagesATL.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DivineImagesATL.Web.Controllers
{
    public sealed class ContactController : Controller
    {
        private readonly ISiteContentService _contentService;
        private readonly IContactSubmissionService _contactSubmissionService;

        public ContactController(
            ISiteContentService contentService,
            IContactSubmissionService contactSubmissionService)
        {
            _contentService = contentService;
            _contactSubmissionService = contactSubmissionService;
        }

        [HttpGet("contact-us")]
        public IActionResult Index()
        {
            var site = _contentService.GetContent();
            ViewData["SiteContent"] = site;
            ViewData["Title"] = "Contact Us";

            var vm = new ContactPageViewModel
            {
                Page = site.ContactPage,
                Form = new ContactFormModel()
            };

            return View(vm);
        }

        [HttpPost("contact-us")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactFormModel form, CancellationToken cancellationToken)
        {
            var site = _contentService.GetContent();
            ViewData["SiteContent"] = site;
            ViewData["Title"] = "Contact Us";

            if (!ModelState.IsValid)
            {
                return View(new ContactPageViewModel
                {
                    Page = site.ContactPage,
                    Form = form
                });
            }

            await _contactSubmissionService.SaveAsync(form, cancellationToken);

            TempData["ContactSuccess"] = "Thank you. Your message has been received.";
            return RedirectToAction(nameof(Index));
        }
    }
}
