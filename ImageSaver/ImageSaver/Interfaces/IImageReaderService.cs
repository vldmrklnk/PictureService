using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ImageSaver.Interfaces
{
	public interface IImageReaderService
	{
		public List<Image> GetAllImages();
	}
}
