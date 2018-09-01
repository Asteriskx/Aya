using System;
using System.Windows.Forms;

namespace Aya
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.SearchButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SearchBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.InfoGroup = new System.Windows.Forms.GroupBox();
			this.PauseButton = new System.Windows.Forms.Button();
			this.ListGroup = new System.Windows.Forms.GroupBox();
			this.ResultView = new System.Windows.Forms.ListView();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.InfoGroup.SuspendLayout();
			this.ListGroup.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(676, 34);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(122, 35);
			this.SearchButton.TabIndex = 9;
			this.SearchButton.Text = "取得開始";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "取得ID（オプション）：";
			// 
			// SearchBox
			// 
			this.SearchBox.BackColor = System.Drawing.Color.Black;
			this.SearchBox.ForeColor = System.Drawing.Color.White;
			this.SearchBox.Location = new System.Drawing.Point(175, 31);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(462, 25);
			this.SearchBox.TabIndex = 4;
			this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 18);
			this.label3.TabIndex = 7;
			// 
			// InfoGroup
			// 
			this.InfoGroup.Controls.Add(this.PauseButton);
			this.InfoGroup.Controls.Add(this.label1);
			this.InfoGroup.Controls.Add(this.SearchBox);
			this.InfoGroup.Controls.Add(this.SearchButton);
			this.InfoGroup.Controls.Add(this.label3);
			this.InfoGroup.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.InfoGroup.ForeColor = System.Drawing.Color.White;
			this.InfoGroup.Location = new System.Drawing.Point(12, 505);
			this.InfoGroup.Name = "InfoGroup";
			this.InfoGroup.Size = new System.Drawing.Size(945, 78);
			this.InfoGroup.TabIndex = 9;
			this.InfoGroup.TabStop = false;
			this.InfoGroup.Text = "Information";
			// 
			// PauseButton
			// 
			this.PauseButton.Location = new System.Drawing.Point(804, 34);
			this.PauseButton.Name = "PauseButton";
			this.PauseButton.Size = new System.Drawing.Size(122, 35);
			this.PauseButton.TabIndex = 0;
			this.PauseButton.Text = "一時停止";
			// 
			// ListGroup
			// 
			this.ListGroup.Controls.Add(this.ResultView);
			this.ListGroup.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ListGroup.ForeColor = System.Drawing.Color.White;
			this.ListGroup.Location = new System.Drawing.Point(12, 12);
			this.ListGroup.Name = "ListGroup";
			this.ListGroup.Size = new System.Drawing.Size(945, 487);
			this.ListGroup.TabIndex = 10;
			this.ListGroup.TabStop = false;
			this.ListGroup.Text = "取得情報";
			// 
			// ResultView
			// 
			this.ResultView.BackColor = System.Drawing.Color.Black;
			this.ResultView.ForeColor = System.Drawing.Color.White;
			this.ResultView.Location = new System.Drawing.Point(13, 22);
			this.ResultView.Name = "ResultView";
			this.ResultView.Size = new System.Drawing.Size(913, 448);
			this.ResultView.TabIndex = 0;
			this.ResultView.UseCompatibleStateImageBehavior = false;
			this.ResultView.SelectedIndexChanged += new System.EventHandler(this.ResultView_SelectedIndexChanged);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.DodgerBlue;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 595);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(969, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
			this.toolStripStatusLabel1.Text = "準備完了";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar1.Step = 100;
			this.toolStripProgressBar1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(969, 617);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.ListGroup);
			this.Controls.Add(this.InfoGroup);
			this.Name = "MainForm";
			this.Text = "Aya";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.InfoGroup.ResumeLayout(false);
			this.InfoGroup.PerformLayout();
			this.ListGroup.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SearchButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SearchBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox InfoGroup;
		private System.Windows.Forms.GroupBox ListGroup;
		private System.Windows.Forms.ListView ResultView;
		private System.Windows.Forms.Button PauseButton;
		private NotifyIcon notifyIcon1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripProgressBar toolStripProgressBar1;
	}
}

