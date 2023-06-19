using System;
using System.Windows.Forms;

namespace SerialBarcodeLabelPrint
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (System.IO.FileLoadException ex)
            {
                string fileName = ex.FileName;
                Console.WriteLine("FileLoadException: " + ex.Message);
                Console.WriteLine("File Name: " + fileName);
            }
        }
    }

}

