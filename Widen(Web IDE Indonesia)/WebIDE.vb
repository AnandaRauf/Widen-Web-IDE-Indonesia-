Public Class WebIDE
    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        Dim np
        np = TextBoxEdit.Text
    End Sub
    Private Sub OpenProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProjectToolStripMenuItem.Click
        Dim opj As New OpenFileDialog
        Dim doc As String
        opj.Filter = "(*.html)|*.html|(*.php)|*.php|(*.css)|*.css|(*.js)|*.js|All files (*.*)|*.*"
        If opj.ShowDialog(Me) = DialogResult.OK Then
            doc = opj.FileName
            TextBoxEdit.Text = My.Computer.FileSystem.ReadAllText(doc)
        End If
    End Sub
    Private Sub ToolboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolboxToolStripMenuItem.Click
        Toolbox.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutApp.Show()
    End Sub

    Private Sub ShareAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShareAppToolStripMenuItem.Click
        Dim url


        url = ("https://drive.google.com/open?id=1BAEn2uHIewpM4XTRvhZXtI4GScZarEiQ")
        Clipboard.SetText(url)
        MessageBox.Show("URL has been copied")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim svpj As New SaveFileDialog
        Dim doc As String
        svpj.Filter = "(*.html)|*.html|(*.php)|*.php|(*.css)|*.css|(*.js)|*.js|All files (*.*)|*.*"
        If svpj.ShowDialog(Me) = DialogResult.OK Then
            doc = svpj.FileName
            My.Computer.FileSystem.WriteAllText(doc, TextBoxEdit.Text, True)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim svpj As New SaveFileDialog
        Dim doc As String
        svpj.Filter = "(*.html)|*.html|(*.php)|*.php|(*.css)|*.css|(*.js)|*.js|All files (*.*)|*.*"
        If svpj.ShowDialog(Me) = DialogResult.OK Then
            doc = svpj.FileName
            My.Computer.FileSystem.WriteAllText(doc, TextBoxEdit.Text, True)
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Dim undo
        undo = TextBoxEdit.CanUndo
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        Dim redo
        redo = TextBoxEdit.CanUndo
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim confirmation
        confirmation = MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")
        If confirmation = vbYes Then
            Close()
        Else

            Me.Show()
        End If
    End Sub

End Class
