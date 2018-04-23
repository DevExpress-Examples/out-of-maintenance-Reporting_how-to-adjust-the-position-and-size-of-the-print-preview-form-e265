Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace RepPrviewPosition
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As XtraReport1 = New XtraReport1()

			report.PrintingSystem.PreviewFormEx.SaveState = False
			report.PrintingSystem.PreviewFormEx.StartPosition = FormStartPosition.Manual
			report.PrintingSystem.PreviewFormEx.Location = New Point(0, 0) ' or ((XRControl)report).Location = new Point(0, 0);
			report.PrintingSystem.PreviewFormEx.Size = New Size(1200, 1000)

			report.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage, New Object() { True })

			report.ShowPreview()
		End Sub
	End Class
End Namespace