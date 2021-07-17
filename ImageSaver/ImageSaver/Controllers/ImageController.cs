using DataLayer;
using ImageSaver.Interfaces;
using ImageSaver.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ImageSaver.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ImageController : ControllerBase
	{
		private readonly IImageReaderService readerService;
		private readonly IUploadImageService uploadImageService;
		public ImageController(IImageReaderService readerService, IUploadImageService uploadImageService)
		{
			this.readerService = readerService;
			this.uploadImageService = uploadImageService;
		}
		[HttpPost("uploadimage")]
		public ObjectResult UploadImage([FromForm] ImageViewModel imageModel)
		{
			uploadImageService.UploadImage(imageModel);
			return Ok(new { status = true, message = "Image added Successfully" });
		}

		[HttpGet("getallimages")]
		public ObjectResult GetAllImages()
		{
			return new ObjectResult(readerService.GetAllImages()); 
		}
	}
}

