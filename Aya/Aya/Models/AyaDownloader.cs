using Aya.Exceptions;

using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Aya.Models
{
	/// <summary>
	/// Aya 上での画像ファイルダウンロードを管理します。
	/// </summary>
	public class AyaDownloader
	{
		#region Properties

		/// <summary>
		/// HttpClient
		/// </summary>
		private HttpClient _HttpClient { get; set; } = new HttpClient();

		/// <summary>
		/// 進捗状況更新通知
		/// </summary>
		public Action<DownloadProgressChangedEventArgs> DownloadProgressChanged { get; set; } = null;

		/// <summary>
		/// ダウンロード成功通知
		/// </summary>
		public Action<AsyncCompletedEventArgs> DownloadFileCompleted { get; set; } = null;

		/// <summary>
		/// ダウンロード失敗通知
		/// </summary>
		public Action<AsyncCompletedEventArgs> DownloadFileFailed { get; set; } = null;

		#endregion Properties

		#region Constructor

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public AyaDownloader() { }

		/// <summary>
		/// Twing より 非同期 にて画像のダウンロードを実施します。
		/// </summary>
		/// <param name="url"></param>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public async Task<bool> DownloadImageFromTwingAsync(string[] urls, string filePath)
		{
			try
			{
				using (var client = new HttpClient())
					await Task.WhenAll(urls.Select((url, i) => this._DownloadImageFromTwingAsync(url, $"{filePath}.jpg")));

				return true;
			}
			catch (Exception ex)
			{
				throw new AyaException(ex.Message);
			}
			finally
			{
			}
		}

		#endregion public methods

		#region private methods

		/// <summary>
		/// Twing より 非同期 にて画像のダウンロードを実施します。
		/// </summary>
		/// <param name="url"></param>
		/// <param name="filePath"></param>
		/// <returns></returns>
		private async Task<bool> _DownloadImageFromTwingAsync(string url, string filePath)
		{
			try
			{
				using (var message = await this._HttpClient.GetAsync(new Uri(url), HttpCompletionOption.ResponseHeadersRead))
				using (var fileStream = File.Create(filePath))
				using (var response = await message.Content.ReadAsStreamAsync())
					await response.CopyToAsync(fileStream);

				return true;
			}
			catch (Exception ex)
			{
				throw new AyaException(ex.Message);
			}
			finally
			{
			}
		}

		#endregion private methods
	}
}
