using ImageSaver.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageSaver.Interfaces
{
	public interface IUploadImageService
	{
		public void UploadImage(ImageViewModel image);
	}
}
