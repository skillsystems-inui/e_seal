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

        //Azure AD の Client Id をセット クライアントID 取得方法: https://www.ipentec.com/document/microsoft-azure-register-application-in-azure-active-directory
        private const string ClientId = "b8e59a2d-719d-418b-8ec7-93fa5cea3955";
        //Azure AD の Tenant Id をセット テナントID 取得方法: https://www.ipentec.com/document/microsoft-azure-register-application-in-azure-active-directory
        private const string TenantId = "fb0c89cd-35b8-4479-97eb-a57d6fa0ccc6";
        
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
            System.IO.FileStream stream = System.IO.File.OpenRead("test02.txt");

            UploadSession session = await client.Me.Drive.Root.ItemWithPath("test02_new02.txt").CreateUploadSession().Request().PostAsync();

            int maxSliceSize = 320 * 1024; //320KiBの倍数の必要がある。
            LargeFileUploadTask<DriveItem> uptask = new LargeFileUploadTask<DriveItem>(session, stream, maxSliceSize);

            IProgress<long> progress = new Progress<long>(prog =>
            {
                textBox1.Text += string.Format("アップロードしました。{0} Bytes: {1} Total\r\n", prog, stream.Length);
            }
            );

            UploadResult<DriveItem> uploadResult = await uptask.UploadAsync(progress);

            if (uploadResult.UploadSucceeded)
            {
                textBox1.Text += string.Format("アップロードが完了しました。ID:{0}", uploadResult.ItemResponse.Id);
            }
            else
            {
                textBox1.Text += "アップロードに失敗しました。\r\n";
            }
        }

    }
}
