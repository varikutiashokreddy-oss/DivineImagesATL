using DivineImagesATL.Web.Models;
using System.Text.Json;

namespace DivineImagesATL.Web.Services
{
    public sealed class JsonSiteContentService : ISiteContentService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true,
            ReadCommentHandling = JsonCommentHandling.Skip
        };

        public JsonSiteContentService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public SiteContent GetContent()
        {
            var path = Path.Combine(_environment.ContentRootPath, "Data", "site-content.json");

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("The site-content.json file was not found.", path);
            }

            var json = File.ReadAllText(path);
            var content = JsonSerializer.Deserialize<SiteContent>(json, _jsonOptions);

            return content ?? new SiteContent();
        }
    }
}
