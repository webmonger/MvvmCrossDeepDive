using Foundation;

namespace MvvmCrossMenu.Touch.Views
{
	partial class RootView
	{
		[Outlet]
		UIKit.UITextView CenterText { get; set; }

		[Outlet]
		UIKit.UIImageView RightArrowImage { get; set; }

		[Outlet]
		UIKit.UIImageView LeftArrowImage { get; set; }

		[Outlet]
		UIKit.UIImageView UpArrowImage { get; set; }

		[Outlet]
		UIKit.UITextView NavigateText { get; set; }

		[Outlet]
		UIKit.UIButton NavigateButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CenterText != null) {
				CenterText.Dispose ();
				CenterText = null;
			}

			if (RightArrowImage != null) {
				RightArrowImage.Dispose ();
				RightArrowImage = null;
			}

			if (LeftArrowImage != null) {
				LeftArrowImage.Dispose ();
				LeftArrowImage = null;
			}

			if (UpArrowImage != null) {
				UpArrowImage.Dispose ();
				UpArrowImage = null;
			}

			if (NavigateText != null) {
				NavigateText.Dispose ();
				NavigateText = null;
			}

			if (NavigateButton != null) {
				NavigateButton.Dispose ();
				NavigateButton = null;
			}
		}
	}
}

