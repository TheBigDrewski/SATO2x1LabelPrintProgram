using System;
using System.Windows.Forms;

namespace SATO2x1LabelPrintProgram
{
    public partial class BarcodeLabelForm : Form
    {
        public BarcodeLabelForm()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            string barcodeData = inputTextBox.Text;

            string[] lines = barcodeData.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string quantity = printQuantity.Text;

            try
            {
                Success success = new Success();
                if (printerComboBox.Text != "199SATOCT40022")
                {
                    foreach (string line in lines)
                    {
                        string sbpl = string.Format(
                            "\u001bA" +
                            "\u001bA102030406" +
                            "\u001bZ" +
                            "\u001bA" +
                            "\u001bH070\u001bV025\u001bBG02125{0}" +
                            "\u001bH110\u001bV175\u001bWB0{0}" +
                            "\u001bQ{1}\u001bZ",
                            line, quantity);
                        SATOPrinterFunctions.Print(printerComboBox.Text, sbpl);
                    }
                    success.ShowDialog();
                }
                else 
                {
                    foreach (string line in lines)
                    {
                        string sbpl = string.Format(
                            "\u001bA" +
                            "\u001bA102030406" +
                            "\u001bZ" +
                            "\u001bA" +
                            "\u001bH070\u001bV020\u001bBG02125{0}" +
                            "\u001bH110\u001bV160\u001bWB0{0}" +
                            "\u001bQ{1}\u001bZ",
                            line, quantity);
                        SATOPrinterFunctions.Print(printerComboBox.Text, sbpl);
                    }
                    success.ShowDialog();
                }
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

    }
}
