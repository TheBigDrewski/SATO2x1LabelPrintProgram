using System.Windows.Forms;

namespace SATO2x1LabelPrintProgram
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
        private Button production;
        private PictureBox chemoursLabelExample;
        private PictureBox barcodeLabelExample;
        private PictureBox productionLabelExample;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chemours = new System.Windows.Forms.Button();
            this.barcode = new System.Windows.Forms.Button();
            this.production = new System.Windows.Forms.Button();
            this.chemoursLabelExample = new System.Windows.Forms.PictureBox();
            this.barcodeLabelExample = new System.Windows.Forms.PictureBox();
            this.productionLabelExample = new System.Windows.Forms.PictureBox();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chemoursLabelExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeLabelExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLabelExample)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.Controls.Add(this.chemours, 0, 1);
            this.mainLayoutPanel.Controls.Add(this.barcode, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.production, 2, 1);
            this.mainLayoutPanel.Controls.Add(this.barcodeLabelExample, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.productionLabelExample, 2, 0);
            this.mainLayoutPanel.Controls.Add(this.chemoursLabelExample, 0, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.34884F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.65116F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(895, 310);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // chemours
            // 
            this.chemours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemours.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemours.Location = new System.Drawing.Point(23, 212);
            this.chemours.Name = "chemours";
            this.chemours.Size = new System.Drawing.Size(279, 75);
            this.chemours.TabIndex = 1;
            this.chemours.Text = "Chemours Label Print Program";
            this.chemours.Click += new System.EventHandler(this.ChemourButtonClick);
            // 
            // barcode
            // 
            this.barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Location = new System.Drawing.Point(308, 212);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(279, 75);
            this.barcode.TabIndex = 1;
            this.barcode.Text = "Serial Barcode Label Print Program";
            this.barcode.Click += new System.EventHandler(this.BarcodeButtonClick);
            // 
            // production
            // 
            this.production.Dock = System.Windows.Forms.DockStyle.Fill;
            this.production.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.production.Location = new System.Drawing.Point(593, 212);
            this.production.Name = "production";
            this.production.Size = new System.Drawing.Size(279, 75);
            this.production.TabIndex = 1;
            this.production.Text = "Production Label Print Program";
            this.production.Click += new System.EventHandler(this.ProductionButtonClick);
            // 
            // chemoursLabelExample
            // 
            this.chemoursLabelExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chemoursLabelExample.Image = global::SATO2x1LabelPrintProgram.Properties.Resources.ChemoursLabelExample;
            this.chemoursLabelExample.Location = new System.Drawing.Point(23, 23);
            this.chemoursLabelExample.Name = "chemoursLabelExample";
            this.chemoursLabelExample.Size = new System.Drawing.Size(279, 183);
            this.chemoursLabelExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chemoursLabelExample.TabIndex = 2;
            this.chemoursLabelExample.TabStop = false;
            // 
            // barcodeLabelExample
            // 
            this.barcodeLabelExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeLabelExample.Image = global::SATO2x1LabelPrintProgram.Properties.Resources.BarcodeLabelExample;
            this.barcodeLabelExample.Location = new System.Drawing.Point(308, 23);
            this.barcodeLabelExample.Name = "barcodeLabelExample";
            this.barcodeLabelExample.Size = new System.Drawing.Size(279, 183);
            this.barcodeLabelExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcodeLabelExample.TabIndex = 3;
            this.barcodeLabelExample.TabStop = false;
            // 
            // productionLabelExample
            // 
            this.productionLabelExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionLabelExample.Image = global::SATO2x1LabelPrintProgram.Properties.Resources.ProductionLabelExample;
            this.productionLabelExample.Location = new System.Drawing.Point(593, 23);
            this.productionLabelExample.Name = "productionLabelExample";
            this.productionLabelExample.Size = new System.Drawing.Size(279, 183);
            this.productionLabelExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productionLabelExample.TabIndex = 4;
            this.productionLabelExample.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(895, 310);
            this.Controls.Add(this.mainLayoutPanel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATO Label Print Program";
            this.mainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chemoursLabelExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeLabelExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionLabelExample)).EndInit();
            this.ResumeLayout(false);

        }
    }
}