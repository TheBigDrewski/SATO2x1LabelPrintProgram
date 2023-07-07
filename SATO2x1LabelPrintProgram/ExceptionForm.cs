using System;
using System.Drawing;
using System.Windows.Forms;

namespace SATO2x1LabelPrintProgram
{
    public partial class ExceptionForm : Form
    {

        private void ResizeFormToContent()
        {
            // Calculate the desired width and height based on the text content
            int desiredWidth = Math.Max(exceptionLabel.Width, stackTrace.Width) + 20;
            int desiredHeight = exceptionLabel.Height + stackTrace.Height + 60;

            // Set the new size of the form
            Size = new Size(desiredWidth, desiredHeight);
        }


        public ExceptionForm(Exception ex)
        {
            InitializeComponent();

            exceptionLabel.Text = ex.Message;
            stackTrace.Text = ex.StackTrace;

            ResizeFormToContent();
        }
    }
}
