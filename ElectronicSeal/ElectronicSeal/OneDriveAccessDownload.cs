using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using Microsoft.Graph;

namespace ElectronicSeal
{
    //参考サイト: https://www.ipentec.com/document/csharp-onedrive-download-file
    public partial class OneDriveAccessDownload : Form
	{
        public static IPublicClientApplication PublicClientApp;
        private string ClientId = "(クライアントID)";//取得方法: https://www.ipentec.com/document/microsoft-azure-register-application-in-azure-active-directory
        private string TenantId = "(テナントID)";//取得方法: https://www.ipentec.com/document/microsoft-azure-register-application-in-azure-active-directory

        public OneDriveAccessDownload()
		{
			InitializeComponent();
        }

        private void btnGAccess_Click(object sender, EventArgs e)
		{
			//閉じる
			this.Close();
		}

        private async void button1_Click(object sender, EventArgs e)
        {
            PublicClientApplicationBuilder app = PublicClientApplicationBuilder.Create(ClientId);
            app = app.WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient");
            app = app.WithAuthority(AzureCloudInstance.AzurePublic, TenantId);
            PublicClientApp = app.Build();
            //
            string[] scopes = new string[] { "User.ReadWrite.All" };
            string account = "(OneDriveにサインインするアカウント)";
            string password = "(OneDriveにサインインするアカウントのパスワード)";
            System.Security.SecureString secpass = new System.Security.SecureString();

            foreach (char c in password) secpass.AppendChar(c);

            AcquireTokenByUsernamePasswordParameterBuilder builder = PublicClientApp.AcquireTokenByUsernamePassword(scopes, account, secpass);
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
            stream.Read(buffer, 0, buffer.Length);
            stream.Close();

            string download_file_name = "download-test.png";//ダウンロードファイル名
            System.IO.FileStream fs = new System.IO.FileStream(download_file_name, System.IO.FileMode.CreateNew);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();

            textBox1.Text += "ダウンロードしました。";
        }

	}
}
