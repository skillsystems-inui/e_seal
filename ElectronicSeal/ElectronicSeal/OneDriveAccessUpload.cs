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
    //参考サイト: https://www.ipentec.com/document/csharp-onedrive-upload-file
    public partial class OneDriveAccessUpload : Form
	{
		public static IPublicClientApplication PublicClientApp;
		private string ClientId = "(クライアントID)";
		private string TenantId = "(テナントID)";

		public OneDriveAccessUpload()
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
            //アップロード
            PublicClientApplicationBuilder app = PublicClientApplicationBuilder.Create(ClientId);
            app = app.WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient");
            app = app.WithAuthority(AzureCloudInstance.AzurePublic, TenantId);
            PublicClientApp = app.Build();
            //
            string[] scopes = new string[] { "User.ReadWrite.All" };
            string account  = "(OneDriveにサインインするアカウント)";
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

            System.IO.StreamReader reader = System.IO.File.OpenText("test02.txt");

            DriveItem item = await client.Me.Drive.Root.ItemWithPath("upload-test02.txt").Content.Request().PutAsync<DriveItem>(reader.BaseStream);

            textBox1.Text += "アップロードしました。";
        }
	}
}
