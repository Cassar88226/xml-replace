using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace refine_entry
{
    public partial class Replace_Tag : Form
    {
        private string m_fullText;

        public Replace_Tag()
        {
            InitializeComponent();
            m_fullText = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtReplace.Text == "" || filePath.Text == "")
                return;
            if (m_fullText == null)
                return;

            Regex MatchPhrase = new Regex("<NewPart>[0-9|A-Z|a-z]*</NewPart>");
            m_fullText = MatchPhrase.Replace(m_fullText,"<NewPart>" + txtReplace.Text + "</NewPart>");

            txtXMLDoc.Text = m_fullText;
            File.WriteAllText(filePath.Text, m_fullText);
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Browse Files";
            openFileDialog.Filter = "flpart files (*.flpart)|*.flpart|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = openFileDialog.FileName;

                m_fullText = File.ReadAllText(filePath.Text);
                txtXMLDoc.Text = m_fullText;

                //                 XmlDocument doc = new XmlDocument();
                //                 doc.Load(filePath.Text);
            }
        }
    }
}
