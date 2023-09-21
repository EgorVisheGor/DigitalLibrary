using Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace DigitalLibrary.Controllers
{
    [Route("images")]
    public class ImagesController : Controller
    {
        private readonly IImageLoaderService _imageService;

        public ImagesController(IImageLoaderService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet("{section}/{imageId}")]
        public async Task<IActionResult> GetImage(string section, string imageId)
        {
            return section switch
            {
                "authorphotos" => File(await _imageService.GetPhotoAsync(Section.AuthorPhotos, imageId), "image/png"),
                "userphotos" => File(await _imageService.GetPhotoAsync(Section.UserPhotos, imageId), "image/png"),
                "covers" => File(await _imageService.GetPhotoAsync(Section.Covers, imageId), "image/png"),
                _ => NotFound($"There is no section named {section}.")
            };
        }
    }
}
