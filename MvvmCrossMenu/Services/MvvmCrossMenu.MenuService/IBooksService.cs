using System;
using System.Collections.Generic;
using MvvmCrossMenu.Models;

namespace MvvmCrossMenu.Services
{
	public interface IBooksService
	{
		List<BookSearchItem> GetBooks();
	}
}

