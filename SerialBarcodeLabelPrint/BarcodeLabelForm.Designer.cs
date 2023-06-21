using SATOPrinterAPI;
using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    public partial class BarcodeLabelForm
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
        //BarcodeLabelForm Variable Declarations
        //
        private TableLayoutPanel barcodeLayoutPanel;
        private TextBox inputTextBox;
        private Button printButton;
        private Button home;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeLabelForm));
            this.barcodeLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.printButton = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.printerComboBox = new System.Windows.Forms.ComboBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.printQuantity = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.Label();
            this.quantityBoxInfo = new System.Windows.Forms.Label();
            this.barcodeLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // barcodeLayoutPanel
            // 
            this.barcodeLayoutPanel.ColumnCount = 2;
            this.barcodeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.43382F));
            this.barcodeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27941F));
            this.barcodeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.470588F));
            this.barcodeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.barcodeLayoutPanel.Controls.Add(this.printButton, 1, 2);
            this.barcodeLayoutPanel.Controls.Add(this.home, 2, 3);
            this.barcodeLayoutPanel.Controls.Add(this.printerComboBox, 0, 2);
            this.barcodeLayoutPanel.Controls.Add(this.inputTextBox, 0, 1);
            this.barcodeLayoutPanel.Controls.Add(this.printQuantity, 1, 1);
            this.barcodeLayoutPanel.Controls.Add(this.textBoxInfo, 0, 0);
            this.barcodeLayoutPanel.Controls.Add(this.quantityBoxInfo, 1, 0);
            this.barcodeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.barcodeLayoutPanel.Name = "barcodeLayoutPanel";
            this.barcodeLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.barcodeLayoutPanel.RowCount = 4;
            this.barcodeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.barcodeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.36842F));
            this.barcodeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.barcodeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.barcodeLayoutPanel.Size = new System.Drawing.Size(584, 447);
            this.barcodeLayoutPanel.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(334, 356);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(227, 32);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Location = new System.Drawing.Point(334, 394);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(227, 30);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.HomeButton_Click);
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
            this.printerComboBox.Location = new System.Drawing.Point(23, 356);
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Size = new System.Drawing.Size(305, 28);
            this.printerComboBox.TabIndex = 2;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(25, 65);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(300, 285);
            this.inputTextBox.TabIndex = 0;
            // 
            // printQuantity
            // 
            this.printQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printQuantity.Location = new System.Drawing.Point(334, 65);
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
            this.textBoxInfo.Size = new System.Drawing.Size(303, 32);
            this.textBoxInfo.TabIndex = 4;
            this.textBoxInfo.Text = "List the serial numbers here. Make sure each serial is on a separate line.";
            // 
            // quantityBoxInfo
            // 
            this.quantityBoxInfo.AutoSize = true;
            this.quantityBoxInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBoxInfo.Location = new System.Drawing.Point(334, 20);
            this.quantityBoxInfo.Name = "quantityBoxInfo";
            this.quantityBoxInfo.Size = new System.Drawing.Size(212, 32);
            this.quantityBoxInfo.TabIndex = 5;
            this.quantityBoxInfo.Text = "Input the number of times you want to print the labels";
            // 
            // BarcodeLabelForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 447);
            this.Controls.Add(this.barcodeLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BarcodeLabelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Barcode Label Print Program";
            this.barcodeLayoutPanel.ResumeLayout(false);
            this.barcodeLayoutPanel.PerformLayout();
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
