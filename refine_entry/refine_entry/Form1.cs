using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refine_entry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

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
            }
        }
    }
}
