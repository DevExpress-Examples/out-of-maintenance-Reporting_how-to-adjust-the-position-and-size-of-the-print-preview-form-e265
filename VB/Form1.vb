Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace RepPrviewPosition
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim tool As New ReportPrintTool(New XtraReport1())

			tool.PreviewForm.SaveState = False
			tool.PreviewForm.StartPosition = FormStartPosition.Manual
			tool.PreviewForm.Location = New Point(0, 0)
			tool.PreviewForm.Size = New Size(1200, 1000)

			tool.PreviewForm.PrintControl.ExecCommand(PrintingSystemCommand.ZoomToWholePage, New Object() { True })

			tool.ShowPreview()
		End Sub
	End Class
End Namespace