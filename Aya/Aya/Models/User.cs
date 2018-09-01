using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aya.Models
{
	public class User
	{
		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string Service { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public bool IsDownload { get; set; } = true;

		/// <summary>
		/// 
		/// </summary>
		public bool IsLimit { get; set; } = false;

		#endregion Properties
	}
}
