﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Google.Apis.Drive.v3;
using System.IO;

namespace ElectronicSeal
{
	public partial class GoogleDriveAccess : Form
	{
		public GoogleDriveAccess()
		{
			InitializeComponent();
		}

		private void btnGAccess_Click(object sender, EventArgs e)
		{
			//閉じる
			this.Close();
		}

		static string[] Scopes = { DriveService.Scope.Drive };

		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = openFileDialog1.FileName;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
            FileStream fs = new FileStream("ipentectest-854e0153b985.json", FileMode.Open, FileAccess.Read);
            Google.Apis.Auth.OAuth2.GoogleCredential credential;
            try
            {
                credential = Google.Apis.Auth.OAuth2.GoogleCredential.FromStream(fs).CreateScoped(Scopes);
            }
            finally
            {
                fs.Close();
            }

            Google.Apis.Services.BaseClientService.Initializer init = new Google.Apis.Services.BaseClientService.Initializer();
            init.HttpClientInitializer = credential;
            init.ApplicationName = "My Test App";
            DriveService service = new DriveService(init);


            Google.Apis.Upload.IUploadProgress prog;
            FileStream fsu = new FileStream(textBox1.Text, FileMode.Open);
            try
            {
                //Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider fpv = new Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider();
                //string ContentType;
                //fpv.TryGetContentType(textBox1.Text, out ContentType);
                string ContentType = System.Web.MimeMapping.GetMimeMapping(textBox1.Text);

                Google.Apis.Drive.v3.Data.File meta = new Google.Apis.Drive.v3.Data.File();
                meta.Name = Path.GetFileName(textBox1.Text);
                meta.MimeType = ContentType;
                meta.Parents = new List<string>() { textBox2.Text };

                Google.Apis.Drive.v3.FilesResource.CreateMediaUpload req = service.Files.Create(meta, fsu, ContentType);
                req.Fields = "id, name";
                prog = req.Upload();
            }
            finally
            {
                fsu.Close();
            }

            textBox3.Text = string.Format("アップロードが完了しました。{0:d}byte", prog.BytesSent);
        }
	}
}
