using System;
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
	public partial class DropBoxAccessDownload : Form
	{
        //GoogleDriveのフォルダID ToDoこれをどのように指定するか考慮が必要
        private string myDriveFileId = "1XIg_KtZ9jr19rw9FxlFDV1r4YM-SPgcK";

        //FolderBrowserDialogクラスのインスタンスを作成
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public DropBoxAccessDownload()
		{
			InitializeComponent();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;
        }

        //Google API サービスアカウントの認証キー
        private string google_api_service_account_key = "smooth-tendril-331806-ba3cda45c3d5.json";

        private void btnGAccess_Click(object sender, EventArgs e)
		{
			//閉じる
			this.Close();
		}

		static string[] Scopes = { DriveService.Scope.Drive };

		private void button1_Click(object sender, EventArgs e)
		{
            FileStream fs = new FileStream(google_api_service_account_key, FileMode.Open, FileAccess.Read);
            Google.Apis.Auth.OAuth2.GoogleCredential credential = Google.Apis.Auth.OAuth2.GoogleCredential.FromStream(fs).CreateScoped(Scopes);

            Google.Apis.Services.BaseClientService.Initializer init = new Google.Apis.Services.BaseClientService.Initializer();
            init.HttpClientInitializer = credential;
            init.ApplicationName = "ElectronicSeal";
            DriveService service = new DriveService(init);

            //FileInfo
            Google.Apis.Drive.v3.Data.File file = service.Files.Get(myDriveFileId).Execute();
            textBox2.Text += string.Format("ID:{0} のファイル情報を取得しました。 MimeType:{1}\r\n", file.Name, file.MimeType);

            //Download
            FilesResource.GetRequest req = service.Files.Get(myDriveFileId);

            //ExoprtFolder
            string exoprtFolder = textBox3.Text;

            if(exoprtFolder.Length < 1)
			{
                MessageBox.Show("出力先を選択してください", "確認");
            }

            FileStream dfs = new FileStream(exoprtFolder + "\\" + file.Name, FileMode.Create, FileAccess.Write);
            //FileStream dfs = new FileStream("c:\\data\\" + file.Name, FileMode.Create, FileAccess.Write);
            req.Download(dfs);
            dfs.Close();

            textBox2.Text += "ファイルのダウンロードが完了しました。\r\n";
        }

        

		private void button2_Click(object sender, EventArgs e)
		{
            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                textBox3.Text = fbd.SelectedPath;
            }

        }
	}
}
