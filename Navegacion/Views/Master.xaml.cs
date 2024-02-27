using Navegacion.Views.Content;

namespace Navegacion.Views;

public partial class Master : ContentPage
{
	public Master()
	{
		InitializeComponent();
	}

    /*
     * <summary>
     *  Se hace uso de los genericos
     *  En este caso es T
     *  
     *  Activator.CreateInstance<T>() ==> new PageX();
     *  T debe heredar de ContentPages
     * </sumary>
     */
    private void Navigate<T>() where T : Page
	{
		var ViewInstance = Activator.CreateInstance<T>();

		App.flyoutPage.Detail.Navigation.PushAsync(ViewInstance);
		App.flyoutPage.IsPresented = false;
	}

	private void GoToPage1(object sender, EventArgs e)
	{
		Navigate<Page1>();
	}

    private void GoToPage2(object sender, EventArgs e)
    {
        Navigate<Page2>();
    }

    private void GoToPage3(object sender, EventArgs e)
    {
        Navigate<Page3>();
    }

    private void GoToPage4(object sender, EventArgs e)
    {
        Navigate<Page4>();
    }

    private void GoToPage5(object sender, EventArgs e)
    {
        Navigate<Page5>();
    }

    private void GoToPage6(object sender, EventArgs e)
    {
        Navigate<Page6>();
    }

    private void GoToPage7(object sender, EventArgs e)
    {
        Navigate<Page7>();
    }

    private void GoToPage8(object sender, EventArgs e)
    {
        Navigate<Page8>();
    }

    private void GoToPage9(object sender, EventArgs e)
    {
        Navigate<Page9>();
    }

    private void GoToPage10(object sender, EventArgs e)
    {
        Navigate<Page10>();
    }
}