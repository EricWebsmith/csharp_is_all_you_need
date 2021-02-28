using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        int fileIndex = 0;
        FileInfo[] files = new FileInfo[] { };

        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "python.exe";
            p.StartInfo.Arguments = "visualize.py";
            p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory() + "/py";
            p.StartInfo.UseShellExecute = false;
            p.Start();
            p.WaitForExit();
            
            
            DirectoryInfo di = new DirectoryInfo("py/");
            files = di.GetFiles("*.png");
            fileIndex = 0;

            this.linePictureBox.Image = Image.FromFile(files[0].FullName);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (fileIndex > 1)
            {
                fileIndex--;
            }
            this.linePictureBox.Image = Image.FromFile(files[fileIndex].FullName);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (fileIndex < files.Length - 2)
            {
                fileIndex++;
            }
            this.linePictureBox.Image = Image.FromFile(files[fileIndex].FullName);
        }
    }
}
