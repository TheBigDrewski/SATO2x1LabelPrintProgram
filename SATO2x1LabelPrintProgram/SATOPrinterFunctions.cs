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
                case "199SATOCT4003":
                    //
                    //199SATOCT4003 - Building 200 - Prep Station 4
                    //
                    Printer _199SATOCT4003 = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "10.10.199.220",
                        TCPIPPort = "9100"
                    };
                    _199SATOCT4003.Connect();
                    _199SATOCT4003.Query(Encoding.ASCII.GetBytes(sbpl));                   
                    _199SATOCT4003.Disconnect();
                    break;

                case "199SATOCT4004":
                    //
                    //199SATOCT4004 - Building 200 - Prep Station 2
                    //
                    Printer _199SATOCT4004 = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "10.10.200.27",
                        TCPIPPort = "9100"
                    };
                    _199SATOCT4004.Connect();
                    _199SATOCT4004.Query(Encoding.ASCII.GetBytes(sbpl));                    
                    _199SATOCT4004.Disconnect();
                    break;
                case "199SATOCT4006":
                    //
                    //199SATOCT4006 - Building 200 - Prep Station 3
                    //
                    Printer _199SATOCT4006 = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "10.10.200.29",
                        TCPIPPort = "9100"
                    };
                    _199SATOCT4006.Connect();
                    _199SATOCT4006.Query(Encoding.ASCII.GetBytes(sbpl));                    
                    _199SATOCT4006.Disconnect();
                    break;
                case "199SATOCT4007":
                    //
                    //199SATOCT4007 - Building 230 - Manual EPA Fill
                    //
                    Printer _199SATOCT4007 = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "10.10.200.50",
                        TCPIPPort = "9100"
                    };
                    _199SATOCT4007.Connect();
                    _199SATOCT4007.Query(Encoding.ASCII.GetBytes(sbpl));
                    _199SATOCT4007.Disconnect();
                    break;
                case "199SATOCT4008":
                    //
                    //199SATOCT4008 - Building 197 - Production Desks
                    //
                    Printer _199SATOCT4008 = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "10.10.200.31",
                        TCPIPPort = "9100"
                    };
                    _199SATOCT4008.Connect();
                    _199SATOCT4008.Query(Encoding.ASCII.GetBytes(sbpl));
                    _199SATOCT4008.Disconnect();
                    break;
                case "199SATOCT4009":
                    //
                    //199SATOCT4009 - Building 210 - Outside Break Room
                    //
                    Printer _199SATOCT4009 = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "10.10.200.32",
                        TCPIPPort = "9100"
                    };
                    _199SATOCT4009.Connect();
                    _199SATOCT4009.Query(Encoding.ASCII.GetBytes(sbpl));                   
                    _199SATOCT4009.Disconnect();
                    break;
                case "SATOTest":
                    //
                    // SATOTest
                    //
                    Printer SATOTest = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "10.10.200.82",
                        TCPIPPort = "9100"
                    };
                    SATOTest.Connect();
                    SATOTest.Query(Encoding.ASCII.GetBytes(sbpl));                   
                    SATOTest.Disconnect();
                    break;
                case "199SATOCT40022":
                    //
                    // 199SATOCT40022 - Building 200 - Receiving
                    //
                    Printer _199SATOCT40022 = new Printer
                    {
                        Interface = Printer.InterfaceType.TCPIP,
                        TCPIPAddress = "10.10.199.225",
                        TCPIPPort = "9100",
                        PermanentConnect = true
                    };
                    _199SATOCT40022.Connect();
                    _199SATOCT40022.Query(Encoding.ASCII.GetBytes(sbpl));                    
                    _199SATOCT40022.Disconnect();
                    break;
            }
        }

    }
}
