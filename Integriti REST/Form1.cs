using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integriti_REST
{
    public partial class frmMain : Form
    {
        string url = "";
        public frmMain()
        {
            InitializeComponent();
        }
        static string restRequest(string method, string message, string url, string contentType = "")
        {
            try {
                if (method.ToUpper() == "POST") {
                    url += "/DB";
                }
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                byte[] requestInFormOfBytes = System.Text.Encoding.ASCII.GetBytes(message);
                request.Method = method.ToUpper();
                request.ContentType = contentType;
                request.ContentLength = requestInFormOfBytes.Length;
                if (method.ToUpper() == "POST") {
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(requestInFormOfBytes, 0, requestInFormOfBytes.Length);
                    requestStream.Close();
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader respStream = new StreamReader(response.GetResponseStream(), System.Text.Encoding.Default);
                string receivedResponse = respStream.ReadToEnd();
                respStream.Close();
                response.Close();
                return receivedResponse;
            }
            catch (WebException e) {
                return "Error: " + e;

            }
        }
        static void SendXML(string xmlMessage, string url)
        {
            Console.WriteLine(restRequest("POST", xmlMessage, url, "text/xml;charset=utf-8"));
        }
        private void btnUrl_click(object sender, EventArgs e)
        {
            url = tbUrl.Text;
        }
        private void btnXmlFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog xmlFileDialog = new OpenFileDialog();
            xmlFileDialog.Title = "Open XML File";
            xmlFileDialog.Filter = "XML files|*.xml";
            xmlFileDialog.InitialDirectory = @"C:\";
            if (xmlFileDialog.ShowDialog() == DialogResult.OK) {
                tbXml.Text = File.ReadAllText(xmlFileDialog.FileName);
            }
        }
    }
}
