
namespace ElectronicSeal
{
	partial class Login
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnDAccessDownload = new System.Windows.Forms.Button();
			this.btnDAccessUpload = new System.Windows.Forms.Button();
			this.btnOAccessDownload = new System.Windows.Forms.Button();
			this.btnOAccessUpload = new System.Windows.Forms.Button();
			this.btnGAccessDownload = new System.Windows.Forms.Button();
			this.btnGAccess = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(168, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(168, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "パスワード";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(254, 55);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(178, 19);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(254, 93);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(178, 19);
			this.textBox2.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(170, 130);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(262, 23);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "ログイン";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnDAccessDownload
			// 
			this.btnDAccessDownload.Location = new System.Drawing.Point(170, 348);
			this.btnDAccessDownload.Name = "btnDAccessDownload";
			this.btnDAccessDownload.Size = new System.Drawing.Size(262, 23);
			this.btnDAccessDownload.TabIndex = 18;
			this.btnDAccessDownload.Text = "DropBoxダウンロード";
			this.btnDAccessDownload.UseVisualStyleBackColor = true;
			this.btnDAccessDownload.Click += new System.EventHandler(this.btnDAccessDownload_Click);
			// 
			// btnDAccessUpload
			// 
			this.btnDAccessUpload.Location = new System.Drawing.Point(170, 319);
			this.btnDAccessUpload.Name = "btnDAccessUpload";
			this.btnDAccessUpload.Size = new System.Drawing.Size(262, 23);
			this.btnDAccessUpload.TabIndex = 17;
			this.btnDAccessUpload.Text = "DropBoxアップロード";
			this.btnDAccessUpload.UseVisualStyleBackColor = true;
			this.btnDAccessUpload.Click += new System.EventHandler(this.btnDAccessUpload_Click);
			// 
			// btnOAccessDownload
			// 
			this.btnOAccessDownload.Location = new System.Drawing.Point(170, 280);
			this.btnOAccessDownload.Name = "btnOAccessDownload";
			this.btnOAccessDownload.Size = new System.Drawing.Size(262, 23);
			this.btnOAccessDownload.TabIndex = 16;
			this.btnOAccessDownload.Text = "OneDriveダウンロード";
			this.btnOAccessDownload.UseVisualStyleBackColor = true;
			this.btnOAccessDownload.Click += new System.EventHandler(this.btnOAccessDownload_Click);
			// 
			// btnOAccessUpload
			// 
			this.btnOAccessUpload.Location = new System.Drawing.Point(170, 251);
			this.btnOAccessUpload.Name = "btnOAccessUpload";
			this.btnOAccessUpload.Size = new System.Drawing.Size(262, 23);
			this.btnOAccessUpload.TabIndex = 15;
			this.btnOAccessUpload.Text = "OneDriveアップロード";
			this.btnOAccessUpload.UseVisualStyleBackColor = true;
			this.btnOAccessUpload.Click += new System.EventHandler(this.btnOAccessUpload_Click);
			// 
			// btnGAccessDownload
			// 
			this.btnGAccessDownload.Location = new System.Drawing.Point(170, 213);
			this.btnGAccessDownload.Name = "btnGAccessDownload";
			this.btnGAccessDownload.Size = new System.Drawing.Size(262, 23);
			this.btnGAccessDownload.TabIndex = 14;
			this.btnGAccessDownload.Text = "GoogleDriveダウンロード";
			this.btnGAccessDownload.UseVisualStyleBackColor = true;
			this.btnGAccessDownload.Click += new System.EventHandler(this.btnGAccessDownload_Click);
			// 
			// btnGAccess
			// 
			this.btnGAccess.Location = new System.Drawing.Point(170, 184);
			this.btnGAccess.Name = "btnGAccess";
			this.btnGAccess.Size = new System.Drawing.Size(262, 23);
			this.btnGAccess.TabIndex = 13;
			this.btnGAccess.Text = "GoogleDriveアップロード";
			this.btnGAccess.UseVisualStyleBackColor = true;
			this.btnGAccess.Click += new System.EventHandler(this.btnGAccess_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 386);
			this.Controls.Add(this.btnDAccessDownload);
			this.Controls.Add(this.btnDAccessUpload);
			this.Controls.Add(this.btnOAccessDownload);
			this.Controls.Add(this.btnOAccessUpload);
			this.Controls.Add(this.btnGAccessDownload);
			this.Controls.Add(this.btnGAccess);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = "ログイン";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnDAccessDownload;
		private System.Windows.Forms.Button btnDAccessUpload;
		private System.Windows.Forms.Button btnOAccessDownload;
		private System.Windows.Forms.Button btnOAccessUpload;
		private System.Windows.Forms.Button btnGAccessDownload;
		private System.Windows.Forms.Button btnGAccess;
	}
}

