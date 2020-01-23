Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If LoadingBar.Value < 100 Then
            LoadingBar.Value += 5
        ElseIf LoadingBar.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Loading Complete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            WebIDE.Show()

        End If
        If LoadingBar.Value = 5 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 10 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 15 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 20 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 25 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 30 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 35 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 40 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 45 Then
            Status_loadingLBL.ForeColor = Color.Red
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 50 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 55 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 60 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 65 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 70 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 75 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 80 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 85 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 90 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 95 Then
            Status_loadingLBL.ForeColor = Color.Yellow
            Status_loadingLBL.Text = "Loading..."
        ElseIf LoadingBar.Value = 100 Then
            Status_loadingLBL.ForeColor = Color.Green
            Status_loadingLBL.Text = "Loading Complete !"
        End If
        Percent_loadingLBL.Text = LoadingBar.Value & "%"
    End Sub

    Private Sub LoadingBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
