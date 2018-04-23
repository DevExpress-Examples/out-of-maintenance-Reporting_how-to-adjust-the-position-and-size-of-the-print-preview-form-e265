using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace RepPrviewPosition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XtraReport1 report = new XtraReport1();

            report.PrintingSystem.PreviewFormEx.SaveState = false;
            report.PrintingSystem.PreviewFormEx.StartPosition = FormStartPosition.Manual;
            report.PrintingSystem.PreviewFormEx.Location = new Point(0, 0); // or ((XRControl)report).Location = new Point(0, 0);
            report.PrintingSystem.PreviewFormEx.Size = new Size(1200, 1000);
            
            report.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage, new object[] { true });
            
            report.ShowPreview();
        }
    }
}