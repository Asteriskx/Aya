using Aya.Exceptions;
using Aya.Models.Service.Twitter;
using Aya.Utility;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Aya
{
	public partial class MainForm : Form
	{
		#region Property

		/// <summary>
		/// 
		/// </summary>
		private Twitter _Twitter { get; set; } = new Twitter();

		#endregion Property

		#region Constructor

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm() => InitializeComponent();

		#endregion Constructor

		#region Event Method

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				if (!this._Twitter.IsInstalled)
				{
					await this._Twitter.Install();
				}
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResultView_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.ResultView.SelectedItems.Count > 0)
				{
					var id = this.ResultView.Items[this.ResultView.SelectedItems[0].Index].Text.Replace("@", "");
					var url = "https://twitter.com/" + id;
					Process.Start(url);
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

				// ヘッダ追加
				foreach (var kvp in data)
				{
					this.ResultView.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
				}

				foreach (var user in this._Twitter.User)
				{
					var parentItem = this.ResultView.Items.Add(user.Id);
					parentItem.SubItems.Add(user.ServiceName);

					foreach (var file in user.FileName)
						parentItem.SubItems.Add(file);
					
					parentItem.SubItems.Add(user.Progress);
					parentItem.SubItems.Add(user.Status);
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
