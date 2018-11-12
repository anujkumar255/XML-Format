using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLFormat
{
    public partial class XMLFormat : Form
    {

        bool flagMax;
        public XMLFormat()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        public static String PrintXML(String XML)
        {
            String Result = "";

            MemoryStream mStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
            XmlDocument document = new XmlDocument();

            try
            {
                // Load the XmlDocument with the XML.
                document.LoadXml(XML);

                writer.Formatting = Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                mStream.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader sReader = new StreamReader(mStream);

                // Extract the text from the StreamReader.
                String FormattedXML = sReader.ReadToEnd();

                Result = FormattedXML;
            }
            catch (XmlException)
            {
                MessageBox.Show("Invalid XML");
                return string.Empty;
            }

            mStream.Close();
            writer.Close();
            return Result;
        }


        private void btnCopyToClipBoard_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(xmlEditor.Text);
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            xmlEditor.Text= PrintXML(txtInput.Text);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            xmlEditor.Text = string.Empty;
            txtInput.Text = string.Empty;
        }

        private void btnDock_Click(object sender, EventArgs e)
        {
            if (!flagMax)
            {
                xmlEditor.Dock = DockStyle.Fill;
                flagMax = true;
            }
            else
            {
                xmlEditor.Dock = DockStyle.None;
                flagMax = false;
            }
        }
    }
}
