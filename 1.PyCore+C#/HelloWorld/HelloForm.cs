using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "python.exe";
            p.StartInfo.Arguments = "hello_world.py";
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            string result = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            backgroundLabel.Text = result;
        }

        private void foregroundButton_Click(object sender, EventArgs e)
        {
            string bat_file = "run.bat";
            string bat_content = "echo start\n";
            bat_content += "python hello_world.py\n";
            // pause the batch script.
            // this is important when running in foreground.
            bat_content += "pause";
            File.WriteAllText(bat_file, bat_content);

            Process p = new Process();
            p.StartInfo.FileName = bat_file;
            p.Start();
        }
    }
}
