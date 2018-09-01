using System.Windows.Forms;

namespace Aya.Utility
{
	/// <summary>
	/// ColumnHeader 拡張クラス
	/// </summary>
	public class ColumnHeaderEx : ColumnHeader
	{
		#region Constructor

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ColumnHeaderEx() : base() { }

		#endregion Constructor

		#region public static method

		/// <summary>
		/// 設定後の ColumnHeader を返却します。
		/// </summary>
		/// <param name="text">ヘッダに表示する文字列</param>
		/// <param name="width">ヘッダ幅</param>
		public static ColumnHeader GetColumnHeader(string text, int width)
		{
			var columnHeader = new ColumnHeader
			{
				Text = text,
				Width = width
			};
			return columnHeader;
		}

		#endregion public static method
	}
}
