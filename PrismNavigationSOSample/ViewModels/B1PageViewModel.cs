using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrismNavigationSOSample.ViewModels
{
	public class B1PageViewModel
	{
		private readonly INavigationService m_navigationService;

		public B1PageViewModel(INavigationService navigationService)
		{
			m_navigationService = navigationService;
			SaveCommand = new Command(Save);
		}

		public ICommand SaveCommand { protected set; get; }

		public void Save(object obj)
		{
			if (m_navigationService != null)
			{
				m_navigationService.GoBackAsync();
			}
		}
	}
}