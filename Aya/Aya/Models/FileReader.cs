using Aya.Exceptions;

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aya.Models
{
	/// <summary>
	/// Aya 内でのファイル読み込み管理クラス
	/// </summary>
	public static class FileReader
	{
		#region public static async method

		/// <summary>
		/// ダウンロード対象IDを非同期にて取得します。
		/// </summary>
		/// <returns> 読み込んだID一覧(List 形式) </returns>
		public static async Task<List<string>> GetIdAsync()
		{
			try
			{
				MessageBox.Show("IDファイルの場所を指定してください。", "IDファイル指定", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

				var list = await _IdFileReadAsync();
				list.Sort();

				foreach (var id in list)
				{
					Console.WriteLine($"id = {id}");
				}

				Console.WriteLine($"取得対象 ID = {list.Count} 件");
				return list;
			}
			catch (Exception ex)
			{
				throw new AyaException(ex.Message);
			}
			finally
			{
			}
		}

		#endregion public static async method

		#region private static async method

		/// <summary>
		/// IDファイルの内容を非同期にて読み込みます。
		/// </summary>
		/// <returns> 読み込んだID一覧(List 形式) </returns>
		private static async Task<List<string>> _IdFileReadAsync()
		{
			try
			{
				var dialog = new OpenFileDialog();
				var idList = new List<string>();

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					using (var reader = new StreamReader(dialog.FileName, Encoding.GetEncoding("shift_jis")))
					{
						while (!reader.EndOfStream)
						{
							idList.Add(reader.ReadLine());
							await Task.Delay(1);
						}
					}
				}

				return idList;
			}
			catch (Exception ex)
			{
				throw new AyaException(ex.Message);
			}
			finally
			{
			}
		}

		#endregion private static async method
	}
}
