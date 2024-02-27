namespace Navegacion.Views.Content;

public partial class Page1 : ContentPage
{
	List<Item> items = new()
	{
		new Item(){Name = "Origen", Description="Mexicano"},
        new Item(){Name = "Profesion", Description="Actor, escritor y comediante"},
        new Item(){Name = "Personaje más famoso", Description="\"El chavo del 8\" y \"El champulin colorado\""}
    };

	public Page1()
	{
		InitializeComponent();
	}

	public class Item
	{
		public required string Name { get; set; }
		public required string Description { get; set; }
	}
}