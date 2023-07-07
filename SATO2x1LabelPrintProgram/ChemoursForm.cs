using System;
using System.Windows.Forms;

namespace SATO2x1LabelPrintProgram
{
    public partial class ChemoursForm : Form
    {
        public ChemoursForm()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {           
            string[] data = new string[]
                {   lotTextBox.Text,
                    fillDateTextBox.Text,
                    netWeightTextBox.Text,
                    tareWeightTextBox.Text,
                    grossWeightTextBox.Text,
                    serialTextBox.Text
                };

            string quantity = printQuantityTextBox.Text;

            string sbpl = string.Format(
                            "\u001bA" +
                            "\u001bA102030406" +
                            "\u001bZ" +
                            "\u001bA" +
                            "\u001b#E5" +
                            "\u001bZ" +
                            "\u001bA" +
                            "\u001bH025\u001bV025\u001bRDB00,P10,P10,LOT #:\u001bH195\u001bV025\u001bRDB00,P10,P10,{0}" +
                            "\u001bH025\u001bV055\u001bRDB00,P10,P10,FILL DATE:\u001bH195\u001bV055\u001bRDB00,P10,P10,{1}" +
                            "\u001bH025\u001bV085\u001bRDB00,P10,P10,NET WT:\u001bH195\u001bV085\u001bRDB00,P10,P10,{2}" +
                            "\u001bH025\u001bV115\u001bRDB00,P10,P10,TARE WT:\u001bH195\u001bV115\u001bRDB00,P10,P10,{3}" +
                            "\u001bH025\u001bV145\u001bRDB00,P10,P10,GROSS WT:\u001bH195\u001bV145\u001bRDB00,P10,P10,{4}" +
                            "\u001bH025\u001bV175\u001bRDB00,P10,P10,SERIAL #:\u001bH195\u001bV175\u001bRDB00,P10,P10,{5}" +
                            "\u001bQ{6}\u001bZ",
                            data[0], data[1], data[2], data[3], data[4], data[5], quantity);


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
    }
}
