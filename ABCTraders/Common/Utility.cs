using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Data;
using System.Linq;
using System.Drawing;

namespace ABCTraders.Common
{
    internal class Utility
    {
        [Obsolete]
        public bool WriteToPdfFile(DataTable dataTable, string filePath)
        {
            try
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Car Data Export";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 10, XFontStyleEx.Regular);

                int yPoint = 40;

                string headers = string.Join(", ", dataTable.Columns.Cast<DataColumn>().Select(col => col.ColumnName));
                gfx.DrawString(headers, font, XBrushes.Black, new XRect(10, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                yPoint += 20;

                foreach (DataRow row in dataTable.Rows)
                {
                    string rowData = string.Join(", ", row.ItemArray.Select(item => item.ToString()));
                    gfx.DrawString(rowData, font, XBrushes.Black, new XRect(10, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    yPoint += 20;

                    if (yPoint > page.Height - 40)
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        yPoint = 40;
                    }
                }

                document.Save(filePath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
