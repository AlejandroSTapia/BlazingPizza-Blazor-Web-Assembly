using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.EFCore.DataSources.Options
{
	public class DBOptions
	{
		public const string SectionKey = nameof(DBOptions);
		public string ConnectionString { get; set; }
	}
}
