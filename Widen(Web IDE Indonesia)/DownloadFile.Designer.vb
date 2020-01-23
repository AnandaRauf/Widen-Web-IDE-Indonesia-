<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DownloadFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadFile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.URLFileBox = New MetroFramework.Controls.MetroTextBox()
        Me.ProgressBarDownload = New MetroFramework.Controls.MetroProgressBar()
        Me.DownloadBut = New MetroFramework.Controls.MetroButton()
        Me.BackBut = New MetroFramework.Controls.MetroButton()
        Me.StatusDownload_LBL = New System.Windows.Forms.Label()
        Me.PathSaveFile_LBL = New System.Windows.Forms.Label()
        Me.CoPasteBut = New MetroFramework.Controls.MetroButton()
        Me.lbl_In = New System.Windows.Forms.Label()
        Me.BrowseFileBut = New MetroFramework.Controls.MetroButton()
        Me.PathFileBox = New MetroFramework.Controls.MetroTextBox()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File URL :"
        '
        'URLFileBox
        '
        Me.URLFileBox.Lines = New String(-1) {}
        Me.URLFileBox.Location = New System.Drawing.Point(127, 18)
        Me.URLFileBox.MaxLength = 32767
        Me.URLFileBox.Name = "URLFileBox"
        Me.URLFileBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.URLFileBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.URLFileBox.SelectedText = ""
        Me.URLFileBox.Size = New System.Drawing.Size(397, 23)
        Me.URLFileBox.TabIndex = 1
        Me.URLFileBox.UseSelectable = True
        '
        'ProgressBarDownload
        '
        Me.ProgressBarDownload.Location = New System.Drawing.Point(27, 75)
        Me.ProgressBarDownload.Name = "ProgressBarDownload"
        Me.ProgressBarDownload.Size = New System.Drawing.Size(497, 23)
        Me.ProgressBarDownload.TabIndex = 3
        '
        'DownloadBut
        '
        Me.DownloadBut.BackgroundImage = CType(resources.GetObject("DownloadBut.BackgroundImage"), System.Drawing.Image)
        Me.DownloadBut.Location = New System.Drawing.Point(27, 151)
        Me.DownloadBut.Name = "DownloadBut"
        Me.DownloadBut.Size = New System.Drawing.Size(49, 47)
        Me.DownloadBut.TabIndex = 4
        Me.DownloadBut.Theme = MetroFramework.MetroThemeStyle.Light
        Me.DownloadBut.UseSelectable = True
        '
        'BackBut
        '
        Me.BackBut.BackgroundImage = CType(resources.GetObject("BackBut.BackgroundImage"), System.Drawing.Image)
        Me.BackBut.Location = New System.Drawing.Point(475, 151)
        Me.BackBut.Name = "BackBut"
        Me.BackBut.Size = New System.Drawing.Size(49, 47)
        Me.BackBut.TabIndex = 6
        Me.BackBut.Theme = MetroFramework.MetroThemeStyle.Light
        Me.BackBut.UseSelectable = True
        '
        'StatusDownload_LBL
        '
        Me.StatusDownload_LBL.AutoSize = True
        Me.StatusDownload_LBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusDownload_LBL.Location = New System.Drawing.Point(204, 117)
        Me.StatusDownload_LBL.Name = "StatusDownload_LBL"
        Me.StatusDownload_LBL.Size = New System.Drawing.Size(180, 21)
        Me.StatusDownload_LBL.TabIndex = 8
        Me.StatusDownload_LBL.Text = "Status Download : %"
        '
        'PathSaveFile_LBL
        '
        Me.PathSaveFile_LBL.AutoSize = True
        Me.PathSaveFile_LBL.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PathSaveFile_LBL.Location = New System.Drawing.Point(23, 231)
        Me.PathSaveFile_LBL.Name = "PathSaveFile_LBL"
        Me.PathSaveFile_LBL.Size = New System.Drawing.Size(142, 21)
        Me.PathSaveFile_LBL.TabIndex = 10
        Me.PathSaveFile_LBL.Text = "Path File Save :"
        '
        'CoPasteBut
        '
        Me.CoPasteBut.BackgroundImage = CType(resources.GetObject("CoPasteBut.BackgroundImage"), System.Drawing.Image)
        Me.CoPasteBut.Location = New System.Drawing.Point(543, 12)
        Me.CoPasteBut.Name = "CoPasteBut"
        Me.CoPasteBut.Size = New System.Drawing.Size(49, 47)
        Me.CoPasteBut.TabIndex = 11
        Me.CoPasteBut.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CoPasteBut.UseSelectable = True
        '
        'lbl_In
        '
        Me.lbl_In.AutoSize = True
        Me.lbl_In.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_In.Location = New System.Drawing.Point(228, 51)
        Me.lbl_In.Name = "lbl_In"
        Me.lbl_In.Size = New System.Drawing.Size(28, 21)
        Me.lbl_In.TabIndex = 13
        Me.lbl_In.Text = "In"
        '
        'BrowseFileBut
        '
        Me.BrowseFileBut.BackgroundImage = CType(resources.GetObject("BrowseFileBut.BackgroundImage"), System.Drawing.Image)
        Me.BrowseFileBut.Location = New System.Drawing.Point(543, 75)
        Me.BrowseFileBut.Name = "BrowseFileBut"
        Me.BrowseFileBut.Size = New System.Drawing.Size(49, 47)
        Me.BrowseFileBut.TabIndex = 14
        Me.BrowseFileBut.Theme = MetroFramework.MetroThemeStyle.Light
        Me.BrowseFileBut.UseSelectable = True
        '
        'PathFileBox
        '
        Me.PathFileBox.Lines = New String(-1) {}
        Me.PathFileBox.Location = New System.Drawing.Point(171, 231)
        Me.PathFileBox.MaxLength = 32767
        Me.PathFileBox.Name = "PathFileBox"
        Me.PathFileBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PathFileBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PathFileBox.SelectedText = ""
        Me.PathFileBox.Size = New System.Drawing.Size(303, 23)
        Me.PathFileBox.TabIndex = 15
        Me.PathFileBox.UseSelectable = True
        '
        'DownloadFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(834, 261)
        Me.Controls.Add(Me.PathFileBox)
        Me.Controls.Add(Me.BrowseFileBut)
        Me.Controls.Add(Me.lbl_In)
        Me.Controls.Add(Me.CoPasteBut)
        Me.Controls.Add(Me.PathSaveFile_LBL)
        Me.Controls.Add(Me.StatusDownload_LBL)
        Me.Controls.Add(Me.BackBut)
        Me.Controls.Add(Me.DownloadBut)
        Me.Controls.Add(Me.ProgressBarDownload)
        Me.Controls.Add(Me.URLFileBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DownloadFile"
        Me.Text = "DownloadFile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents URLFileBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DownloadBut As MetroFramework.Controls.MetroButton
    Friend WithEvents ProgressBarDownload As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents BackBut As MetroFramework.Controls.MetroButton
    Friend WithEvents StatusDownload_LBL As Label
    Friend WithEvents PathSaveFile_LBL As Label
    Friend WithEvents CoPasteBut As MetroFramework.Controls.MetroButton
    Friend WithEvents lbl_In As Label
    Friend WithEvents BrowseFileBut As MetroFramework.Controls.MetroButton
    Friend WithEvents PathFileBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents SaveFileDialog As SaveFileDialog
End Class
