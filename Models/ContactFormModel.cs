using System.ComponentModel.DataAnnotations;

namespace DivineImagesATL.Web.Models
{
    public sealed class ContactFormModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [StringLength(30)]
        [RegularExpression(@"^[0-9+\-\(\)\s\.]*$", ErrorMessage = "Phone number contains invalid characters.")]
        public string? Phone { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 10)]
        public string Message { get; set; } = string.Empty;

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms.")]
        public bool AcceptTerms { get; set; }
    }

    public sealed class ContactPageViewModel
    {
        public ContactPageContent Page { get; set; } = new();
        public ContactFormModel Form { get; set; } = new();
    }
}
