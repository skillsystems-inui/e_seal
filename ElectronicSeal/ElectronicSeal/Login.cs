using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Azure;
using Azure.Communication;
using Azure.Communication.Sms;
using Azure.Identity;


namespace ElectronicSeal
{
	public partial class Login : Form
	{
		private DefaultAzureCredential credential = new DefaultAzureCredential();

		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			//AWSに接続
			//参考サイト: 


			//.試し

			//2段階認証
			// 確認コードを生成する
			Random rdm = new System.Random();
			int kakuninCode = rdm.Next(100000, 999999);//6桁の乱数生成
													   


			/**** ToDo相談　/
			//string connectionString = Environment.GetEnvironmentVariable("endpoint=https://resource01.communication.azure.com/;accesskey=YzFNe2boAchaW9NwSJC6qIXW/Tv3xrTKXl+0MYK6Hq2DiBPe51rSDULUDrMRy8WLgqqraOhaUdD0L1TZjloxtQ==");
			string connectionString = "endpoint=https://resource01.communication.azure.com/;accesskey=YzFNe2boAchaW9NwSJC6qIXW/Tv3xrTKXl+0MYK6Hq2DiBPe51rSDULUDrMRy8WLgqqraOhaUdD0L1TZjloxtQ==";
			//ToDo: Azure CommunicationServicesリソースから取得した接続文字列
			SmsClient smsClient = new SmsClient(connectionString);
			//SmsClient smsClient = new SmsClient("https://resource01.communication.azure.com/");
			SmsSendResult sendResult = smsClient.Send(
				from: "+819011112222",
				to: "+819050461402",
				message: "Hello World via SMS"
			);
			//番号指定: https://knowledge.cpi.ad.jp/tech/131/
			/****/
			
			Menu menu = new Menu();
			menu.ShowDialog();
		}




		private void btnGAccess_Click(object sender, EventArgs e)
		{
			//GoogleDriveアクセス 
			GoogleDriveAccessUpload gda = new GoogleDriveAccessUpload();
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

		private void btnExcel_Click(object sender, EventArgs e)
		{
			//Excel操作
			ManageExcel gda = new ManageExcel();
			gda.ShowDialog();
		}
	}
}
