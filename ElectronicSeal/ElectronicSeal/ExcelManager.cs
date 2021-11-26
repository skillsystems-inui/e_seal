using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ElectronicSeal
{
	class ExcelManager : IDisposable
	{
        private Application _application = null;
        private Workbook _workbook = null;
        private bool disposedValue = false;

        private string excelFileName = "";

        public ExcelManager(string fileName)
        {
            excelFileName = fileName;
        }

        /// <summary>
        /// Excelワークブックを開く
        /// </summary>
        public void Open()
        {
            // Excelアプリケーション生成
            _application = new Application()
            {
                // 非表示
                Visible = false,
            };

            // Bookを開く
            //_workbook = _application.Workbooks.Open(@"e:\book1.xlsx");
            _workbook = _application.Workbooks.Open(@excelFileName);
        }

        /// <summary>
        /// Excelワークブックをファイル名を指定してPDF形式で保存する
        /// </summary>
        /// <returns>true:正常終了、false:保存失敗</returns>
        public bool SaveAsPDF()
        {
            try
            {
                // 全シートを選択する
                _workbook.Worksheets.Select();

                // ファイル名を指定してPDF形式で保存する
                // ExportAsFixedFormatメソッド: ブックを PDF または XPS 形式に発行する
                //  Type    : タイプ   : XlFixedFormatType xlTypePDF=PDF, xlTypeXPS=XPS
                //  Filename: 出力ファイル名
                //  Quality : 出力品質: XlFixedFormatQuality xlQualityStandard=標準品質, xlqualityminimum=最小限の品質

                //PDFファイル名 excelFileName
                string pdfFileName = excelFileName.Replace("xlsx", "pdf").Replace("xls", "pdf");

                _workbook.ExportAsFixedFormat(
                    Type: XlFixedFormatType.xlTypePDF,
                    //Filename: @"e:\book1.pdf",
                    Filename: @pdfFileName,
                    Quality: XlFixedFormatQuality.xlQualityStandard);
            }
            catch
            {
                return false;
            }

            return true;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Managed Objectの破棄
                }

                if (_workbook != null)
                {
                    _workbook.Close();
					System.Runtime.InteropServices.Marshal.ReleaseComObject(_workbook);
                    _workbook = null;
                }

                if (_application != null)
                {
                    _application.Quit();
					System.Runtime.InteropServices.Marshal.ReleaseComObject(_application);
                    _application = null;
                }

                disposedValue = true;
            }
        }

        ~ExcelManager()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
