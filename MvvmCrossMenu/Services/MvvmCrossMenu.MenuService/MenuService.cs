﻿using System.Collections.Generic;
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
					Title = "First View",
					ViewType = MenuType.FirstView
				},
//				new MenuItem()
//				{
//					Title = "Second View",
//					ViewType = MenuType.SecondView;
//				},
			};
		}
	}
}

