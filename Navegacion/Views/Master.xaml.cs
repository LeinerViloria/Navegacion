using Navegacion.Views.Content;

namespace Navegacion.Views;

public partial class Master : ContentPage
{
	public Master()
	{
		InitializeComponent();
	}

	private void Navigate<T>() where T : Page
	{
		var ViewInstance = Activator.CreateInstance<T>()!;

		App.flyoutPage.Detail.Navigation.PushAsync(ViewInstance);
		App.flyoutPage.IsPresented = false;
	}

	private void GoToPage1(object sender, EventArgs e)
	{
		Navigate<Chespirito>();
	}
}