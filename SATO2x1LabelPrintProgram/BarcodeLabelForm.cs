using SATOPrinterAPI;
using System;
using System.Text;
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

            string barcodeData = inputTextBox.Text;

            string[] lines = barcodeData.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string quantity = printQuantity.Text;

            try
            {
                Success success = new Success();
                switch (printerComboBox.Text)
                {
                    case "199SATOCT4003":
                        _199SATOCT4003.Connect();

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
                                "\u001bA" +
                                "\u001bA102030406" +
                                "\u001bZ" +
                                "\u001bA" +
                                "\u001bH070\u001bV025\u001bBG02125{0}" +
                                "\u001bH110\u001bV175\u001bWB0{0}" +
                                "\u001bQ{1}\u001bZ",
                                line, quantity);

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
                                "\u001bA" +
                                "\u001bA102030406" +
                                "\u001bZ" +
                                "\u001bA" +
                                "\u001bH070\u001bV025\u001bBG02125{0}" +
                                "\u001bH110\u001bV175\u001bWB0{0}" +
                                "\u001bQ{1}\u001bZ",
                                line, quantity);

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
                                "\u001bA" +
                                "\u001bA102030406" +
                                "\u001bZ" +
                                "\u001bA" +
                                "\u001bH070\u001bV025\u001bBG02125{0}" +
                                "\u001bH110\u001bV175\u001bWB0{0}" +
                                "\u001bQ{1}\u001bZ",
                                line, quantity);

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
                                "\u001bA" +
                                "\u001bA102030406" +
                                "\u001bZ" +
                                "\u001bA" +
                                "\u001bH070\u001bV020\u001bBG02125{0}" +
                                "\u001bH110\u001bV160\u001bWB0{0}" +
                                "\u001bQ{1}\u001bZ",
                                line, quantity);

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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainForm landing = new MainForm();
            this.Hide();
            landing.ShowDialog();
            this.Close();
        }

    }
}
