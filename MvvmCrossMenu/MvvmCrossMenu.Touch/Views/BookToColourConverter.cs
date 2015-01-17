using System.Collections.Generic;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using Foundation;
using UIKit;
using CoreGraphics;
using Cirrious.MvvmCross.Binding.Touch.Views;
using MvvmCrossMenu.Touch.Views.TableViewCells;
using Cirrious.CrossCore.Converters;
using System;
using System.Globalization;
using MvvmCrossMenu.Models;

namespace MvvmCrossMenu.Touch.Views
{
	public class BookToColourConverter : MvxValueConverter<string, UIColor>
	{
		protected override UIColor Convert(string value, Type targetType, object parameter, CultureInfo culture)
		{
			switch (value) {
			case "Book 1":
				return UIColor.Cyan;
			case "Book 2":
				return UIColor.Green;
			case "Book 3":
				return UIColor.Yellow;
			default:
				return UIColor.Orange;
			}
		}

//		public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//		{
//			//throw new NotImplementedException();
//		}
	}

}