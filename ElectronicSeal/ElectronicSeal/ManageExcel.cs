using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ElectronicSeal
{
    //Microsoft.Office.Interop.Excelの追加　https://www.curict.com/item/00/0049556.html
    //参考サイト: https://usefuledge.com/csharp-excel-library.html
    //参考サイト(Excelに書き込む): https://www.osadasoft.com/c-%E3%83%97%E3%83%AD%E3%82%B0%E3%83%A9%E3%83%A0%E3%81%8B%E3%82%89excel%E3%83%95%E3%82%A1%E3%82%A4%E3%83%AB%E3%82%92%E8%AA%AD%E3%81%BF%E6%9B%B8%E3%81%8D%E3%81%99%E3%82%8B%E6%96%B9%E6%B3%95/
    public partial class ManageExcel : Form
	{
		//private static string fileName = System.IO.Directory.GetCurrentDirectory() + "\\sample_test.xlsx";

        //Button button1, button2;
        Excel.Application excelApp;

        string excelFileName = "G:\\電子印鑑アプリ\\1.作成資料\\テスト用エクセルファイル\\sample_test.xlsx";

        public ManageExcel()
		{
			InitializeComponent();

            //Excelを開く
            //参考サイト: http://enajet.air-nifty.com/blog/2012/07/c-frameexcel-ex.html
            //ToDo: フォームから操作はできないのではないか？

            //C#でのExcelの表示や保存の方法とは？起動と終了・シートやセルの操作・保存: https://www.fenet.jp/dotnet/column/language/9695
            //C#でExcelを操作する: https://lets-csharp.com/excel-edit-cs/
            //webBrowser1.Navigate(@System.IO.Directory.GetCurrentDirectory() + "\\sample_test.xlsx");
            this.webBrowser1.Navigate(@excelFileName);
            //System.Diagnostics.Process.Start(@"G:\電子印鑑アプリ\1.作成資料\テスト用エクセルファイル\sample_test.xlsx");
        }

        private void btnGAccess_Click(object sender, EventArgs e)
		{
			//閉じる
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            // Excel起動
            excelApp = new Excel.Application();

            // 非表示にする
            excelApp.Application.Visible = false;
            excelApp.Application.DisplayAlerts = false;

            // Bookを追加
            excelApp.Application.Workbooks.Add(Type.Missing);

            // Excel表示
            excelApp.Application.Visible = true;
            /*
            this.Cursor = Cursors.WaitCursor;   // マウスカーソルを砂時計
            Excel.Application oExcelApp = null; // Excelオブジェクト
            Excel.Workbook oExcelWBook = null;  // Excel Workbookオブジェクト
            try
            {
                oExcelApp = new Excel.Application();
                oExcelApp.DisplayAlerts = false; // Excelの確認ダイアログ表示有無
                oExcelApp.Visible = false;       // Excel表示有無
                                                 // Excelファイルをオープンする(第一パラメタ以外は省略可)
                oExcelWBook = (Excel.Workbook)(oExcelApp.Workbooks.Open(
                  fileName,      // Filename
                  Type.Missing,  // UpdateLinks
                  Type.Missing,  // ReadOnly
                  Type.Missing,  // Format
                  Type.Missing,  // Password
                  Type.Missing,  // WriteResPassword
                  Type.Missing,  // IgnoreReadOnlyRecommended
                  Type.Missing,  // Origin
                  Type.Missing,  // Delimiter
                  Type.Missing,  // Editable
                  Type.Missing,  // Notify
                  Type.Missing,  // Converter
                  Type.Missing,  // AddToMru
                  Type.Missing,  // Local
                  Type.Missing   // CorruptLoad
                ));
                Excel._Worksheet oWSheet = (Excel._Worksheet)oExcelWBook.ActiveSheet;
                // セルA1の値を取得
                MessageBox.Show("セルA1の値：" + oWSheet.Cells[1, 1].Value);
                // セルA2に更新時刻を書き込み
                oWSheet.Cells[2, 1] = DateTime.Now.ToString("HH時mm分ss秒");
                Excel.Range oRange = oWSheet.Cells[2, 1];   // セル選択
                oRange.Font.Size = 8;
                oRange.Font.Name = "ＭＳ 明朝";
                oRange.Font.Color = 0xFF0000;
                oRange.Interior.Color = 0x44FFFF;
                // [Microsoft Excel - 互換性チェック]ダイアログの表示有無
                oExcelWBook.CheckCompatibility = false;
                oExcelWBook.SaveAs(fileName);    // Excel保存
                MessageBox.Show(
                "保存しました。",
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show(
                "Excelファイルの操作に失敗しました。\n",
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            finally
            {
                oExcelWBook.Close(Type.Missing, Type.Missing, Type.Missing);
                oExcelApp.Quit();
            }
            this.Cursor = Cursors.Default;  // マウスカーソルを戻す
            */
        }

		private void ManageExcel_Load(object sender, EventArgs e)
		{
            /*
            // 起動ボタン
            button1 = new Button();
            button1.Location = new Point(10, 10);
            button1.Text = "Open Excel";
            button1.AutoSize = true;
            button1.Click += button1_Click;
            this.Controls.Add(button1);

            // 終了ボタン
            button2 = new Button();
            button2.Location = new Point(100, 10);
            button2.Text = "Close Excel";
            button2.AutoSize = true;
            button2.Click += button2_Click;
            this.Controls.Add(button2);
            */

            /*
            textBox1.ReadOnly = true;
			textBox1.Text = fileName;
            */
        }

		private void button2_Click(object sender, EventArgs e)
		{
            // Excel終了
            if (excelApp != null)
            {
                excelApp.Quit();
            }
            excelApp = null;
        }

		private void btnToPdf_Click(object sender, EventArgs e)
		{
            //PDFに変換
            using (var excel = new ExcelManager(excelFileName))
            {
                excel.Open();
                if (excel.SaveAsPDF() == false)
                    MessageBox.Show("ファイルが既に開かれています。\n閉じてから、再試行してください。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }
	}
}
