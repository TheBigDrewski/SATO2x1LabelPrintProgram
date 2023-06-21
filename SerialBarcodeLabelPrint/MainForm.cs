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
            ChemoursForm chem = new ChemoursForm();
            this.Hide();
            chem.ShowDialog();
            this.Close();
        }

        private void BarcodeButtonClick(object sender, EventArgs e)
        {
            BarcodeLabelForm barcode = new BarcodeLabelForm();
            this.Hide();
            barcode.ShowDialog();
            this.Close();
        }

        private void ProductionButtonClick(object sender, EventArgs e)
        {
            ProductionLabelForm prod = new ProductionLabelForm();
            this.Hide();
            prod.ShowDialog();
            this.Close();
        }
    }
}
