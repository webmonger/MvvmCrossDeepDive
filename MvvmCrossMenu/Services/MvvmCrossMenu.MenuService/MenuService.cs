using System.Collections.Generic;
using MvvmCrossMenu.Models;

namespace MvvmCrossMenu.Services
{
	public class MenuService : IMenuService
	{
		public MenuService ()
		{
			
		}
		public List<MenuItem> GetMenuItems ()
		{
			return new List<MenuItem>
			{
				new MenuItem()
				{
					Title = "Item 1",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 2",
					ViewType = MenuType.SecondView
				},
				new MenuItem()
				{
					Title = "Item 3",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 4",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 5",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 6",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 7",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 8",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 9",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 10",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 11",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 12",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 13",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 14",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 15",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 16",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 17",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 18",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 19",
					ViewType = MenuType.FirstView
				},
				new MenuItem()
				{
					Title = "Item 20",
					ViewType = MenuType.FirstView
				}
			};
		}
	}
}

