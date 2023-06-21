using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    partial class MainForm
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
        private Button chemours;
        private Button barcode;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chemours = new System.Windows.Forms.Button();
            this.barcode = new System.Windows.Forms.Button();
            this.mainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.52941F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.47059F));
            this.mainLayoutPanel.Controls.Add(this.chemours, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.barcode, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(584, 361);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // chemours
            // 
            this.chemours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemours.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemours.Location = new System.Drawing.Point(23, 23);
            this.chemours.Name = "chemours";
            this.chemours.Size = new System.Drawing.Size(258, 315);
            this.chemours.TabIndex = 1;
            this.chemours.Text = "Chemours Label Print Program";
            this.chemours.Click += new System.EventHandler(this.ChemourButtonClick);
            // 
            // barcode
            // 
            this.barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Location = new System.Drawing.Point(287, 23);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(274, 315);
            this.barcode.TabIndex = 1;
            this.barcode.Text = "Serial Barcode Label Print Program";
            this.barcode.Click += new System.EventHandler(this.BarcodeButtonClick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.mainLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATO Label Print Program";
            this.mainLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}