﻿using Microsoft.AspNetCore.Mvc;
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
            byte[]? image = null;
            switch(section)
            {
                case "authorphotos":
                    image = await _imageService.GetAuthorPhotoAsync(imageId);
                    break;
                case "userphotos":
                    image = await _imageService.GetUserPhotoAsync(imageId);
                    break;
                case "covers":
                    image = await _imageService.GetCoverAsync(imageId);
                    break;
                default:
                    return NotFound($"There is no section named {section}.");
            }

            Response.ContentType = "image/png";
            await Response.Body.WriteAsync(image, 0, image.Length);

            return Ok();
        }
    }
}
