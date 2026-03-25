using DivineImagesATL.Web.Models;

namespace DivineImagesATL.Web.Services
{
    public interface IContactSubmissionService
    {
        Task SaveAsync(ContactFormModel model, CancellationToken cancellationToken = default);
    }
}
