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
using Microsoft.Graph.Auth;
using Azure.Identity;
using System.IO;

namespace ElectronicSeal
{
    //参考サイト: https://www.ipentec.com/document/csharp-onedrive-download-file
    public partial class OneDriveAccessDownload : Form
	{
        public static IPublicClientApplication PublicClientApp;
        
        //private string ClientId = "(クライアントID)";//取得方法: https://www.ipentec.com/document/microsoft-azure-register-application-in-azure-active-directory
        //private string TenantId = "(テナントID)";//取得方法: https://www.ipentec.com/document/microsoft-azure-register-application-in-azure-active-directory
        
        // TODO: Azure AD の Client Id をセット
        private const string ClientId = "b8e59a2d-719d-418b-8ec7-93fa5cea3955";
        // TODO: Azure AD の Tenant Id をセット
        private const string TenantId = "fb0c89cd-35b8-4479-97eb-a57d6fa0ccc6";
        // TODO: Azure AD のアプリのシークレットをセット
        //private const string ClientSecret = "Idq7Q~WgaCehKgjcQKowoS5QLcQ3m9R6Xmvzn";//-Mp7Q~c8u2Z7wXn8WDFJ.AfZCy7PZkHnd06c8

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
            string password = "System4199";
            System.Security.SecureString secpass = new System.Security.SecureString();

            foreach (char c in password) secpass.AppendChar(c);

            AcquireTokenByUsernamePasswordParameterBuilder builder = PublicClientApp.AcquireTokenByUsernamePassword(scopes, "skillinui@skillinui.onmicrosoft.com", secpass);
            AuthenticationResult authResult = await builder.ExecuteAsync();

            DelegateAuthenticationProvider prov = new DelegateAuthenticationProvider(
              (requestMessage) =>
              {
                  requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", authResult.AccessToken);
                  return Task.FromResult(0);
              }
              );
            GraphServiceClient client = new GraphServiceClient(prov);

            System.IO.Stream stream = await client.Me.Drive.Items["(フォルダID)"].Content.Request().GetAsync();
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            stream.Close();

            System.IO.FileStream fs = new System.IO.FileStream("test02_new.txt", System.IO.FileMode.CreateNew);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();

            textBox1.Text += "ダウンロードしました。";

        }

    }
}
