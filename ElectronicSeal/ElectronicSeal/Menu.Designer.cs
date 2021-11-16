
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
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 246);
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
	}
}

