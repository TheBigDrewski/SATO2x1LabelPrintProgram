using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    partial class ExceptionForm
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
        private TableLayoutPanel errorLayoutPanel;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.Label stackTrace;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionForm));
            this.errorLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.stackTrace = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.errorLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLayoutPanel
            // 
            this.errorLayoutPanel.ColumnCount = 1;
            this.errorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.453958F));
            this.errorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.09209F));
            this.errorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.292407F));
            this.errorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.errorLayoutPanel.Controls.Add(this.stackTrace, 0, 0);
            this.errorLayoutPanel.Controls.Add(this.exceptionLabel, 0, 1);
            this.errorLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.errorLayoutPanel.Name = "errorLayoutPanel";
            this.errorLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.errorLayoutPanel.RowCount = 2;
            this.errorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.86878F));
            this.errorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.13122F));
            this.errorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.errorLayoutPanel.Size = new System.Drawing.Size(1279, 455);
            this.errorLayoutPanel.TabIndex = 0;
            // 
            // stackTrace
            // 
            this.stackTrace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stackTrace.AutoSize = true;
            this.stackTrace.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stackTrace.Location = new System.Drawing.Point(602, 111);
            this.stackTrace.Name = "stackTrace";
            this.stackTrace.Size = new System.Drawing.Size(75, 20);
            this.stackTrace.TabIndex = 1;
            this.stackTrace.Text = "stackTrace";
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exceptionLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exceptionLabel.Location = new System.Drawing.Point(588, 318);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(102, 20);
            this.exceptionLabel.TabIndex = 0;
            this.exceptionLabel.Text = "exceptionLabel";
            // 
            // ExceptionForm
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1279, 455);
            this.Controls.Add(this.errorLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.errorLayoutPanel.ResumeLayout(false);
            this.errorLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}