namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class TopBar
    {
        private string ImagePath =>
            string.Format("_content/{0}/Images",
                GetType().Assembly.GetName().Name);
    }
}