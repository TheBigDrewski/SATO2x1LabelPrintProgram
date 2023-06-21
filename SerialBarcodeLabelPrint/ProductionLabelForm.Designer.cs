using SATOPrinterAPI;
using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    public partial class ProductionLabelForm : Form
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
        private TableLayoutPanel productionLayoutPanel;
        private TextBox lotTextBox;
        private TextBox fillDateTextBox;
        private TextBox productTextBox;
        private TextBox serialTextBox;
        private TextBox printQuantityTextBox;
        private Button printButton;
        private Button home;
        private Label lotInfo;
        private Label fillDateInfo;
        private Label productInfo;
        private Label serialInfo;
        private Label printQuantityInfo;
        private ComboBox printerComboBox;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChemoursForm));
            this.productionLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.home = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.lotInfo = new System.Windows.Forms.Label();
            this.fillDateInfo = new System.Windows.Forms.Label();
            this.productInfo = new System.Windows.Forms.Label();
            this.lotTextBox = new System.Windows.Forms.TextBox();
            this.fillDateTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.printerComboBox = new System.Windows.Forms.ComboBox();
            this.serialInfo = new System.Windows.Forms.Label();
            this.printQuantityInfo = new System.Windows.Forms.Label();
            this.printQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productionLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productionLayoutPanel
            // 
            this.productionLayoutPanel.ColumnCount = 2;
            this.productionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.15385F));
            this.productionLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.84615F));
            this.productionLayoutPanel.Controls.Add(this.home, 1, 8);
            this.productionLayoutPanel.Controls.Add(this.printButton, 1, 7);
            this.productionLayoutPanel.Controls.Add(this.lotInfo, 0, 0);
            this.productionLayoutPanel.Controls.Add(this.fillDateInfo, 0, 1);
            this.productionLayoutPanel.Controls.Add(this.productInfo, 0, 2);
            this.productionLayoutPanel.Controls.Add(this.lotTextBox, 1, 0);
            this.productionLayoutPanel.Controls.Add(this.fillDateTextBox, 1, 1);
            this.productionLayoutPanel.Controls.Add(this.productTextBox, 1, 2);
            this.productionLayoutPanel.Controls.Add(this.serialTextBox, 1, 5);
            this.productionLayoutPanel.Controls.Add(this.printerComboBox, 0, 7);
            this.productionLayoutPanel.Controls.Add(this.serialInfo, 0, 5);
            this.productionLayoutPanel.Controls.Add(this.printQuantityInfo, 0, 6);
            this.productionLayoutPanel.Controls.Add(this.printQuantityTextBox, 1, 6);
            this.productionLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.productionLayoutPanel.Name = "productionLayoutPanel";
            this.productionLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.productionLayoutPanel.RowCount = 9;
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.productionLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.productionLayoutPanel.Size = new System.Drawing.Size(560, 466);
            this.productionLayoutPanel.TabIndex = 0;
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Location = new System.Drawing.Point(211, 403);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(326, 40);
            this.home.TabIndex = 9;
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
            this.printButton.TabIndex = 8;
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
            this.fillDateInfo.Text = "FILL DATE:";
            // 
            // productInfo
            // 
            this.productInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.productInfo.AutoSize = true;
            this.productInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInfo.Location = new System.Drawing.Point(111, 142);
            this.productInfo.Name = "productInfo";
            this.productInfo.Size = new System.Drawing.Size(94, 20);
            this.productInfo.Text = "NET WEIGHT:";
            // 
            // serialInfo
            // 
            this.serialInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.serialInfo.AutoSize = true;
            this.serialInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialInfo.Location = new System.Drawing.Point(84, 277);
            this.serialInfo.Name = "serialInfo";
            this.serialInfo.Size = new System.Drawing.Size(121, 20);
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
            this.printQuantityInfo.Text = "NUMBER OF LABELS TO PRINT:";
            this.printQuantityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lotTextBox
            // 
            this.lotTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lotTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotTextBox.Location = new System.Drawing.Point(211, 34);
            this.lotTextBox.Name = "lotTextBox";
            this.lotTextBox.Size = new System.Drawing.Size(326, 26);
            this.lotTextBox.KeyDown += TextBox_KeyDown;
            this.lotTextBox.TabIndex = 0;
            // 
            // fillDateTextBox
            // 
            this.fillDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillDateTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillDateTextBox.Location = new System.Drawing.Point(211, 89);
            this.fillDateTextBox.Name = "fillDateTextBox";
            this.fillDateTextBox.Size = new System.Drawing.Size(326, 26);
            this.fillDateTextBox.KeyDown += TextBox_KeyDown;
            this.fillDateTextBox.TabIndex = 1;
            // 
            // productTextBox
            // 
            this.productTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTextBox.Location = new System.Drawing.Point(211, 139);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(326, 26);
            this.productTextBox.KeyDown += TextBox_KeyDown;
            this.productTextBox.TabIndex = 2;
            // 
            // serialTextBox
            // 
            this.serialTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serialTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialTextBox.Location = new System.Drawing.Point(211, 274);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(326, 26);
            this.serialTextBox.KeyDown += TextBox_KeyDown;
            this.serialTextBox.TabIndex = 3;
            // 
            // printQuantityTextBox
            // 
            this.printQuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printQuantityTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printQuantityTextBox.Location = new System.Drawing.Point(211, 319);
            this.printQuantityTextBox.Name = "printQuantityTextBox";
            this.printQuantityTextBox.Size = new System.Drawing.Size(326, 26);
            this.printQuantityTextBox.KeyDown += TextBox_KeyDown;
            this.printQuantityTextBox.TabIndex = 4;
            this.printQuantityTextBox.Text = "1";
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
            this.printerComboBox.TabIndex = 5;
            // 
            // ChemoursForm
            // 
            this.ClientSize = new System.Drawing.Size(560, 466);
            this.Controls.Add(this.productionLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ProductionLabelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production Label Printing Program";
            this.productionLayoutPanel.ResumeLayout(false);
            this.productionLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
