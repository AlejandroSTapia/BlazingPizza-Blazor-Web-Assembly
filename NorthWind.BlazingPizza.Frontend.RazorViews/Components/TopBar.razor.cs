namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class TopBar
    {
        string ImagePath =>
            string.Format("_content/{0}/images",
                GetType().Assembly.GetName().Name); //se obtiene el namespace del ensamblado
    }
}