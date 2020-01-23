Public Class RIBrowser
    Private Sub AdsOnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdsOnsToolStripMenuItem.Click
        MessageBox.Show("Comingsoon Feature")

    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        MessageBox.Show("Comingsoon Feature")
    End Sub
    Private Sub VPNModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VPNModeToolStripMenuItem.Click
        MessageBox.Show("Comingsoon Feature")

    End Sub
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Dim confirmation
        confirmation = MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")
        If confirmation = vbYes Then
            Close()
        Else

            Me.Show()
        End If
    End Sub
    Private Sub DownloadAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadAppsToolStripMenuItem.Click
        DownloadFile.Show()
    End Sub
    Private Sub AboutAppsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutAppsToolStripMenuItem1.Click
        AboutApp.Show()
        Me.Hide()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        RIBrowsers.Navigate("www.google.com")


    End Sub
    Private Sub RieeNetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RieeNetToolStripMenuItem.Click
        RIBrowsers.Navigate("www.riie.net")
    End Sub

    Private Sub SamehadakuTvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SamehadakuTvToolStripMenuItem.Click
        RIBrowsers.Navigate("www.samehadaku.tv")
    End Sub

    Private Sub CrunchyrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrunchyrollToolStripMenuItem.Click
        RIBrowsers.Navigate("www.crunchyroll.com")
    End Sub

    Private Sub AnibatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnibatchToolStripMenuItem.Click
        RIBrowsers.Navigate("www.anibatch.me")
    End Sub

    Private Sub ConanIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConanIDToolStripMenuItem.Click
        RIBrowsers.Navigate("www.conan.id")
    End Sub

    Private Sub Lk21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lk21ToolStripMenuItem.Click
        RIBrowsers.Navigate("www.duniafilm21.net")
    End Sub

    Private Sub IndoXX1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndoXX1ToolStripMenuItem.Click
        RIBrowsers.Navigate("www.indoxx1.network")
    End Sub


    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RIBrowsers.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        RIBrowsers.GoForward()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        RIBrowsers.Navigate(URLBox.Text)
    End Sub

    Private Sub RIBrowsers_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles RIBrowsers.DocumentCompleted
        URLBox.Text = RIBrowsers.Document.Url.AbsoluteUri

    End Sub

    Private Sub AddTabButton_Click(sender As Object, e As EventArgs) Handles AddTabButton.Click
        Dim tabpages As New TabPage
        tabpages.Text = "New Tab"
        AddTab.TabPages.Add(tabpages)
        Dim browserindo As New WebBrowser
        AddTab.SelectedTab = tabpages
        tabpages.Controls.Add(browserindo)
        browserindo.Dock = DockStyle.Fill
        RIBrowsers.Navigate("www.google.com")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RIBrowsers.Stop()
    End Sub







End Class
