using DataLayer;
using ImageSaver.Interfaces;
using ImageSaver.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageSaver.Services
{
	//This service use in controller to get all images in database
	public class ImageReaderService : IImageReaderService
	{
		ImageSaverContext context;
		public ImageReaderService(ImageSaverContext context)
		{
			this.context = context;
		}
		public List<Image> GetAllImages()
		{
			List<Image> images = new List<Image>();
		
			foreach (var x in this.context.Images)
			{
				images.Add(new Image { Id = x.Id, Picture = x.Picture,ContentType=x.ContentType, ImageName=x.ImageName, LenghtOfImage=x.LenghtOfImage});
			}
			return images;
		}
	}
}
