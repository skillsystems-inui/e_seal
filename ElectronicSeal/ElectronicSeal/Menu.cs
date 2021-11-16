﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Drive.v3;
using System.IO;

namespace ElectronicSeal
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void btnKeiyaku_Click(object sender, EventArgs e)
		{
			KeiyakuList list = new KeiyakuList();
			list.ShowDialog();
		}

		private void btnGAccess_Click(object sender, EventArgs e)
		{
			//GoogleDriveアクセス 
			GoogleDriveAccess gda = new GoogleDriveAccess();
			gda.ShowDialog();
		}

		private void btnGAccessDownload_Click(object sender, EventArgs e)
		{
			//GoogleDriveアクセスダウンロード 
			GoogleDriveAccessDownload gda = new GoogleDriveAccessDownload();
			gda.ShowDialog();
		}

		private void btnOAccessUpload_Click(object sender, EventArgs e)
		{
			//OneDriveアクセスアップロード 
			OneDriveAccessUpload gda = new OneDriveAccessUpload();
			gda.ShowDialog();
		}

		private void btnOAccessDownload_Click(object sender, EventArgs e)
		{
			//OneDriveアクセスダウンロード 
			OneDriveAccessDownload gda = new OneDriveAccessDownload();
			gda.ShowDialog();
		}

		private void btnDAccessUpload_Click(object sender, EventArgs e)
		{
			//DropBoxアクセスアップロード 
			DropBoxAccessUpload gda = new DropBoxAccessUpload();
			gda.ShowDialog();
		}

		private void btnDAccessDownload_Click(object sender, EventArgs e)
		{
			//DropBoxアクセスダウンロード 
			DropBoxAccessDownload gda = new DropBoxAccessDownload();
			gda.ShowDialog();
		}
	}
}
