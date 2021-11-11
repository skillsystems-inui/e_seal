using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using Microsoft.Graph;

namespace ElectronicSeal
{
	public partial class KeiyakuDetail : Form
	{
	
		public KeiyakuDetail()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			//画面を閉じる
			this.Close();
		}

		public static IPublicClientApplication PublicClientApp;
		private string ClientId = "093e6c05-7227-4b80-bd79-2ef280a3f869";
		private string TenantId = "f8cdef31-a31e-4b4a-93e4-5f571e91255a";

		private async void btnDownload_Click(object sender, EventArgs e)
		{
			//--フォルダ一覧取得--
			{
				PublicClientApplicationBuilder app = PublicClientApplicationBuilder.Create(ClientId);
				app = app.WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient");
				app = app.WithAuthority(AzureCloudInstance.AzurePublic, TenantId);
				PublicClientApp = app.Build();

				string[] scopes = new string[] { "User.ReadWrite.All" };
				string password = "system4199";
				System.Security.SecureString secpass = new System.Security.SecureString();

				foreach (char c in password) secpass.AppendChar(c);

				AcquireTokenByUsernamePasswordParameterBuilder builder = PublicClientApp.AcquireTokenByUsernamePassword(scopes, "k-inui@sic-net.co.jp", secpass);
				AuthenticationResult authResult = await builder.ExecuteAsync();

				DelegateAuthenticationProvider prov = new DelegateAuthenticationProvider(
				  (requestMessage) =>
				  {
					  requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", authResult.AccessToken);
					  return Task.FromResult(0);
				  }
				  );
				GraphServiceClient client = new GraphServiceClient(prov);

				IDriveItemChildrenCollectionPage items = await client.Me.Drive.Root.Children.Request().GetAsync();

				foreach (DriveItem item in items)
				{
					if (item.Folder == null)
					{
						textBox1.Text += string.Format("{0}\r\n", item.Name);
					}
					else
					{
						textBox1.Text += string.Format("{0}\tフォルダ\r\n", item.Name);
					}
				}
			}
			//--.フォルダ一覧取得--

			/* --ダウンロードは後回しのためコメントアウト--
			//ダウンロード実行
			PublicClientApplicationBuilder app = PublicClientApplicationBuilder.Create(ClientId);
			app = app.WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient");
			app = app.WithAuthority(AzureCloudInstance.AzurePublic, TenantId);
			PublicClientApp = app.Build();
			//
			string[] scopes = new string[] { "User.ReadWrite.All" };
			string password = "(OneDriveにサインインするアカウントのパスワード)";
			System.Security.SecureString secpass = new System.Security.SecureString();

			foreach (char c in password) secpass.AppendChar(c);

			AcquireTokenByUsernamePasswordParameterBuilder builder = PublicClientApp.AcquireTokenByUsernamePassword(scopes, "(OneDriveにサインインするアカウント)", secpass);
			AuthenticationResult authResult = await builder.ExecuteAsync();

			DelegateAuthenticationProvider prov = new DelegateAuthenticationProvider(
			  (requestMessage) =>
			  {
				  requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", authResult.AccessToken);
				  return Task.FromResult(0);
			  }
			  );
			GraphServiceClient client = new GraphServiceClient(prov);

			System.IO.Stream stream = await client.Me.Drive.Items["01VGRRKKPLGAETCFNMJRF3TAHROCGS2ZB6"].Content.Request().GetAsync();
			byte[] buffer = new byte[stream.Length];
			//stream.Read(buffer);
			stream.Close();

			System.IO.FileStream fs = new System.IO.FileStream("download-test.png", System.IO.FileMode.CreateNew);
			fs.Write(buffer, 0, buffer.Length);
			fs.Close();

			textBox1.Text += "ダウンロードしました。";
			--.ダウンロードは後回しのためコメントアウト--
			*/
		}


	}
}
