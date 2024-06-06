using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using RunGroopWebApp.Helpers;
using RunGroopWebApp.Interfaces;

namespace RunGroopWebApp.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly Cloudinary _cloudinary;
        public PhotoService(IOptions<CloudinarySettings> config) 
        {
            var acc = new Account(
                config.Value.CloundName,
                config.Value.ApiKey,
                config.Value.ApiSecret
                );
            _cloudinary = new Cloudinary(acc);
        }
        public Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task<DeletionResult> DeletePhotoAsync(string publicId)
        {
            throw new NotImplementedException();
        }
    }
}
