﻿using Blog.Entity.DTOs.Images;
using Blog.Entity.Enums;
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
        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile,ImageType imageType, string folderName = null);
        Task Delete(string imageName);
       
    }
}
