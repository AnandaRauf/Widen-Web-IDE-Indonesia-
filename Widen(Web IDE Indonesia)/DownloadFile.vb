Imports System.Net

Public Class DownloadFile




    Public WithEvents Download As WebClient
    Private Sub DownloadBut_Click(sender As Object, e As EventArgs) Handles DownloadBut.Click

        Try
            Download = New WebClient
            Download.DownloadFileAsync(New Uri(URLFileBox.Text), PathFileBox.Text)

        Catch ex As Exception
            MessageBox.Show("Error Downloading ..." & ex.Message, "Please Check Your Message !")
        End Try
    End Sub

    Private Sub Download_ProgChanged(Sender As Object, e As DownloadProgressChangedEventArgs) Handles Download.DownloadProgressChanged
        ProgressBarDownload.Value = e.ProgressPercentage
        StatusDownload_LBL.Text = e.ProgressPercentage.ToString() + "%"
        lbl_In.Text = String.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))

    End Sub

    Private Sub BackBut_Click(sender As Object, e As EventArgs) Handles BackBut.Click
        Me.Hide()
        RIBrowser.Show()
    End Sub



    Private Sub CoPasteBut_Click(sender As Object, e As EventArgs) Handles CoPasteBut.Click
        Dim copypaste
        copypaste = My.Computer.Clipboard.GetText()
        URLFileBox.Text = copypaste

    End Sub

    Private Sub BrowseFileBut_Click(sender As Object, e As EventArgs) Handles BrowseFileBut.Click
        SaveFileDialog.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png|(*.ico)|*.ico|All files (*.*)|*.*"
        SaveFileDialog.ShowDialog()
        PathFileBox.Text = SaveFileDialog.FileName

    End Sub


End Class