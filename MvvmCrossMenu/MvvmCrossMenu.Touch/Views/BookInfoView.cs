
using System;
using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MvvmCrossMenu.Core;

namespace MvvmCrossMenu.Touch
{
	public class BookInfoView : MvxViewController, IMvxModalTouchView
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public BookInfoView ()
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			View.BackgroundColor = UIColor.Green;

			UIButton myButton = new UIButton (new RectangleF (200, 50, 80, 20));
			myButton.SetTitle("Close", UIControlState.Normal);
			myButton.BackgroundColor = UIColor.Black;
//			myButton.TouchUpInside += (sender, e) => this.DismissViewController;
			Add (myButton);

			UILabel lableId = new UILabel (new RectangleF (20, 70, 280, 30));
			lableId.TintColor = UIColor.Red;
			Add (lableId);

			UILabel lableTitle = new UILabel (new RectangleF (20, 100, 280, 30));
			lableTitle.TintColor = UIColor.White;
			Add (lableTitle);

			UILabel lableAuthors = new UILabel (new RectangleF (20, 130, 280, 30));
			lableAuthors.TintColor = UIColor.Blue;
			Add (lableAuthors);


			var set = this.CreateBindingSet<BookInfoView, BookInfoViewModel> ();
			set.Bind(myButton).To(vm => vm.CloseView);
			set.Bind(lableId).To(vm => vm.Id);
			set.Bind(lableTitle).To(vm => vm.Title);
			set.Bind(lableAuthors).To(vm => vm.Authors);
			set.Apply ();

		}
	}
}

