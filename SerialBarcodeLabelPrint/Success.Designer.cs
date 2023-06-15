using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    partial class Success
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       
        private TableLayoutPanel successLayoutPanel;

        private void InitializeComponent()
        {
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
            this.successLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.45161F));
            this.successLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.54839F));
            this.successLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.successLayoutPanel.Size = new System.Drawing.Size(157, 102);
            this.successLayoutPanel.TabIndex = 0;
            // 
            // printLabel
            // 
            this.printLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printLabel.AutoSize = true;
            this.printLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printLabel.Location = new System.Drawing.Point(31, 21);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(95, 32);
            this.printLabel.TabIndex = 0;
            this.printLabel.Text = "Labels have been sent to the printer";
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(53, 58);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(50, 21);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Success
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(157, 102);
            this.Controls.Add(this.successLayoutPanel);
            this.Name = "Success";
            this.Text = "Label Sent";
            this.successLayoutPanel.ResumeLayout(false);
            this.successLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label printLabel;
        private System.Windows.Forms.Button okButton;
    }
}