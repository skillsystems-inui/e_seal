using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dropbox.Api;

namespace ElectronicSeal
{
	class DropboxManege
	{
		// Dropboxクライアント
		private readonly DropboxClient _client;

		public DropboxManege(DropboxClient client)
		{
			_client = client;
		}

		//フォルダを作成
		public async Task<bool> CreateFolder()
		{
			string folderName = "(フォルダ名)";
			await _client.Files.CreateFolderV2Async(folderName);

			return true;
		}

		// ファイルをアップロード
		public async Task<bool> UploadFile()
		{
			string fileName = "(ファイル名)";
			using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				await _client.Files.UploadAsync("/アップロード先ファイル名", body: stream);
			}

			return true;
		}

		// ファイルをダウンロード
		public async Task<bool> DownloadFile()
		{
			string fileName = "(ダウンロードファイル名)";
			using (var response = await _client.Files.DownloadAsync(fileName))
			{
				Console.WriteLine(await response.GetContentAsStringAsync());
			}

			return true;
		}
	}
}
