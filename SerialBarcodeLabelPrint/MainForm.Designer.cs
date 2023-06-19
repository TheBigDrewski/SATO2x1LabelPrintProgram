using SATOPrinterAPI;
using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    internal partial class MainForm
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //
        //MainForm Variable Declarations
        //
        private TableLayoutPanel mainLayoutPanel;
        private TextBox inputTextBox;
        private Button printButton;
        private ComboBox printerComboBox;
        private TextBox printQuantity;
        private Label textBoxInfo;
        private Label quantityBoxInfo;
        private readonly Success success = new Success();
        private readonly Printer SATOTest = new Printer();
        private readonly Printer _199SATOCT4003 = new Printer();
        private readonly Printer _199SATOCT4004 = new Printer();
        private readonly Printer _199SATOCT4006 = new Printer();
        private readonly Printer _199SATOCT40022 = new Printer();

        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.printButton = new System.Windows.Forms.Button();
            this.printerComboBox = new System.Windows.Forms.ComboBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.printQuantity = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.Label();
            this.quantityBoxInfo = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.43382F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27941F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.470588F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.mainLayoutPanel.Controls.Add(this.printButton, 1, 2);
            this.mainLayoutPanel.Controls.Add(this.printerComboBox, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.inputTextBox, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.printQuantity, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.textBoxInfo, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.quantityBoxInfo, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.32394F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(584, 361);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(329, 307);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(223, 31);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printerComboBox
            // 
            this.printerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerComboBox.Items.AddRange(new object[] {
            "199SATOCT4003",
            "199SATOCT4004",
            "199SATOCT4006",
            "199SATOCT40022",
            "SATOTest"});
            this.printerComboBox.Location = new System.Drawing.Point(23, 307);
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Size = new System.Drawing.Size(300, 28);
            this.printerComboBox.TabIndex = 2;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(23, 59);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(300, 242);
            this.inputTextBox.TabIndex = 0;
            // 
            // printQuantity
            // 
            this.printQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printQuantity.Location = new System.Drawing.Point(329, 59);
            this.printQuantity.Name = "printQuantity";
            this.printQuantity.Size = new System.Drawing.Size(223, 26);
            this.printQuantity.TabIndex = 3;
            this.printQuantity.Text = "1";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.AutoSize = true;
            this.textBoxInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.Location = new System.Drawing.Point(23, 20);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(300, 32);
            this.textBoxInfo.TabIndex = 4;
            this.textBoxInfo.Text = "List the serial numbers here. Make sure each serial is on a separate line.";
            // 
            // quantityBoxInfo
            // 
            this.quantityBoxInfo.AutoSize = true;
            this.quantityBoxInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBoxInfo.Location = new System.Drawing.Point(329, 20);
            this.quantityBoxInfo.Name = "quantityBoxInfo";
            this.quantityBoxInfo.Size = new System.Drawing.Size(212, 32);
            this.quantityBoxInfo.TabIndex = 5;
            this.quantityBoxInfo.Text = "Input the number of times you want to print the labels";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.mainLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Serial Barcode Printing Program for SATO";
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        public void SetupSATO()
        {
            //SATOTest
            SATOTest.Interface = Printer.InterfaceType.TCPIP;
            SATOTest.TCPIPAddress = "10.10.200.82";
            SATOTest.TCPIPPort = "9100";
            //199SATOCT4003 - Building 200 - Prep Station 4
            _199SATOCT4003.Interface = Printer.InterfaceType.TCPIP;
            _199SATOCT4003.TCPIPAddress = "10.10.199.220";
            _199SATOCT4003.TCPIPPort = "9100";
            //199SATOCT4004 - Building 200 - Prep Station 2
            _199SATOCT4004.Interface = Printer.InterfaceType.TCPIP;
            _199SATOCT4004.TCPIPAddress = "10.10.200.27";
            _199SATOCT4004.TCPIPPort = "9100";
            //199SATOCT4006 - Building 200 - Prep Station 3
            _199SATOCT4006.Interface = Printer.InterfaceType.TCPIP;
            _199SATOCT4006.TCPIPAddress = "10.10.200.29";
            _199SATOCT4006.TCPIPPort = "9100";
            //199SATOCT40022 - Building 200 - Receiving
            _199SATOCT40022.Interface = Printer.InterfaceType.TCPIP;
            _199SATOCT40022.TCPIPAddress = "10.10.199.225";
            _199SATOCT40022.TCPIPPort = "9100";

        }

    }
}
