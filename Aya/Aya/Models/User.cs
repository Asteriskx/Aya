using System.Collections.Generic;

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
		public string ServiceName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public List<string> FileName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string Progress { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string Status { get; set; }

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
