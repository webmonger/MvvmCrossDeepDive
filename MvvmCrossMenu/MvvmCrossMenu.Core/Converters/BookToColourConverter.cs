using System;
using Cirrious.CrossCore.Converters;
using System;
using System.Globalization;
using MvvmCrossMenu.Models;
using Cirrious.CrossCore.UI;
using Cirrious.CrossCore;

namespace MvvmCrossMenu.Core.Converters
{
	public class BookToColourConverter : MvxValueConverter<string, object>
	{
		protected override object Convert(string value, Type targetType, object parameter, CultureInfo culture)
		{
			MvxColor colour =  MvxColors.Green;
			switch (value) {
			case "Book 1":
				colour = MvxColors.Aqua;
				break;
			case "Book 2":
				colour =  MvxColors.Beige;
				break;
			case "Book 3":
				colour =  MvxColors.Orange;
				break;
			}

			var nativeColourConverter = Mvx.Resolve<IMvxNativeColor> ();

			return nativeColourConverter.ToNative (colour);
		}

//		public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//		{
//			//throw new NotImplementedException();
//		}
	}

}