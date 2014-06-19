using System;
using System.Collections.Generic;
using MvvmCrossMenu.Models;

namespace MvvmCrossMenu.Services
{
	public class BooksService
		: IBooksService
	{
		public BooksService()
		{

		}

		public List<BookSearchItem> GetBooks()
		{
			var books = new List<BookSearchItem> (){
				new BookSearchItem(){
					Id = "12345",
					Kind = "abcde",
					VolumeInfo = new VolumeInfo(){
						Title = "Book 1",
						Authors = new List<string>(){
							"Author 1","Author 2","Author 3",
						},
						ImageLinks = new ImageLinks(){
							SmallThumbnail = "",
							Thumbnail = ""
						}
					}
				},
				new BookSearchItem(){
					Id = "54321",
					Kind = "abcde",
					VolumeInfo = new VolumeInfo(){
						Title = "Book 2",
						Authors = new List<string>(){
							"Author 1","Author 2","Author 3",
						},
						ImageLinks = new ImageLinks(){
							SmallThumbnail = "",
							Thumbnail = ""
						}
					}
				},
				new BookSearchItem(){
					Id = "67890",
					Kind = "abcde",
					VolumeInfo = new VolumeInfo(){
						Title = "Book 3",
						Authors = new List<string>(){
							"Author 1","Author 2","Author 3",
						},
						ImageLinks = new ImageLinks(){
							SmallThumbnail = "",
							Thumbnail = ""
						}
					}
				},
			};


			return books;
		}
	}
}

