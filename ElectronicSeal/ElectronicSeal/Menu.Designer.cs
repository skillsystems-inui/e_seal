
namespace ElectronicSeal
{
	partial class Menu
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.btnKeiyaku = new System.Windows.Forms.Button();
			this.btnInei = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnGAccess = new System.Windows.Forms.Button();
			this.btnGAccessDownload = new System.Windows.Forms.Button();
			this.btnOAccessDownload = new System.Windows.Forms.Button();
			this.btnOAccessUpload = new System.Windows.Forms.Button();
			this.btnDAccessDownload = new System.Windows.Forms.Button();
			this.btnDAccessUpload = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnKeiyaku
			// 
			this.btnKeiyaku.Location = new System.Drawing.Point(63, 47);
			this.btnKeiyaku.Name = "btnKeiyaku";
			this.btnKeiyaku.Size = new System.Drawing.Size(262, 23);
			this.btnKeiyaku.TabIndex = 4;
			this.btnKeiyaku.Text = "契約一覧";
			this.btnKeiyaku.UseVisualStyleBackColor = true;
			this.btnKeiyaku.Click += new System.EventHandler(this.btnKeiyaku_Click);
			// 
			// btnInei
			// 
			this.btnInei.Location = new System.Drawing.Point(63, 109);
			this.btnInei.Name = "btnInei";
			this.btnInei.Size = new System.Drawing.Size(262, 23);
			this.btnInei.TabIndex = 5;
			this.btnInei.Text = "印影　作成・登録";
			this.btnInei.UseVisualStyleBackColor = true;
			// 
			// btnUser
			// 
			this.btnUser.Location = new System.Drawing.Point(63, 172);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(262, 23);
			this.btnUser.TabIndex = 6;
			this.btnUser.Text = "ユーザー情報";
			this.btnUser.UseVisualStyleBackColor = true;
			// 
			// btnGAccess
			// 
			this.btnGAccess.Location = new System.Drawing.Point(63, 231);
			this.btnGAccess.Name = "btnGAccess";
			this.btnGAccess.Size = new System.Drawing.Size(262, 23);
			this.btnGAccess.TabIndex = 7;
			this.btnGAccess.Text = "GoogleDriveアップロード";
			this.btnGAccess.UseVisualStyleBackColor = true;
			this.btnGAccess.Click += new System.EventHandler(this.btnGAccess_Click);
			// 
			// btnGAccessDownload
			// 
			this.btnGAccessDownload.Location = new System.Drawing.Point(63, 260);
			this.btnGAccessDownload.Name = "btnGAccessDownload";
			this.btnGAccessDownload.Size = new System.Drawing.Size(262, 23);
			this.btnGAccessDownload.TabIndex = 8;
			this.btnGAccessDownload.Text = "GoogleDriveダウンロード";
			this.btnGAccessDownload.UseVisualStyleBackColor = true;
			this.btnGAccessDownload.Click += new System.EventHandler(this.btnGAccessDownload_Click);
			// 
			// btnOAccessDownload
			// 
			this.btnOAccessDownload.Location = new System.Drawing.Point(63, 327);
			this.btnOAccessDownload.Name = "btnOAccessDownload";
			this.btnOAccessDownload.Size = new System.Drawing.Size(262, 23);
			this.btnOAccessDownload.TabIndex = 10;
			this.btnOAccessDownload.Text = "OneDriveダウンロード";
			this.btnOAccessDownload.UseVisualStyleBackColor = true;
			this.btnOAccessDownload.Click += new System.EventHandler(this.btnOAccessDownload_Click);
			// 
			// btnOAccessUpload
			// 
			this.btnOAccessUpload.Location = new System.Drawing.Point(63, 298);
			this.btnOAccessUpload.Name = "btnOAccessUpload";
			this.btnOAccessUpload.Size = new System.Drawing.Size(262, 23);
			this.btnOAccessUpload.TabIndex = 9;
			this.btnOAccessUpload.Text = "OneDriveアップロード";
			this.btnOAccessUpload.UseVisualStyleBackColor = true;
			this.btnOAccessUpload.Click += new System.EventHandler(this.btnOAccessUpload_Click);
			// 
			// btnDAccessDownload
			// 
			this.btnDAccessDownload.Location = new System.Drawing.Point(63, 395);
			this.btnDAccessDownload.Name = "btnDAccessDownload";
			this.btnDAccessDownload.Size = new System.Drawing.Size(262, 23);
			this.btnDAccessDownload.TabIndex = 12;
			this.btnDAccessDownload.Text = "DropBoxダウンロード";
			this.btnDAccessDownload.UseVisualStyleBackColor = true;
			this.btnDAccessDownload.Click += new System.EventHandler(this.btnDAccessDownload_Click);
			// 
			// btnDAccessUpload
			// 
			this.btnDAccessUpload.Location = new System.Drawing.Point(63, 366);
			this.btnDAccessUpload.Name = "btnDAccessUpload";
			this.btnDAccessUpload.Size = new System.Drawing.Size(262, 23);
			this.btnDAccessUpload.TabIndex = 11;
			this.btnDAccessUpload.Text = "DropBoxアップロード";
			this.btnDAccessUpload.UseVisualStyleBackColor = true;
			this.btnDAccessUpload.Click += new System.EventHandler(this.btnDAccessUpload_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 433);
			this.Controls.Add(this.btnDAccessDownload);
			this.Controls.Add(this.btnDAccessUpload);
			this.Controls.Add(this.btnOAccessDownload);
			this.Controls.Add(this.btnOAccessUpload);
			this.Controls.Add(this.btnGAccessDownload);
			this.Controls.Add(this.btnGAccess);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.btnInei);
			this.Controls.Add(this.btnKeiyaku);
			this.Name = "Menu";
			this.Text = "メニュー";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnKeiyaku;
		private System.Windows.Forms.Button btnInei;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnGAccess;
		private System.Windows.Forms.Button btnGAccessDownload;
		private System.Windows.Forms.Button btnOAccessDownload;
		private System.Windows.Forms.Button btnOAccessUpload;
		private System.Windows.Forms.Button btnDAccessDownload;
		private System.Windows.Forms.Button btnDAccessUpload;
	}
}

