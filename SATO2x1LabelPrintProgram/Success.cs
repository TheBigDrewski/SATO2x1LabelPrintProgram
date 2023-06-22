using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SATO2x1LabelPrintProgram
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
            Timeout();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Timeout()
        {
            await Task.Delay(3000);
            this.Close();
        }
    }
}
