
namespace ElectronicSeal
{
	partial class KeiyakuDetail
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
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(49, 47);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(116, 23);
			this.btnDownload.TabIndex = 4;
			this.btnDownload.Text = "ダウンロード";
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(770, 47);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(81, 23);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "閉じる";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(49, 93);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(802, 258);
			this.textBox1.TabIndex = 7;
			// 
			// KeiyakuDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 376);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDownload);
			this.Name = "KeiyakuDetail";
			this.Text = "契約詳細";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox textBox1;
	}
}

