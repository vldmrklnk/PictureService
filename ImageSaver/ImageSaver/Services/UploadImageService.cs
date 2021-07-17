using DataLayer;
using ImageSaver.Interfaces;
using ImageSaver.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ImageSaver.Services
{
	//This service use in controller to upload an image in database
	public class UploadImageService : IUploadImageService
	{
		ImageSaverContext context;
		public UploadImageService(ImageSaverContext context)
		{
			this.context = context;
		}

		public void UploadImage(ImageViewModel imageModel)
		{
			Image image = new Image();
			// Getting Image
			if (imageModel.Picture.Length > 0)
			{
				using (var binaryReader = new BinaryReader(imageModel.Picture.OpenReadStream()))
				{
					image.Picture = binaryReader.ReadBytes((int)imageModel.Picture.Length);
					image.ImageName = imageModel.Picture.FileName;
					image.LenghtOfImage = imageModel.Picture.Length;
					image.ContentType = imageModel.Picture.ContentType;
				}
				// Saving Image on Server
				context.Add(image);
				context.SaveChanges();
			}
		}
	}
}
