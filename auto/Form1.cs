using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            subfolder.Enabled = false;
        }


        public void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {


                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

        }
       // private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e);

    }
}
