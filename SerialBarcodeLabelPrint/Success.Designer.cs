using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    partial class Success
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

        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.     
        private TableLayoutPanel successLayoutPanel;
        private System.Windows.Forms.Label printLabel;
        private System.Windows.Forms.Button okButton;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success));
            this.successLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.printLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.successLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // successLayoutPanel
            // 
            this.successLayoutPanel.ColumnCount = 1;
            this.successLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.453958F));
            this.successLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.09209F));
            this.successLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.292407F));
            this.successLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.successLayoutPanel.Controls.Add(this.printLabel, 0, 0);
            this.successLayoutPanel.Controls.Add(this.okButton, 0, 1);
            this.successLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.successLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.successLayoutPanel.Name = "successLayoutPanel";
            this.successLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.successLayoutPanel.RowCount = 2;
            this.successLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.successLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.successLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.successLayoutPanel.Size = new System.Drawing.Size(170, 144);
            this.successLayoutPanel.TabIndex = 0;
            // 
            // printLabel
            // 
            this.printLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printLabel.AutoSize = true;
            this.printLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printLabel.Location = new System.Drawing.Point(23, 30);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(124, 32);
            this.printLabel.TabIndex = 0;
            this.printLabel.Text = "Labels have been sent to the printer";
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(55, 89);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(60, 32);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Success
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(170, 144);
            this.Controls.Add(this.successLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Label Sent";
            this.successLayoutPanel.ResumeLayout(false);
            this.successLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}