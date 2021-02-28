using System;
using System.Windows.Forms;

namespace SharpUI.Debug
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settings = SharpUI.Debug.Properties.Settings.Default;
            if(args.Length == 4)
            {
                settings.package = args[0];
                settings.category = args[1];
                settings.algorithm = args[2];
                settings.dataset = args[3];
            }
            Application.Run(new DebugForm());
        }
    }
}
