using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrismNavigationSOSample.ViewModels
{
	public class BPageViewModel
	{
		private readonly INavigationService m_navigationService;

		public BPageViewModel(INavigationService navigationService)
		{
			m_navigationService = navigationService;
			AddCommand = new Command(Add);
		}

		public ICommand AddCommand { protected set; get; }

		public void Add(object obj)
		{
			if (m_navigationService != null)
			{
				m_navigationService.NavigateAsync("NavigationPage/LayoutTabbedPage/BPage/B1Page");
			}
		}
	}
}