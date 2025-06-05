using SATOPrinterAPI;
using System.Text;

namespace SATO2x1LabelPrintProgram
{
    public class SATOPrinterFunctions
    {
        public static void Print(string selection, string sbpl)
        {
            switch (selection)
            {
                case "SATOTest":
                    //
                    // SATOTest Example
                    //
                    Printer SATOTest = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "192.168.1.100", //Set the correct IP address for the SATO printer here
                        TCPIPPort = "9100"
                    };
                    SATOTest.Connect();
                    SATOTest.Query(Encoding.ASCII.GetBytes(sbpl));                   
                    SATOTest.Disconnect();
                    break;

            }
        }

    }
}
