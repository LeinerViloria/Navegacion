namespace Navegacion.Components;

public partial class ViewDescription : ContentView
{
    public ViewDescription()
    {
        InitializeComponent();
        BindingContext = this;
    }

    /*
     * <summary>
     *  Variable que permite que la propiedad "Image" se pueda usar con Binding en el xaml
     *  BindableProperty.Create(nombreDeLaVariable, tipo de la variable, nombre de la clase actual)
     * </summary>
     */
    public static readonly BindableProperty ImageProperty =
         BindableProperty.Create(nameof(Image), typeof(string), typeof(ViewDescription));

    public string Image 
    {
        get { return (string)GetValue(ImageProperty); }
        set { SetValue(ImageProperty, value); }
    }

    /*
     * <summary>
     *  Variable que permite que la propiedad "Title" se pueda usar con Binding en el xaml
     *  BindableProperty.Create(nombreDeLaVariable, tipo de la variable, nombre de la clase actual)
     * </summary>
     */
    public static readonly BindableProperty TitleProperty =
         BindableProperty.Create(nameof(Title), typeof(string), typeof(ViewDescription));

    public string Title 
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }

    /*
     * <summary>
     *  Variable que permite que la propiedad "SubTitle" se pueda usar con Binding en el xaml
     *  BindableProperty.Create(nombreDeLaVariable, tipo de la variable, nombre de la clase actual)
     * </summary>
     */
    public static readonly BindableProperty SubTitleProperty =
         BindableProperty.Create(nameof(SubTitle), typeof(string), typeof(ViewDescription));

    public string SubTitle
    {
        get { return (string)GetValue(SubTitleProperty); }
        set { SetValue(SubTitleProperty, value); }
    }
    /*
     * <summary>
     *  Variable que permite que la propiedad "Description" se pueda usar con Binding en el xaml
     *  BindableProperty.Create(nombreDeLaVariable, tipo de la variable, nombre de la clase actual)
     * </summary>
     */
    public static readonly BindableProperty DescriptionProperty =
         BindableProperty.Create(nameof(Description), typeof(string), typeof(ViewDescription));

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }
}