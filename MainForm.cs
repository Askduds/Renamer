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

namespace Renamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //TODO : Sanitise literally any of this
            string folder = txtFolder.Text;
            string fileMask = txtSearchString.Text;

            string textToFind = txtTxtToFind.Text;
            string textToReplace = txtTxtToReplace.Text;

            DirectoryInfo dir = new DirectoryInfo(folder);
            List<FileInfo> files = new List<FileInfo>();
            files.AddRange(dir.GetFiles(fileMask));

            foreach(FileInfo file in files)
            {
                string originalFilename = file.Name;
                string filename = file.Name;

                if (rbReplace.Checked)
                {
                    filename = originalFilename.Replace(textToFind, textToReplace);
                }
                if (rbPrepend.Checked)
                {
                    filename = textToReplace + originalFilename;
                }
                if(rbPostpend.Checked)
                {
                    filename = originalFilename + textToReplace;
                }
                System.IO.File.Move(file.FullName, file.Directory + "\\" + filename);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
