using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
	public class Image
	{
		[Key]
		public int Id { get; set; }
		public string ImageName { get; set; }
		public string ContentType { get; set; }
		public long LenghtOfImage { get; set; }
		public byte[] Picture { get; set; }
	}
}
