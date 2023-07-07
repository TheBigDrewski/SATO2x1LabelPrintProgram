using System.Text;
using System.Windows.Forms;

namespace SATO2x1LabelPrintProgram
{
    public partial class ProductionLabelForm : Form
    {
        public ProductionLabelForm()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            string[] data = new string[]
                {   lotTextBox.Text,
                    fillDateTextBox.Text,
                    productTextBox.Text,
                    pressureTextBox.Text,
                    serialTextBox.Text
                };

            // Picks the cells from an Excel File to automatically import in 
            //
            /*string serial = serialTextBox.Text;
            string file = string.Format(@"Z:\Engineering\2-Current Employees\JESCHKE\SATO Printer Programs\{0} - 745219 16.xlsx", serial);
            string fillDateCell = "C12";
            string pressureCell = "C14";
            string lotCell = "C5";
            string argonCell = "H5";
            string heliumCell = "H7";
            string nitrogenCell = "H9";
            string hydrogenCell = "H11";
            string[] gasNames = { "Argon", "Helium", "Nitrogen", "Hydrogen" };

            data[0] = GetCellValue(file, lotCell);
            data[1] = GetCellValue(file, fillDateCell);
            if (GetCellValue(file, argonCell) != null && GetCellValue(file, argonCell) != "")
            {
                data[2] = gasNames[0] + " - " + GetCellValue(file, argonCell);
            }
            else if (GetCellValue(file, heliumCell) != null && GetCellValue(file, heliumCell) != "")
            {
                data[2] = gasNames[1] + " - " + GetCellValue(file, heliumCell);
            }
            else if (GetCellValue(file, nitrogenCell) != null && GetCellValue(file, nitrogenCell) != "")
            {
                data[2] = gasNames[2] + " - " + GetCellValue(file, nitrogenCell);
            }
            else if (GetCellValue(file, hydrogenCell) != null && GetCellValue(file, hydrogenCell) != "")
            {
                data[2] = gasNames[3] + " - " + GetCellValue(file, hydrogenCell);
            }
            data[3] = GetCellValue(file, pressureCell);*/

            string quantity = printQuantityTextBox.Text;

            string sbpl = string.Format(
                            "\u001bA" +
                            "\u001bA102030406" +
                            "\u001bZ" +
                            "\u001bA" +
                            "\u001b#E5" +
                            "\u001bZ" +
                            "\u001bA" +
                            "\u001bH025\u001bV030\u001bRDB00,P10,P10,LOT #:\u001bH195\u001bV030\u001bRDB00,P10,P10,{0}" +
                            "\u001bH025\u001bV065\u001bRDB00,P10,P10,FILL DATE:\u001bH195\u001bV065\u001bRDB00,P10,P10,{1}" +
                            "\u001bH025\u001bV100\u001bRDB00,P10,P10,PRODUCT:\u001bH195\u001bV100\u001bRDB00,P10,P10,{2}" +
                            "\u001bH025\u001bV135\u001bRDB00,P10,P10,PRESSURE:\u001bH195\u001bV135\u001bRDB00,P10,P10,{3}" +
                            "\u001bH025\u001bV170\u001bRDB00,P10,P10,SERIAL #:\u001bH195\u001bV170\u001bRDB00,P10,P10,{4}" +
                            "\u001bQ{4}\u001bZ",
                            data[0], data[1], data[2], data[3], data[4], quantity);
            try
            {
                Success success = new Success();
                SATOPrinterFunctions.Print(printerComboBox.Text, sbpl);
                success.ShowDialog();
            }

            catch (Exception ex)
            {
                ExceptionForm exceptionForm = new ExceptionForm(ex);
                exceptionForm.ShowDialog();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm landing = new MainForm();
            this.Hide();
            landing.ShowDialog();
            this.Close();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        /*private string GetCellValue(string filePath, string cellAddress)
        {
            //Connect to the worksheet
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets["OPS-FL-424-F-01"];
            Excel.Range range = worksheet.Range[cellAddress];

            // Get the value of the specified cell
            string cellValue = range.Value?.ToString();

            // Clean up resources
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(range);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            return cellValue;
        }*/
    }
}
