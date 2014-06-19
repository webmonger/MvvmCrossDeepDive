using System;

namespace MvvmCrossMenu.Models
{
	public class BookSearchItem
	{
		public string Kind { get; set; }
		public string Id { get; set; }
		public VolumeInfo VolumeInfo { get; set; }

		public override string ToString()
		{
			return VolumeInfo.Title;
		}
	}
}

