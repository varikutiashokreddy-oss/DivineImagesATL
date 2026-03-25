using DivineImagesATL.Web.Models;
using System.Text.Json;

namespace DivineImagesATL.Web.Services
{
    public sealed class JsonContactSubmissionService : IContactSubmissionService
    {
        private readonly string _filePath;
        private readonly SemaphoreSlim _mutex = new(1, 1);

        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public JsonContactSubmissionService(IWebHostEnvironment environment)
        {
            _filePath = Path.Combine(environment.ContentRootPath, "Data", "contact-submissions.json");
        }

        public async Task SaveAsync(ContactFormModel model, CancellationToken cancellationToken = default)
        {
            await _mutex.WaitAsync(cancellationToken);

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_filePath)!);

                List<ContactSubmissionRecord> submissions;

                if (File.Exists(_filePath))
                {
                    await using var readStream = new FileStream(
                        _filePath,
                        FileMode.Open,
                        FileAccess.Read,
                        FileShare.ReadWrite);

                    submissions = await JsonSerializer.DeserializeAsync<List<ContactSubmissionRecord>>(
                        readStream,
                        _jsonOptions,
                        cancellationToken) ?? [];
                }
                else
                {
                    submissions = [];
                }

                submissions.Add(new ContactSubmissionRecord
                {
                    Name = model.Name.Trim(),
                    Email = model.Email.Trim(),
                    Phone = model.Phone?.Trim(),
                    Message = model.Message.Trim(),
                    SubmittedUtc = DateTimeOffset.UtcNow
                });

                await using var writeStream = new FileStream(
                    _filePath,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None);

                await JsonSerializer.SerializeAsync(writeStream, submissions, _jsonOptions, cancellationToken);
            }
            finally
            {
                _mutex.Release();
            }
        }

        private sealed class ContactSubmissionRecord
        {
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string? Phone { get; set; }
            public string Message { get; set; } = string.Empty;
            public DateTimeOffset SubmittedUtc { get; set; }
        }
    }
}
