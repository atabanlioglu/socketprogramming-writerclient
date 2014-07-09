using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

namespace WriterClient_Computer
{
    public partial class WriterClient_Computer : Form
    {
        public WriterClient_Computer()
        {
            InitializeComponent();
        }
        #region gönderilecek bilgileri byte çevirme
        class property
        {
            public string DateTime;
            public string UserName;
            public string OperatingSystem;
            public string cpuUsage;
            public string Title;
            public string StackTrace;
            public string TotalMemory;
            public string MachineName;
            public byte[] GetData()
            {
                List<byte> result = new List<byte>();

                string[] strings = new string[6] { MachineName, StackTrace, UserName, DateTime, cpuUsage, TotalMemory };
                foreach (string s in strings)
                {
                    
                    foreach (byte b in Encoding.ASCII.GetBytes(s))
                        result.Add(b);
                }
                return result.ToArray();
            }
        #endregion
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        Socket server1;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnBasla.Enabled = false;
            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostByName(host);
            string ipAdresi = ip.AddressList[0].ToString();
           
            while (true)
            {
                Console.WriteLine("This is a Provider, host name is {0}", Dns.GetHostName());

                //Set the IP address of the server, and its port.
                //IPEndPoint ipep1 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);// servere end point noktası açma
                IPEndPoint ipep1 = new IPEndPoint(IPAddress.Parse(txtIpAdresi.Text), Convert.ToInt32(txt_Port.Text));// servere end point noktası açma
                try
                {
                    while (true)
                    {
                        server1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                        string cpu = performanceCpu.NextValue().ToString();
                        string ram = performanceRam.NextValue().ToString();

                        property prop = new property();
                        prop.MachineName = "Makine Ismi : " + Environment.MachineName + "\n";
                        prop.StackTrace = "IP Adresi : " + ipAdresi;
                        prop.DateTime = "\tTarih : " + DateTime.Now.ToString();
                        prop.UserName = "\tKullanici Adi : " + Environment.UserName;
                        prop.cpuUsage = "\tCPU : % " + 2;
                        prop.TotalMemory = "\tKullanilabilir Bellek :" + ram + " MB \n\n\n";
                        

                        server1.Connect(ipep1);//servere bağlanma
                        server1.Send(prop.GetData());// bilgileri byte dizisi olarak gönderme

                        Thread.Sleep(1000);//thread uyutma

                    }
                    server1.Close();// bağlantıyı kapatma

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            server1.Close();
        }
    }
}
