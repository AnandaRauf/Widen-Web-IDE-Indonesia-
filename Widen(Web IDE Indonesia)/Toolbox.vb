Imports System.Drawing.Imaging

Public Class Toolbox
    Private Sub ConXamppbut_Click(sender As Object, e As EventArgs) Handles ConXamppbut.Click
        Dim opx As New OpenFileDialog
        Dim exe As String
        opx.Filter = "(*.exe)|*.exe|All files (*.*)|*.*"
        If opx.ShowDialog(Me) = DialogResult.OK Then
            exe = Process.Start(opx.FileName).ToString

        End If
    End Sub

    Private Sub Browserbut_Click(sender As Object, e As EventArgs) Handles Browserbut.Click
        RIBrowser.Show()
    End Sub

End Class