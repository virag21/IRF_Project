using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace IRF_project_GXMRLU
{
    public partial class UploadDataUserControl : UserControl
    {
        List<Order> OrderList = new List<Order>();

        public UploadDataUserControl()
        {
            InitializeComponent();
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                using (StreamReader sr = new StreamReader(selectedFileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(';');
                        Order o = new Order
                        {
                            Sender = line[0],
                            SenderPhone = line[1],
                            SenderEmail = line[2],
                            Name = line[3],
                            Address = line[4],
                            Gift = line[5],
                            Quantity = int.Parse(line[6])
                        };

                        OrderList.Add(o);
                    }
                }

                dataGridView1.DataSource = OrderList;
            }

            exportBtn.Visible = true;
        }

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        private void exportBtn_Click(object sender, EventArgs e)
        {


            try
            {
                xlApp = new Excel.Application();

                xlWB = xlApp.Workbooks.Add(Missing.Value);

                xlSheet = xlWB.ActiveSheet;

                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }

            FormatTable();

        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
        string[] headers = new string[] {
                         "Sender",
                         "SenderPhone",
                         "SenderEmail",
                         "Name",
                         "Address",
                         "Gift",
                         "Quantity"};
        private void CreateTable()
        {
            

            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = headers[i];

            }
            object[,] values = new object[OrderList.Count, headers.Length];
            int counter = 0;
            foreach (Order f in OrderList)
            {
                values[counter, 0] = f.Sender;
                values[counter, 1] = f.SenderPhone;
                values[counter, 2] = f.SenderEmail;
                values[counter, 3] = f.Name;
                values[counter, 4] = f.Address;
                values[counter, 5] = f.Gift;
                values[counter, 6] = f.Quantity;
                counter++;
            }
            xlSheet.get_Range(
                GetCell(2, 1),
                GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

        }
        private void FormatTable()
        {
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range fullRange = xlSheet.get_Range(GetCell(1, 1), GetCell(xlSheet.UsedRange.Rows.Count, xlSheet.UsedRange.Columns.Count));
            fullRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            fullRange.Interior.Color = Color.Wheat;

        }


    }
}
