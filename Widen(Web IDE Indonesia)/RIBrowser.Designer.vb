<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RIBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RIBrowser))
        Me.RIBrowsers = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdsOnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VPNModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutAppsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StreamingFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RieeNetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SamehadakuTvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrunchyrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnibatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConanIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Film21XX1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lk21ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndoXX1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.URLBox = New System.Windows.Forms.TextBox()
        Me.AddTabButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddTab = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.AddTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'RIBrowsers
        '
        Me.RIBrowsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RIBrowsers.Location = New System.Drawing.Point(3, 57)
        Me.RIBrowsers.MinimumSize = New System.Drawing.Size(20, 20)
        Me.RIBrowsers.Name = "RIBrowsers"
        Me.RIBrowsers.Size = New System.Drawing.Size(1164, 455)
        Me.RIBrowsers.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuBrowserToolStripMenuItem, Me.DownloadAppsToolStripMenuItem, Me.AboutAppsToolStripMenuItem1, Me.HomeToolStripMenuItem, Me.StreamingFilmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1166, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuBrowser"
        '
        'MenuBrowserToolStripMenuItem
        '
        Me.MenuBrowserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdsOnsToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.VPNModeToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MenuBrowserToolStripMenuItem.Image = CType(resources.GetObject("MenuBrowserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuBrowserToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.MenuBrowserToolStripMenuItem.Name = "MenuBrowserToolStripMenuItem"
        Me.MenuBrowserToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'AdsOnsToolStripMenuItem
        '
        Me.AdsOnsToolStripMenuItem.Image = CType(resources.GetObject("AdsOnsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdsOnsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.AdsOnsToolStripMenuItem.Name = "AdsOnsToolStripMenuItem"
        Me.AdsOnsToolStripMenuItem.ShortcutKeyDisplayString = "(Comingsoon)"
        Me.AdsOnsToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AdsOnsToolStripMenuItem.Text = "Add-ons"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Image = CType(resources.GetObject("HistoryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HistoryToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.ShortcutKeyDisplayString = "(Comingsoon)"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'VPNModeToolStripMenuItem
        '
        Me.VPNModeToolStripMenuItem.Image = CType(resources.GetObject("VPNModeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VPNModeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.VPNModeToolStripMenuItem.Name = "VPNModeToolStripMenuItem"
        Me.VPNModeToolStripMenuItem.ShortcutKeyDisplayString = "(Comingsoon)"
        Me.VPNModeToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.VPNModeToolStripMenuItem.Text = "VPN Mode"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = CType(resources.GetObject("QuitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'DownloadAppsToolStripMenuItem
        '
        Me.DownloadAppsToolStripMenuItem.Image = CType(resources.GetObject("DownloadAppsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadAppsToolStripMenuItem.Name = "DownloadAppsToolStripMenuItem"
        Me.DownloadAppsToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'AboutAppsToolStripMenuItem1
        '
        Me.AboutAppsToolStripMenuItem1.Image = CType(resources.GetObject("AboutAppsToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AboutAppsToolStripMenuItem1.Name = "AboutAppsToolStripMenuItem1"
        Me.AboutAppsToolStripMenuItem1.Size = New System.Drawing.Size(28, 20)
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'StreamingFilmToolStripMenuItem
        '
        Me.StreamingFilmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimeToolStripMenuItem, Me.Film21XX1ToolStripMenuItem})
        Me.StreamingFilmToolStripMenuItem.Image = CType(resources.GetObject("StreamingFilmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StreamingFilmToolStripMenuItem.Name = "StreamingFilmToolStripMenuItem"
        Me.StreamingFilmToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'AnimeToolStripMenuItem
        '
        Me.AnimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RieeNetToolStripMenuItem, Me.SamehadakuTvToolStripMenuItem, Me.CrunchyrollToolStripMenuItem, Me.AnibatchToolStripMenuItem, Me.ConanIDToolStripMenuItem})
        Me.AnimeToolStripMenuItem.Name = "AnimeToolStripMenuItem"
        Me.AnimeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AnimeToolStripMenuItem.Text = "Anime"
        '
        'RieeNetToolStripMenuItem
        '
        Me.RieeNetToolStripMenuItem.Image = CType(resources.GetObject("RieeNetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RieeNetToolStripMenuItem.Name = "RieeNetToolStripMenuItem"
        Me.RieeNetToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.RieeNetToolStripMenuItem.Text = "Riee Net"
        '
        'SamehadakuTvToolStripMenuItem
        '
        Me.SamehadakuTvToolStripMenuItem.Image = CType(resources.GetObject("SamehadakuTvToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SamehadakuTvToolStripMenuItem.Name = "SamehadakuTvToolStripMenuItem"
        Me.SamehadakuTvToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SamehadakuTvToolStripMenuItem.Text = "Samehadaku Tv"
        '
        'CrunchyrollToolStripMenuItem
        '
        Me.CrunchyrollToolStripMenuItem.Image = CType(resources.GetObject("CrunchyrollToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CrunchyrollToolStripMenuItem.Name = "CrunchyrollToolStripMenuItem"
        Me.CrunchyrollToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CrunchyrollToolStripMenuItem.Text = "Crunchyroll"
        '
        'AnibatchToolStripMenuItem
        '
        Me.AnibatchToolStripMenuItem.Image = CType(resources.GetObject("AnibatchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AnibatchToolStripMenuItem.Name = "AnibatchToolStripMenuItem"
        Me.AnibatchToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AnibatchToolStripMenuItem.Text = "Anibatch"
        '
        'ConanIDToolStripMenuItem
        '
        Me.ConanIDToolStripMenuItem.Image = CType(resources.GetObject("ConanIDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConanIDToolStripMenuItem.Name = "ConanIDToolStripMenuItem"
        Me.ConanIDToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ConanIDToolStripMenuItem.Text = "Conan ID"
        '
        'Film21XX1ToolStripMenuItem
        '
        Me.Film21XX1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lk21ToolStripMenuItem, Me.IndoXX1ToolStripMenuItem})
        Me.Film21XX1ToolStripMenuItem.Name = "Film21XX1ToolStripMenuItem"
        Me.Film21XX1ToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.Film21XX1ToolStripMenuItem.Text = "Film 21 / XX1"
        '
        'Lk21ToolStripMenuItem
        '
        Me.Lk21ToolStripMenuItem.Image = CType(resources.GetObject("Lk21ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Lk21ToolStripMenuItem.Name = "Lk21ToolStripMenuItem"
        Me.Lk21ToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.Lk21ToolStripMenuItem.Text = "Lk21"
        '
        'IndoXX1ToolStripMenuItem
        '
        Me.IndoXX1ToolStripMenuItem.Image = CType(resources.GetObject("IndoXX1ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndoXX1ToolStripMenuItem.Name = "IndoXX1ToolStripMenuItem"
        Me.IndoXX1ToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.IndoXX1ToolStripMenuItem.Text = "IndoXX1"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.Location = New System.Drawing.Point(3, 28)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 2
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ForwardButton
        '
        Me.ForwardButton.BackColor = System.Drawing.Color.Transparent
        Me.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForwardButton.Image = CType(resources.GetObject("ForwardButton.Image"), System.Drawing.Image)
        Me.ForwardButton.Location = New System.Drawing.Point(75, 28)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(75, 23)
        Me.ForwardButton.TabIndex = 3
        Me.ForwardButton.UseVisualStyleBackColor = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.Transparent
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.Location = New System.Drawing.Point(146, 28)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 4
        Me.RefreshButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.Transparent
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Image = CType(resources.GetObject("SearchButton.Image"), System.Drawing.Image)
        Me.SearchButton.Location = New System.Drawing.Point(819, 27)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(43, 22)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'URLBox
        '
        Me.URLBox.Font = New System.Drawing.Font("Segoe Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URLBox.Location = New System.Drawing.Point(240, 28)
        Me.URLBox.Name = "URLBox"
        Me.URLBox.Size = New System.Drawing.Size(583, 23)
        Me.URLBox.TabIndex = 7
        '
        'AddTabButton
        '
        Me.AddTabButton.BackColor = System.Drawing.Color.Transparent
        Me.AddTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTabButton.Image = CType(resources.GetObject("AddTabButton.Image"), System.Drawing.Image)
        Me.AddTabButton.Location = New System.Drawing.Point(854, 27)
        Me.AddTabButton.Name = "AddTabButton"
        Me.AddTabButton.Size = New System.Drawing.Size(43, 22)
        Me.AddTabButton.TabIndex = 8
        Me.AddTabButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(205, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AddTab
        '
        Me.AddTab.Controls.Add(Me.TabPage2)
        Me.AddTab.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AddTab.Location = New System.Drawing.Point(894, 26)
        Me.AddTab.Name = "AddTab"
        Me.AddTab.SelectedIndex = 0
        Me.AddTab.Size = New System.Drawing.Size(67, 23)
        Me.AddTab.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(59, 0)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Page"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RIBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 514)
        Me.Controls.Add(Me.AddTab)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AddTabButton)
        Me.Controls.Add(Me.URLBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.RIBrowsers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RIBrowser"
        Me.Text = "Republik Indonesia Browser"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.AddTab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RIBrowsers As WebBrowser
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdsOnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VPNModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadAppsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutAppsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BackButton As Button
    Friend WithEvents ForwardButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents URLBox As TextBox
    Friend WithEvents AddTabButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AddTab As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StreamingFilmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RieeNetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SamehadakuTvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrunchyrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Film21XX1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnibatchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConanIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lk21ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndoXX1ToolStripMenuItem As ToolStripMenuItem
End Class
