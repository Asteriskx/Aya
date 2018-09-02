using System.Threading.Tasks;

namespace Aya.Models.Service
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class Service
	{
		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public abstract string Name { get; }

		/// <summary>
		/// 
		/// </summary>
		public abstract bool IsInstalled { get; }

		/// <summary>
		/// 
		/// </summary>
		public abstract bool IsSetting { get; }

		/// <summary>
		/// 
		/// </summary>
		public bool Enabled { get; set; } = true;

		/// <summary>
		/// 
		/// </summary>
		public string AccountName { get; set; }

		#endregion Properties

		#region public abstract methods

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public abstract Task<bool> Install();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public abstract Task Setup();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public abstract Task Setting();

		#endregion public abstract methods
	}
}
