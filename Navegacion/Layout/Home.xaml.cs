using Navegacion.Views;

namespace Navegacion.Layout;

public partial class Home : FlyoutPage
{
	public Home()
	{
		InitializeComponent();

		Flyout = new Master();
		Detail = new NavigationPage(new Detail());

		App.flyoutPage = this;
	}
}