namespace NorthWind.BlazingPizza.EFCore.DataSources.Options
{
    public class DBOptions
	{
		public const string SectionKey = nameof(DBOptions);
		public string ConnectionString { get; set; }
	}
}
