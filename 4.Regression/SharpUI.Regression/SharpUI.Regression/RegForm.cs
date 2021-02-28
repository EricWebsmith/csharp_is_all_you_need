using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SharpUI.Regression
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            Dictionary<string, string> jsonDict = new Dictionary<string, string>();
            foreach(SettingsProperty property in settings.Properties)
            {
                jsonDict[property.Name] = (string)settings[property.Name];
            }
            Newtonsoft.Json.JsonSerializer jsonSerializer = new Newtonsoft.Json.JsonSerializer();
            jsonSerializer.Formatting = Newtonsoft.Json.Formatting.Indented;
            using (var sw =new StreamWriter("reg.json"))
            {
                jsonSerializer.Serialize(sw, jsonDict);
                sw.Flush();
                sw.Close();
            }

            Process p = new Process();
            p.StartInfo.FileName = "reg.bat";
            p.Start();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
           resultDataGridView.DataSource = Ezfx.Csv.CsvContext.ReadFile<ResultCsv>("reg_data/results.csv");
        }

        private void resultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == resultDataGridView.Columns.Count - 1)
            {
                var row = resultDataGridView.Rows[e.RowIndex];
                string package = row.Cells[0].Value.ToString();
                string category = row.Cells[1].Value.ToString();
                string algorithm = row.Cells[2].Value.ToString();
                string dataset = row.Cells[3].Value.ToString();

                Process p = new Process();
                p.StartInfo.FileName = "SharpUI.Debug.exe";
                p.StartInfo.Arguments = $"{package} {category} {algorithm} {dataset}";
                p.Start();
            }
        }
    }
}
