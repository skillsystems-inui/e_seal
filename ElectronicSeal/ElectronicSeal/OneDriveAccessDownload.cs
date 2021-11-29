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

namespace ElectronicSeal
{
    //参考サイト: https://www.ipentec.com/document/csharp-onedrive-download-file
    public partial class OneDriveAccessDownload : Form
	{
        public static IPublicClientApplication PublicClientApp;
        
        //private string ClientId = "(クライアントID)";//取得方法: https://www.ipentec.com/document/microsoft-azure-register-application-in-azure-active-directory
        //private string TenantId = "(テナントID)";//取得方法: https://www.ipentec.com/document/microsoft-azure-register-application-in-azure-active-directory
        //private string ClientId = "4c335f61-0c9a-4998-bdfe-30c469f24227";
        //private string TenantId = "9a2b6042-672c-418f-9a15-803428065d50";

        // TODO: Azure AD の Client Id をセット
        private const string ClientId = "47e3f8bf-3a02-41b6-9158-04af7c58ec44";
        // TODO: Azure AD の Tenant Id をセット
        private const string TenantId = "620696c7-5cdc-427d-a350-8ea372da63fe";
        // TODO: Azure AD のアプリのシークレットをセット
        private const string ClientSecret = "JRS7Q~-YquT-T7w~muAxmVjZwuaRFdTFs_UQN";

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
            //ユーザ認証　参考サイト:https://blog.beachside.dev/entry/2021/03/31/190000
            // GraphService Client の初期化
            var confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create(ClientId)
                .WithTenantId(TenantId)
                .WithClientSecret(ClientSecret)
                .Build();

            var provider = new ClientCredentialProvider(confidentialClientApplication);
            var graphServiceClient = new GraphServiceClient(provider);
            /**
            PublicClientApplicationBuilder app = PublicClientApplicationBuilder.Create(ClientId);
            app = app.WithRedirectUri("https://login.microsoftonline.com/common/oauth2/nativeclient");
            app = app.WithAuthority(AzureCloudInstance.AzurePublic, TenantId);
            PublicClientApp = app.Build();
            //
            string[] scopes = new string[] { "User.ReadWrite.All" };
            string account = "skillinui@gmail.com";//skill0eseal@gmail.com   (OneDriveにサインインするアカウント)c
            string password = "system4199"; //(OneDriveにサインインするアカウントのパスワード)
             System.Security.SecureString secpass = new System.Security.SecureString();

            foreach (char c in password) secpass.AppendChar(c);

            AcquireTokenByUsernamePasswordParameterBuilder builder = PublicClientApp.AcquireTokenByUsernamePassword(scopes, account, secpass);
            **/

            /*
            AuthenticationResult authResult = await builder.ExecuteAsync();


            DelegateAuthenticationProvider prov = new DelegateAuthenticationProvider(
              (requestMessage) =>
              {
                  requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", authResult.AccessToken);
                  return Task.FromResult(0);
              }
              );
            GraphServiceClient client = new GraphServiceClient(prov);
            */

            //test
            var users = await graphServiceClient.Users.Request().GetAsync();

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id} - DisplayName: {user.DisplayName} (Email: {user.Mail})");
            }


            System.IO.StreamReader reader = System.IO.File.OpenText("test02.txt");

            DriveItem item = await graphServiceClient.Me.Drive.Root.ItemWithPath("upload-test02.txt").Content.Request().PutAsync<DriveItem>(reader.BaseStream);

            textBox1.Text += "アップロードしました。";

            /** ファイルダウンロード
            System.IO.Stream stream = await graphServiceClient.Me.Drive.Items["01VGRRKKPLGAETCFNMJRF3TAHROCGS2ZB6"].Content.Request().GetAsync();
            ///System.IO.Stream stream = await client.Me.Drive.Items["01VGRRKKPLGAETCFNMJRF3TAHROCGS2ZB6"].Content.Request().GetAsync();
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            stream.Close();


            System.IO.FileStream fs = new System.IO.FileStream("download-test.png", System.IO.FileMode.CreateNew);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();

            textBox1.Text += "ダウンロードしました。";

            .ファイルダウンロード　*/

            /* 案1
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
            */
        }

    }
}
