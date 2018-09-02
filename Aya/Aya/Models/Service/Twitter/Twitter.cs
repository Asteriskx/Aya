using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aya.Models.Service.Twitter
{
	public class Twitter : Service
	{
		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public User[] User { get; private set; } = null;

		/// <summary>
		/// 
		/// </summary>
		public override string Name => "Twitter";

		/// <summary>
		/// 
		/// </summary>
		public override bool IsInstalled => false;

		/// <summary>
		/// 
		/// </summary>
		public override bool IsSetting => false;

		#endregion Properties

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public Twitter() : base() { }

		#endregion Constructor

		#region public override methods

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override async Task<bool> Install()
		{
			await this.Setup();
			return true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override Task Setting()
		{
			return Task.CompletedTask;
		}

		/// <summary>
		/// Service : Twitter の初期設定を行います。
		/// </summary>
		public override async Task Setup()
		{
			var idList = await FileReader.GetIdAsync();
			this.User = Enumerable.Range(0, idList.Count).Select(x => new User()).ToArray();

			// 取得した ID に紐付く User 情報を構築します。
			foreach (var list in idList.Select((value, idx) => new {value, idx}))
			{
				this.User[list.idx].Id = list.value;
				this.User[list.idx].ServiceName = this.Name;
				this.User[list.idx].FileName = new List<string>() { $"{Guid.NewGuid().ToString("N").Substring(0, 24)}.png" };
				this.User[list.idx].Progress = string.Format("{0} / {1} 件取得完了", new Random().Next(100), new Random().Next(idList.Count));
				this.User[list.idx].Status = "準備完了";
			}
		}

		#endregion public override methods
	}
}
