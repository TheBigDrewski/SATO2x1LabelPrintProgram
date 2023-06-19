using System;
using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
