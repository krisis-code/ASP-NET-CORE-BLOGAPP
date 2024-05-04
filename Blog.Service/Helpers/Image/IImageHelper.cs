using Blog.Entity.DTOs.Images;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Helpers.Image
{
    public interface IImageHelper

    {
        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, string folderName = null);
        Task Delete(string imageName);
    }
}
