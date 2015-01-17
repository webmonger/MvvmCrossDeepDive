using System;
using CoreGraphics;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvvmCrossMenu.Models;
using MvvmCrossMenu.Core.Converters;
using Cirrious.CrossCore.UI;
using Cirrious.MvvmCross.Plugins.Color.Touch;

namespace MvvmCrossMenu.Touch.Views.TableViewCells
{
	public partial class BookCell : MvxTableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("BookCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("BookCell");

		private readonly MvxImageViewLoader _loader;

		public BookCell (IntPtr handle) : base (handle)
		{
			_loader = new MvxImageViewLoader (() => MainImage);
			this.DelayBind (() => {
				var set = this.CreateBindingSet<BookCell, BookSearchItem> ();
				set.Bind (TitleLabel).To (item => item.VolumeInfo.Title);
				set.Bind (this).For (x => x.BackgroundColor).To (item => item.VolumeInfo.Title).WithConversion ("BookToColour");
				set.Bind (AuthorLabel).To (item => item.VolumeInfo.AuthorSummary);
				set.Bind (_loader).To (item => item.VolumeInfo.ImageLinks.Thumbnail); //smallThumbnail);
				set.Apply ();
			});
		}

		public static BookCell Create ()
		{
			return (BookCell)Nib.Instantiate (null, null) [0];
		}
	}
}