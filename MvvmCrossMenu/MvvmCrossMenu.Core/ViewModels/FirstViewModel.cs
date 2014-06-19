using Cirrious.MvvmCross.ViewModels;
using MvvmCrossMenu.Services;
using MvvmCrossMenu.Models;
using System.Collections.Generic;

namespace MvvmCrossMenu.Core.ViewModels
{
	public class FirstViewModel : MvxViewModel
	{
		IBooksService _booksService;

		public FirstViewModel (IBooksService booksService)
		{
			_booksService = booksService;
			Books = _booksService.GetBooks ();
		}

		private List<BookSearchItem> _books;
		public List<BookSearchItem> Books
		{
			get { return _books; }
			set { _books = value; RaisePropertyChanged(() => Books); }
		}

		public IMvxCommand ViewBookInfo {
			get {
				return new MvxCommand<BookSearchItem> ((item) => ShowSelectedView(item) );
			}
		}

		private void ShowSelectedView (BookSearchItem item)
		{
			ShowViewModel<BookInfoViewModel> (new BookInfoViewModel.Parameters () {
				Id = item.Id
			});
		}

		public void Init (Parameters parameters)
		{

		}

		public class Parameters{
			
		}
	}
}
