namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
	public partial class Index
	{
		[Inject]
		IndexViewModel ViewModel { get; set; }

		[Inject]
		ShoppingCart ShoppingCart { get; set; }
	}
}