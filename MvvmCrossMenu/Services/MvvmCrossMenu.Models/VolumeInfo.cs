using System;
using System.Collections.Generic;

namespace MvvmCrossMenu.Models
{
	public class VolumeInfo
	{
		public string Title { get; set; }
		public List<string> Authors { get; set; }
		public string AuthorSummary
		{
			get { return Authors == null ? "-" : string.Join(", ", Authors); }
		}
		public string Publisher { get; set; }
		public string PublishedDate { get; set; }
		public string Descrption { get; set; }
		public int PageCount { get; set; }
		public double AverageRating { get; set; }
		public int RatingsCount { get; set; }
		public ImageLinks ImageLinks { get; set; }
		public string Language { get; set; }
		public string PreviewLink { get; set; }
		public string InfoLink { get; set; }
		public string CanonicalVolumeLink { get; set; }
	}
}

