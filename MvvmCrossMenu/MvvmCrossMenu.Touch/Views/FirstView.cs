using System.Collections.Generic;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using Foundation;
using UIKit;
using CoreGraphics;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MvvmCrossMenu.Touch.Views.TableViewCells;

namespace MvvmCrossMenu.Touch.Views
{
    [Register("FirstView")]
	public partial class FirstView : MvxViewController
    {
        public FirstView()
		{

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var tableView = new UITableView (new CGRect (0, 0, 320, 560), UITableViewStyle.Plain);

			Add (tableView);

			tableView.RowHeight = 88;
			var source = new MvxSimpleTableViewSource (tableView, BookCell.Key, BookCell.Key);
			tableView.Source = source;

			var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel> ();
			set.Bind(source).To(vm => vm.Books);
			set.Bind(source).For(s=>s.SelectionChangedCommand).To(vm => vm.ViewBookInfo);
			set.Apply ();
		}
    }
}