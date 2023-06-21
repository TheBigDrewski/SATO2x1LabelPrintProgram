using SATOPrinterAPI;
using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    internal partial class ChemoursForm
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
        private TableLayoutPanel chemoursLayoutPanel;
        private TextBox lotTextBox;
        private TextBox fillDateTextBox;
        private TextBox netWeightTextBox;
        private TextBox tareWeightTextBox;
        private TextBox grossWeightTextBox;
        private TextBox serialTextBox;
        private TextBox printQuantityTextBox;
        private Button printButton;
        private Button home;
        private Label lotInfo;
        private Label fillDateInfo;
        private Label netWeightInfo;
        private Label tareWeightInfo;
        private Label grossWeightInfo;
        private Label serialInfo;
        private Label printQuantityInfo;
        private ComboBox printerComboBox;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChemoursForm));
            this.chemoursLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.home = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.lotInfo = new System.Windows.Forms.Label();
            this.fillDateInfo = new System.Windows.Forms.Label();
            this.netWeightInfo = new System.Windows.Forms.Label();
            this.tareWeightInfo = new System.Windows.Forms.Label();
            this.grossWeightInfo = new System.Windows.Forms.Label();
            this.lotTextBox = new System.Windows.Forms.TextBox();
            this.fillDateTextBox = new System.Windows.Forms.TextBox();
            this.netWeightTextBox = new System.Windows.Forms.TextBox();
            this.tareWeightTextBox = new System.Windows.Forms.TextBox();
            this.grossWeightTextBox = new System.Windows.Forms.TextBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.printerComboBox = new System.Windows.Forms.ComboBox();
            this.serialInfo = new System.Windows.Forms.Label();
            this.printQuantityInfo = new System.Windows.Forms.Label();
            this.printQuantityTextBox = new System.Windows.Forms.TextBox();
            this.chemoursLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chemoursLayoutPanel
            // 
            this.chemoursLayoutPanel.ColumnCount = 2;
            this.chemoursLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.15385F));
            this.chemoursLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.84615F));
            this.chemoursLayoutPanel.Controls.Add(this.home, 1, 8);
            this.chemoursLayoutPanel.Controls.Add(this.printButton, 1, 7);
            this.chemoursLayoutPanel.Controls.Add(this.lotInfo, 0, 0);
            this.chemoursLayoutPanel.Controls.Add(this.fillDateInfo, 0, 1);
            this.chemoursLayoutPanel.Controls.Add(this.netWeightInfo, 0, 2);
            this.chemoursLayoutPanel.Controls.Add(this.tareWeightInfo, 0, 3);
            this.chemoursLayoutPanel.Controls.Add(this.grossWeightInfo, 0, 4);
            this.chemoursLayoutPanel.Controls.Add(this.lotTextBox, 1, 0);
            this.chemoursLayoutPanel.Controls.Add(this.fillDateTextBox, 1, 1);
            this.chemoursLayoutPanel.Controls.Add(this.netWeightTextBox, 1, 2);
            this.chemoursLayoutPanel.Controls.Add(this.tareWeightTextBox, 1, 3);
            this.chemoursLayoutPanel.Controls.Add(this.grossWeightTextBox, 1, 4);
            this.chemoursLayoutPanel.Controls.Add(this.serialTextBox, 1, 5);
            this.chemoursLayoutPanel.Controls.Add(this.printerComboBox, 0, 7);
            this.chemoursLayoutPanel.Controls.Add(this.serialInfo, 0, 5);
            this.chemoursLayoutPanel.Controls.Add(this.printQuantityInfo, 0, 6);
            this.chemoursLayoutPanel.Controls.Add(this.printQuantityTextBox, 1, 6);
            this.chemoursLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemoursLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemoursLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.chemoursLayoutPanel.Name = "chemoursLayoutPanel";
            this.chemoursLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.chemoursLayoutPanel.RowCount = 9;
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.chemoursLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.chemoursLayoutPanel.Size = new System.Drawing.Size(560, 466);
            this.chemoursLayoutPanel.TabIndex = 0;
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Location = new System.Drawing.Point(211, 403);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(326, 40);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // printButton
            // 
            this.printButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(211, 358);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(326, 39);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // lotInfo
            // 
            this.lotInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lotInfo.AutoSize = true;
            this.lotInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotInfo.Location = new System.Drawing.Point(106, 37);
            this.lotInfo.Name = "lotInfo";
            this.lotInfo.Size = new System.Drawing.Size(99, 20);
            this.lotInfo.TabIndex = 4;
            this.lotInfo.Text = "LOT NUMBER:";
            // 
            // fillDateInfo
            // 
            this.fillDateInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fillDateInfo.AutoSize = true;
            this.fillDateInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillDateInfo.Location = new System.Drawing.Point(125, 92);
            this.fillDateInfo.Name = "fillDateInfo";
            this.fillDateInfo.Size = new System.Drawing.Size(80, 20);
            this.fillDateInfo.TabIndex = 5;
            this.fillDateInfo.Text = "FILL DATE:";
            // 
            // netWeightInfo
            // 
            this.netWeightInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.netWeightInfo.AutoSize = true;
            this.netWeightInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWeightInfo.Location = new System.Drawing.Point(111, 142);
            this.netWeightInfo.Name = "netWeightInfo";
            this.netWeightInfo.Size = new System.Drawing.Size(94, 20);
            this.netWeightInfo.TabIndex = 4;
            this.netWeightInfo.Text = "NET WEIGHT:";
            // 
            // tareWeightInfo
            // 
            this.tareWeightInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tareWeightInfo.AutoSize = true;
            this.tareWeightInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareWeightInfo.Location = new System.Drawing.Point(102, 187);
            this.tareWeightInfo.Name = "tareWeightInfo";
            this.tareWeightInfo.Size = new System.Drawing.Size(103, 20);
            this.tareWeightInfo.TabIndex = 5;
            this.tareWeightInfo.Text = "TARE WEIGHT:";
            // 
            // grossWeightInfo
            // 
            this.grossWeightInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grossWeightInfo.AutoSize = true;
            this.grossWeightInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossWeightInfo.Location = new System.Drawing.Point(90, 232);
            this.grossWeightInfo.Name = "grossWeightInfo";
            this.grossWeightInfo.Size = new System.Drawing.Size(115, 20);
            this.grossWeightInfo.TabIndex = 4;
            this.grossWeightInfo.Text = "GROSS WEIGHT:";
            // 
            // lotTextBox
            // 
            this.lotTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lotTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotTextBox.Location = new System.Drawing.Point(211, 34);
            this.lotTextBox.Name = "lotTextBox";
            this.lotTextBox.Size = new System.Drawing.Size(326, 26);
            this.lotTextBox.TabIndex = 0;
            // 
            // fillDateTextBox
            // 
            this.fillDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillDateTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillDateTextBox.Location = new System.Drawing.Point(211, 89);
            this.fillDateTextBox.Name = "fillDateTextBox";
            this.fillDateTextBox.Size = new System.Drawing.Size(326, 26);
            this.fillDateTextBox.TabIndex = 0;
            // 
            // netWeightTextBox
            // 
            this.netWeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.netWeightTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWeightTextBox.Location = new System.Drawing.Point(211, 139);
            this.netWeightTextBox.Name = "netWeightTextBox";
            this.netWeightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.netWeightTextBox.Size = new System.Drawing.Size(326, 26);
            this.netWeightTextBox.TabIndex = 0;
            // 
            // tareWeightTextBox
            // 
            this.tareWeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tareWeightTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareWeightTextBox.Location = new System.Drawing.Point(211, 184);
            this.tareWeightTextBox.Name = "tareWeightTextBox";
            this.tareWeightTextBox.Size = new System.Drawing.Size(326, 26);
            this.tareWeightTextBox.TabIndex = 0;
            // 
            // grossWeightTextBox
            // 
            this.grossWeightTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grossWeightTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossWeightTextBox.Location = new System.Drawing.Point(211, 229);
            this.grossWeightTextBox.Name = "grossWeightTextBox";
            this.grossWeightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grossWeightTextBox.Size = new System.Drawing.Size(326, 26);
            this.grossWeightTextBox.TabIndex = 0;
            // 
            // serialTextBox
            // 
            this.serialTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serialTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialTextBox.Location = new System.Drawing.Point(211, 274);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(326, 26);
            this.serialTextBox.TabIndex = 0;
            // 
            // printerComboBox
            // 
            this.printerComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerComboBox.Items.AddRange(new object[] {
            "199SATOCT4003",
            "199SATOCT4004",
            "199SATOCT4006",
            "199SATOCT40022",
            "SATOTest"});
            this.printerComboBox.Location = new System.Drawing.Point(23, 363);
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Size = new System.Drawing.Size(182, 28);
            this.printerComboBox.Text = "199SATOCT4003";
            this.printerComboBox.TabIndex = 2;
            // 
            // serialInfo
            // 
            this.serialInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.serialInfo.AutoSize = true;
            this.serialInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialInfo.Location = new System.Drawing.Point(84, 277);
            this.serialInfo.Name = "serialInfo";
            this.serialInfo.Size = new System.Drawing.Size(121, 20);
            this.serialInfo.TabIndex = 5;
            this.serialInfo.Text = "SERIAL NUMBER:";
            this.serialInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printQuantityInfo
            // 
            this.printQuantityInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.printQuantityInfo.AutoSize = true;
            this.printQuantityInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printQuantityInfo.Location = new System.Drawing.Point(40, 312);
            this.printQuantityInfo.Name = "printQuantityInfo";
            this.printQuantityInfo.Size = new System.Drawing.Size(165, 40);
            this.printQuantityInfo.TabIndex = 5;
            this.printQuantityInfo.Text = "NUMBER OF LABELS TO PRINT:";
            this.printQuantityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printQuantityTextBox
            // 
            this.printQuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printQuantityTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printQuantityTextBox.Location = new System.Drawing.Point(211, 319);
            this.printQuantityTextBox.Name = "printQuantityTextBox";
            this.printQuantityTextBox.Size = new System.Drawing.Size(326, 26);
            this.printQuantityTextBox.TabIndex = 0;
            this.printQuantityTextBox.Text = "1";
            // 
            // ChemoursForm
            // 
            this.ClientSize = new System.Drawing.Size(560, 466);
            this.Controls.Add(this.chemoursLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChemoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chemours Label Printing Program";
            this.chemoursLayoutPanel.ResumeLayout(false);
            this.chemoursLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
