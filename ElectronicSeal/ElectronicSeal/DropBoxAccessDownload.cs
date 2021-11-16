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
using Dropbox.Api;
using System.IO;

namespace ElectronicSeal
{
    //参考サイト: https://ichiroku11.hatenablog.jp/entry/2018/04/01/141908
    public partial class DropBoxAccessDownload : Form
	{
        

        

        private void btnGAccess_Click(object sender, EventArgs e)
		{
			//閉じる
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            const string token = "(アクセストークン)";//取得方法: https://gahaha.xyz/category1/dropboxdevelopergetaccesstoken.html#:~:text=Dropbox%E3%81%B8%E7%99%BB%E9%8C%B2%E3%81%97%E3%81%9F%E3%83%A1%E3%83%BC%E3%83%AB,token%E3%81%8C%E8%A1%A8%E7%A4%BA%E3%81%95%E3%82%8C%E3%81%BE%E3%81%99%E3%80%82

            // アクセストークンを使ってDropboxクライアントを生成
            using (var client = new DropboxClient(token))
            {
                //ダウンロード実行
                new DropboxManege(client).DownloadFile().Wait();
            }
        }
	}
}
