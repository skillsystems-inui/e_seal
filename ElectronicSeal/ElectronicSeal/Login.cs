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


namespace ElectronicSeal
{
	public partial class Login : Form
	{
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
													   // 
			// This code demonstrates how to fetch your connection string
			// from an environment variable.
			string connectionString = Environment.GetEnvironmentVariable("COMMUNICATION_SERVICES_CONNECTION_STRING");
			//ToDo: Azure CommunicationServicesリソースから取得した接続文字列
			SmsClient smsClient = new SmsClient(connectionString);
			SmsSendResult sendResult = smsClient.Send(
				from: "06-1111-2222",
				to: "090-5046-1402",
				message: "Hello World via SMS"
			);
			/*
			 * SmsSendResult sendResult = smsClient.Send(
				from: "<from-phone-number>",
				to: "<to-phone-number>",
				message: "Hello World via SMS"
			);
			 */

			//			Console.WriteLine($"Sms id: {sendResult.MessageId}");

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
