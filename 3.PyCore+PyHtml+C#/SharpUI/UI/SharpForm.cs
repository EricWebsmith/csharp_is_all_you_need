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
    public partial class SharpForm : Form
    {

        public SharpForm()
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

            webBrowser1.Navigate(Directory.GetCurrentDirectory()+"/py/display.html");
        }
    }
}
