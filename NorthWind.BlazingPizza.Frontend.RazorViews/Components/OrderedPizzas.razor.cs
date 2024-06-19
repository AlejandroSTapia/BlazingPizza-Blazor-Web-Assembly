namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
	public partial class OrderedPizzas
	{
		[Parameter]
		public ShoppingCart ShoppingCart { get; set; }
	}
}