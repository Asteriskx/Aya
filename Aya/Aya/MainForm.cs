using Aya.Exceptions;
using Aya.Models;
using Aya.Utility;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aya
{
	public partial class MainForm : Form
	{
		#region Property
		
		/// <summary>
		/// 
		/// </summary>
		private User _User { get; set; }

		#endregion Property

		#region Constructor

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm() => InitializeComponent();

		#endregion Constructor

		#region Event Method

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				this._InitializeResultView();
			}
			catch (Exception ex)
			{
				throw new AyaException(ex.Message);
			}
			finally
			{
			}
		}

		private void SearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				throw new AyaException(ex.Message);
			}
			finally
			{
			}
		}

		private void ResultView_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				throw new AyaException(ex.Message);
			}
			finally
			{
			}
		}

		#endregion Event Method

		#region Private Method

		/// <summary>
		/// 取得リストビューの初期設定を行います。
		/// </summary>
		private void _InitializeResultView()
		{
			try
			{
				var data = new Dictionary<string, int>()
				{
					{ "ID", 200 },
					{ "サービス名", 150 },
					{ "ファイル名", 300 },
					{ "進捗状況", 130 },
					{ "ステータス", 130 }
				};

				this.ResultView.FullRowSelect = true;
				this.ResultView.GridLines = true;
				this.ResultView.Sorting = SortOrder.Ascending;
				this.ResultView.View = View.Details;

				foreach (var kvp in data)
				{
					this.ResultView.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
				}
			}
			catch (Exception ex)
			{
				throw new AyaException(ex.Message);
			}
			finally
			{
			}
		}

		#endregion Private Method
	}
}
