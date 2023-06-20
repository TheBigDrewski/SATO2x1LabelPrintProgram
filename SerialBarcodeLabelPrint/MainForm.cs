using System;
using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ChemourButtonClick(object sender, EventArgs e)
        {
            ChemoursForm ch = new ChemoursForm();
            this.Hide();
            ch.ShowDialog();
            this.Close();
        }

        private void BarcodeButtonClick(object sender, EventArgs e)
        {
            BarcodeLabelForm bc = new BarcodeLabelForm();
            this.Hide();
            bc.ShowDialog();
            this.Close();
        }
    }
}
