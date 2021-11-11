
namespace ElectronicSeal
{
	partial class KeiyakuList
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
			this.btnNew = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColKeiyakuCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColKeiyakuUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColTargetNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColTargetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(49, 47);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(116, 23);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "新規作成";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(185, 47);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(107, 23);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "編集";
			this.btnUpdate.UseVisualStyleBackColor = true;
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNo,
            this.ColKeiyakuCreateTime,
            this.ColKeiyakuUpdateTime,
            this.ColTargetNo,
            this.ColTargetName,
            this.ColStatus});
			this.dataGridView1.Location = new System.Drawing.Point(49, 100);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(802, 243);
			this.dataGridView1.TabIndex = 7;
			// 
			// ColNo
			// 
			this.ColNo.HeaderText = "契約番号";
			this.ColNo.Name = "ColNo";
			// 
			// ColKeiyakuCreateTime
			// 
			this.ColKeiyakuCreateTime.HeaderText = "契約作成日時";
			this.ColKeiyakuCreateTime.Name = "ColKeiyakuCreateTime";
			this.ColKeiyakuCreateTime.Width = 120;
			// 
			// ColKeiyakuUpdateTime
			// 
			this.ColKeiyakuUpdateTime.HeaderText = "契約更新日時";
			this.ColKeiyakuUpdateTime.Name = "ColKeiyakuUpdateTime";
			this.ColKeiyakuUpdateTime.Width = 120;
			// 
			// ColTargetNo
			// 
			this.ColTargetNo.HeaderText = "契約対象者No";
			this.ColTargetNo.Name = "ColTargetNo";
			this.ColTargetNo.Width = 120;
			// 
			// ColTargetName
			// 
			this.ColTargetName.HeaderText = "契約対象者名";
			this.ColTargetName.Name = "ColTargetName";
			this.ColTargetName.Width = 120;
			// 
			// ColStatus
			// 
			this.ColStatus.HeaderText = "契約状況";
			this.ColStatus.Name = "ColStatus";
			// 
			// KeiyakuList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 376);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnNew);
			this.Name = "KeiyakuList";
			this.Text = "契約一覧";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColKeiyakuCreateTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColKeiyakuUpdateTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTargetNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTargetName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
	}
}

