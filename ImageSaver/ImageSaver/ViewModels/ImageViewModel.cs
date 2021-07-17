using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageSaver.ViewModels
{
	public class ImageViewModel
	{
		public IFormFile Picture { get; set; }
	}
}
