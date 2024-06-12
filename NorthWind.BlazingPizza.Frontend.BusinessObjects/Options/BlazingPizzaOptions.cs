using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Options
{
	public class BlazingPizzaOptions
	{
		public const string SectionKey = nameof(BlazingPizzaOptions);
		public string WebApiBaseAddress { get; set; }

		public int DefaultPizzaSize { get; set; }
		public int MinimumPizzaSize { get; set; }
		public int MaximumPizzaSize {   get; set; }
		public int SizeIncrement { get;  set; }
		public int MaximumCustomPizzaToppings { get; set; }
	}
}
