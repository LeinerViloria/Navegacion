using Navegacion.Layout;

namespace Navegacion
{
    public partial class App : Application
    {
        internal static FlyoutPage flyoutPage { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new Home();
        }
    }
}
