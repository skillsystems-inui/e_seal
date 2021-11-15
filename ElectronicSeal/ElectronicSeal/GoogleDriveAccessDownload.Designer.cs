
namespace ElectronicSeal
{
	partial class GoogleDriveAccessDownload
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
			this.btnClose = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(596, 341);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(125, 23);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "閉じる";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnGAccess_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(130, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(566, 19);
			this.textBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(40, 113);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(656, 222);
			this.textBox2.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 84);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "ダウンロード実行";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 12);
			this.label1.TabIndex = 12;
			this.label1.Text = "ダウンロードID";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 13;
			this.label2.Text = "出力先";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(130, 49);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(480, 19);
			this.textBox3.TabIndex = 14;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(616, 47);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "選択";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// GoogleDriveAccessDownload
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 376);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnClose);
			this.Name = "GoogleDriveAccessDownload";
			this.Text = "GoogleDriveAccessDownload";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

