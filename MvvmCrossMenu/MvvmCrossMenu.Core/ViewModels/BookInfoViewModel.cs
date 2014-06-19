using System;
using System.Linq;
using Cirrious.MvvmCross.ViewModels;
using MvvmCrossMenu.Services;
using MvvmCrossMenu.Models;
using System.Collections.Generic;

namespace MvvmCrossMenu.Core
{
	public class BookInfoViewModel : MvxViewModel
	{
		List<BookSearchItem> _booksList;
		BookSearchItem _selectedItem;
		public BookInfoViewModel (IBooksService booksService)
		{
			_booksList = booksService.GetBooks();
		}

		private string _title;
		public string Title
		{
			get { return _title; }
			set { _title = value; RaisePropertyChanged(() => Title); }
		}

		private string _authors;
		public string Authors
		{
			get { return _authors; }
			set { _authors = value; RaisePropertyChanged(() => Authors); }
		}

		private string _id;
		public string Id
		{
			get { return _id; }
			set { _id = value; RaisePropertyChanged(() => Id); }
		}

		public IMvxCommand CloseView {
			get { return new MvxCommand (() => Close (this)); } 
		}

		public void Init (Parameters parameters)
		{
			_selectedItem = _booksList.FirstOrDefault (x => x.Id == parameters.Id);
			SetupViewModel ();
		}

		void SetupViewModel ()
		{
			Id = _selectedItem.Id;
			Title = _selectedItem.VolumeInfo.Title;
			Authors = _selectedItem.VolumeInfo.AuthorSummary;
		}

		public class Parameters{
			public string Id { get; set;}
		}
	}
}

