using System;
using Xamarin.Forms;

namespace PrismNavigationSOSample.Views
{
	public partial class LayoutTabbedPage : TabbedPage
	{
		public LayoutTabbedPage()
		{
			InitializeComponent();
		}

		// link page title to tab title, can't be done through binding
		private void onCurrentPageChanged(object sender, EventArgs e)
		{
			var tabbedPage = sender as TabbedPage;

			if (tabbedPage != null)
			{
				var currentPage = tabbedPage.CurrentPage;

				if (currentPage != null)
				{
					this.Title = currentPage.Title;
				}
			}
		}
	}
}