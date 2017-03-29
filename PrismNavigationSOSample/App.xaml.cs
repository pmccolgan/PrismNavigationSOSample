using Prism.Unity;
using PrismNavigationSOSample.Views;
using Xamarin.Forms;

namespace PrismNavigationSOSample
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("NavigationPage/LayoutTabbedPage/APage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<LayoutTabbedPage>();
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<APage>();
			Container.RegisterTypeForNavigation<BPage>();
			Container.RegisterTypeForNavigation<B1Page>();
			Container.RegisterTypeForNavigation<CPage>();
		}
	}
}

