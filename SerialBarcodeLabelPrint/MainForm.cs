using System;
using System.Text;
using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupSATO();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            string barcodeData = inputTextBox.Text;

            string[] lines = barcodeData.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string quantity = printQuantity.Text;

            try
            {
                switch (printerComboBox.Text)
                {
                    case "199SATOCT4003":
                        _199SATOCT4003.Connect();

                        foreach (string line in lines)
                        {
                            string sbpl = string.Format(
                                "\u001bA\u001bA102030406\u001bZ\u001bA\u001bH070\u001bV025\u001bBG02125{0}\u001bH110\u001bV175\u001bWB0{0}\u001bQ{1}\u001bZ", line, quantity);

                            byte[] sbplBytes = Encoding.ASCII.GetBytes(sbpl);
                            _199SATOCT4003.Query(sbplBytes);
                        }
                        success.ShowDialog();
                        _199SATOCT4003.Disconnect();
                        break;

                    case "199SATOCT4004":
                        _199SATOCT4004.Connect();

                        foreach (string line in lines)
                        {
                            string sbpl = string.Format(
                                "\u001bA\u001bA102030406\u001bZ\u001bA\u001bH070\u001bV025\u001bBG02125{0}\u001bH110\u001bV175\u001bWB0{0}\u001bQ{1}\u001bZ", line, quantity);

                            byte[] sbplBytes = Encoding.ASCII.GetBytes(sbpl);
                            _199SATOCT4004.Query(sbplBytes);
                        }
                        success.ShowDialog();
                        _199SATOCT4004.Disconnect();
                        break;
                    case "199SATOCT4006":
                        _199SATOCT4006.Connect();

                        foreach (string line in lines)
                        {
                            string sbpl = string.Format(
                                "\u001bA\u001bA102030406\u001bZ\u001bA\u001bH070\u001bV025\u001bBG02125{0}\u001bH110\u001bV175\u001bWB0{0}\u001bQ{1}\u001bZ", line, quantity);

                            byte[] sbplBytes = Encoding.ASCII.GetBytes(sbpl);
                            _199SATOCT4006.Query(sbplBytes);
                        }
                        success.ShowDialog();
                        _199SATOCT4006.Disconnect();
                        break;
                    case "SATOTest":
                        SATOTest.Connect();

                        foreach (string line in lines)
                        {
                            string sbpl = string.Format(
                                "\u001bA\u001bA102030406\u001bZ\u001bA\u001bH070\u001bV025\u001bBG02125{0}\u001bH110\u001bV175\u001bWB0{0}\u001bQ{1}\u001bZ", line, quantity);

                            byte[] sbplBytes = Encoding.ASCII.GetBytes(sbpl);
                            SATOTest.Query(sbplBytes);
                        }
                        success.ShowDialog();
                        SATOTest.Disconnect();
                        break;
                    case "199SATOCT40022":
                        _199SATOCT40022.Connect();

                        foreach (string line in lines)
                        {
                            string sbpl = string.Format(
                                "\u001bA\u001bA102030406\u001bZ\u001bA\u001bH070\u001bV025\u001bBG02125{0}\u001bH110\u001bV175\u001bWB0{0}\u001bQ{1}\u001bZ", line, quantity);

                            byte[] sbplBytes = Encoding.ASCII.GetBytes(sbpl);
                            _199SATOCT40022.Query(sbplBytes);
                        }
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

        }

    }
}
