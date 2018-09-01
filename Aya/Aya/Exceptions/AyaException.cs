using System;
using System.Runtime.Serialization;

namespace Aya.Exceptions
{
	/// <summary>
	/// Aya で起きた例外を管理します。
	/// </summary>
	[Serializable()]
	public class AyaException : Exception
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		public AyaException() : base("") { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="msg"></param>
		public AyaException(string msg) : base(msg) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="inner"></param>
		public AyaException(string msg, Exception inner) : base(msg, inner) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AyaException(SerializationInfo info, StreamingContext context) { }

		#endregion Constructors
	}
}
