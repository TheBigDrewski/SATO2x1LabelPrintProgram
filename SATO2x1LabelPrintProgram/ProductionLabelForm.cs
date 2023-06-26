using SATOPrinterAPI;
//using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

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
            //
            // SATOTest
            //
            Printer SATOTest = new Printer
            {
                Interface = Printer.InterfaceType.TCPIP,
                TCPIPAddress = "10.10.200.82",
                TCPIPPort = "9100"
            };
            //
            // 199SATOCT40022 - Building 200 - Receiving
            //
            Printer _199SATOCT40022 = new Printer
            {
                Interface = Printer.InterfaceType.TCPIP,
                TCPIPAddress = "10.10.199.225",
                TCPIPPort = "9100",
                PermanentConnect = true
            };
            //199SATOCT4003 - Building 200 - Prep Station 4
            Printer _199SATOCT4003 = new Printer
            {
                Interface = Printer.InterfaceType.TCPIP,
                TCPIPAddress = "10.10.199.220",
                TCPIPPort = "9100"
            };
            //199SATOCT4004 - Building 200 - Prep Station 2
            Printer _199SATOCT4004 = new Printer
            {
                Interface = Printer.InterfaceType.TCPIP,
                TCPIPAddress = "10.10.200.27",
                TCPIPPort = "9100"
            };
            //199SATOCT4006 - Building 200 - Prep Station 3
            Printer _199SATOCT4006 = new Printer
            {
                Interface = Printer.InterfaceType.TCPIP,
                TCPIPAddress = "10.10.200.29",
                TCPIPPort = "9100"
            };

            string[] data = new string[]
                {   lotTextBox.Text,
                    fillDateTextBox.Text,
                    productTextBox.Text,
                    pressureTextBox.Text,
                    serialTextBox.Text
                };

            /*string serial = serialTextBox.Text;
            string[] data;
            string file;
            file = string.Format(@"\\mgp199\Engineering\2-Current Employees\JESCHKE\SATO Printer Programs\{0} - 745219 16.xlsx", serial);
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(file);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            //Fill Date
            data = range.Cells[12, 3].Value;
            //Pressure
            data += range.Cells[14, 3].Value;
            //Lot Number
            data += range.Cells[5, 3].Value;
            //Product
            if (range.Cells[5,8].Value != "" && range.Cells[5, 8].Value != null)
            {
                data += range.Cells[5, 6].Value;
            }
            else if (range.Cells[7, 8].Value != "" && range.Cells[7, 8].Value != null)
            {
                data += range.Cells[7, 6].Value;
            }
            else if (range.Cells[9, 8].Value != "" && range.Cells[9, 8].Value != null)
            {
                data += range.Cells[9, 6].Value;
            }
            else if (range.Cells[11, 8].Value != "" && range.Cells[11, 8].Value != null)
            {
                data += range.Cells[11, 6].Value;
            }
            */
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
                switch (printerComboBox.Text)
                {
                    case "199SATOCT4003":
                        _199SATOCT4003.Connect();
                        _199SATOCT4003.Query(Encoding.ASCII.GetBytes(sbpl));
                        success.ShowDialog();
                        _199SATOCT4003.Disconnect();
                        break;

                    case "199SATOCT4004":
                        _199SATOCT4004.Connect();
                        _199SATOCT4004.Query(Encoding.ASCII.GetBytes(sbpl));
                        success.ShowDialog();
                        _199SATOCT4004.Disconnect();
                        break;
                    case "199SATOCT4006":
                        _199SATOCT4006.Connect();
                        _199SATOCT4006.Query(Encoding.ASCII.GetBytes(sbpl));
                        success.ShowDialog();
                        _199SATOCT4006.Disconnect();
                        break;
                    case "SATOTest":
                        SATOTest.Connect();
                        SATOTest.Query(Encoding.ASCII.GetBytes(sbpl));
                        success.ShowDialog();
                        SATOTest.Disconnect();
                        break;
                    case "199SATOCT40022":
                        _199SATOCT40022.Connect();
                        _199SATOCT40022.Query(Encoding.ASCII.GetBytes(sbpl));
                        success.ShowDialog();
                        _199SATOCT40022.Disconnect();
                        break;
                }
            }

            catch (Exception ex)
            {
                ExceptionForm exceptionForm = new ExceptionForm(ex);
                exceptionForm.ShowDialog();
            }

            // Close the workbook and release resources
            //workbook.Close();
            //excelApp.Quit();
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

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
    }
}
