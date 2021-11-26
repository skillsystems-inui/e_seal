
namespace ElectronicSeal
{
	partial class ManageExcel
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.btnToPdf = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(580, 412);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(125, 23);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "閉じる";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnGAccess_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(518, 19);
			this.textBox1.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(564, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Excel起動";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(564, 49);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Excel終了";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(42, 78);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(516, 27);
			this.textBox3.TabIndex = 13;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(42, 111);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(663, 295);
			this.webBrowser1.TabIndex = 14;
			// 
			// btnToPdf
			// 
			this.btnToPdf.Location = new System.Drawing.Point(564, 78);
			this.btnToPdf.Name = "btnToPdf";
			this.btnToPdf.Size = new System.Drawing.Size(132, 23);
			this.btnToPdf.TabIndex = 15;
			this.btnToPdf.Text = "PDFに変換";
			this.btnToPdf.UseVisualStyleBackColor = true;
			this.btnToPdf.Click += new System.EventHandler(this.btnToPdf_Click);
			// 
			// ManageExcel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 447);
			this.Controls.Add(this.btnToPdf);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnClose);
			this.Name = "ManageExcel";
			this.Text = "ManageExcel";
			this.Load += new System.EventHandler(this.ManageExcel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Button btnToPdf;
	}
}

