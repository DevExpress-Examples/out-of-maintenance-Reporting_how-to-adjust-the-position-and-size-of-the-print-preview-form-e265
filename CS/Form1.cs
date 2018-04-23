using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace RepPrviewPosition {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ReportPrintTool tool = new ReportPrintTool(new XtraReport1());

            tool.PreviewForm.SaveState = false;
            tool.PreviewForm.StartPosition = FormStartPosition.Manual;
            tool.PreviewForm.Location = new Point(0, 0);
            tool.PreviewForm.Size = new Size(1200, 1000);

            tool.PreviewForm.PrintControl.ExecCommand(PrintingSystemCommand.ZoomToWholePage, 
                new object[] { true });

            tool.ShowPreview();
        }
    }
}