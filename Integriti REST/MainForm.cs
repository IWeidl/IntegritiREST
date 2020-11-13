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
        FastColoredTextBoxNS.AutocompleteMenu popupMenu;
        string url = "";
        string controllerID = "";
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            url = "http://127.0.0.1/";

            // Set control boxes
            cbControlInputState.SelectedIndex = 0;
            cbControlAreaState.SelectedIndex = 0;
            cbControlAuxState.SelectedIndex = 0;

            // Set Review Samples Control Box
            foreach (string fileName in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Review Samples\\")) {
                cbXmlSamples.Items.Add(Path.GetFileName(fileName).Substring(0, Path.GetFileName(fileName).Length-4));
            }

            popupMenu = new FastColoredTextBoxNS.AutocompleteMenu(tbXml);
            popupMenu.MinFragmentLength = 2;
            var popupWords = new List<string>();
            popupWords = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\AutoComplete.txt").ToList();
            popupMenu.Items.SetAutocompleteItems(popupWords);
            popupMenu.Items.MaximumSize = new System.Drawing.Size(200, 300);
            popupMenu.Items.Width = 200;
        }
        static string restRequest(string method, string message, string url, string contentType = "")
        {
            try {
                if (method.ToUpper() == "POST") {
                    url += "DB";
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
        private void btnSet_Click(object sender, EventArgs e)
        {
            url = tbUrl.Text;
            controllerID = tbControllerID.Text;
        }

        static string SendXML(string xmlMessage, string url)
        {
            return restRequest("POST", xmlMessage, url, "text/xml;charset=utf-8");
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

        private void btnPostXml_Click(object sender, EventArgs e)
        {
            tbXmlResult.Text = SendXML(tbXml.Text, url);
        }
        private void btnControlInputSend_Click(object sender, EventArgs e)
        {
            if (cbControlInputState.SelectedIndex == 0) {
                tbXmlResult.Text = restRequest("GET", "", (url + "Control/TriggerInput?Controller=" + controllerID + "&Address=" + tbControlInputInputID.Text + "&Action=Trigger&InputState=InAlarm"));
            } else if (cbControlInputState.SelectedIndex == 1) {
                tbXmlResult.Text = restRequest("GET", "", (url + "Control/TriggerInput?Controller=" + controllerID + "&Address=" + tbControlInputInputID.Text + "&Action=Restore&InputState=InAlarm"));
            }
        }

        private void btnControlAreaSend_Click(object sender, EventArgs e)
        {
            if (cbControlAreaState.SelectedIndex == 0) {
                tbXmlResult.Text = restRequest("GET", "", (url + "/Control/Area?Controller=" + controllerID + "&Address=" + tbControlAreaAreaID.Text + "&Action=arm"));
            } else if (cbControlAreaState.SelectedIndex == 1) {
                tbXmlResult.Text = restRequest("GET", "", (url + "/Control/Area?Controller=" + controllerID + "&Address=" + tbControlAreaAreaID.Text + "&Action=disarm"));
            }
        }

        private void cbXmlSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbXml.Text = File.ReadAllText(Directory.GetCurrentDirectory() + "\\Review Samples\\" + cbXmlSamples.Text + ".xml");
        }

        private void btnControlAuxSend_Click(object sender, EventArgs e)
        {
            if (cbControlAuxState.SelectedIndex == 0) {
                tbXmlResult.Text = restRequest("GET", "", (url + "/Control/Aux?Controller=" + controllerID + "&Address=" + tbControlAuxAuxID.Text + "&Action=On"));
            } else if (cbControlAuxState.SelectedIndex == 1) {
                tbXmlResult.Text = restRequest("GET", "", (url + "/Control/Aux?Controller=" + controllerID + "&Address=" + tbControlAuxAuxID.Text + "&Action=Off"));
            }
        }

        private void tbXml_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
        }
    }
}
