using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;

namespace EsportaInventarioPerEmil
{
    class DialogSalvaXls
    {
        //public void dialog(DataGridView grid)
        //{
        //    Excel._Application app = new Excel.Application();
        //    Excel._Workbook wk = app.Workbooks.Add(Type.Missing);
        //    Excel._Worksheet sheet = null;
        //    sheet = wk.Sheets[1];
        //    sheet = wk.ActiveSheet;
        //    sheet.Name = "Entrate";

        //    for (int i = 1; i <= grid.ColumnCount; i++)
        //    {
        //        sheet.Cells[1, i] = grid.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 0; i < grid.Rows.Count ; i++)
        //    {
        //        for (int j = 0; j < grid.Columns.Count; j++)
        //        {
        //            if(j != 7 && j != 8 && j != 9 )
        //            sheet.Cells[i + 2, j + 1] = grid.Rows[i].Cells[j].Value.ToString();
        //            else
        //                sheet.Cells[i + 2, j + 1] = grid.Rows[i].Cells[j].Value;
        //        }
        //    }
        //    sheet.Columns.AutoFit();

            
        //    SaveFileDialog sf = new SaveFileDialog();
        //    sf.Title = "Salva";
        //    sf.Filter = "XLS|*.xls|XLSX|*.xlsx|Tutti i file|*.*";
        //    sf.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);



        //    if (sf.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            wk.SaveAs(sf.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //            wk.Close();
        //            app.Quit();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }
        //}
    }
}

