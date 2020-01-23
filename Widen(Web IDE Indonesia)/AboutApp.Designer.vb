<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutApp))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblUrl1 = New System.Windows.Forms.LinkLabel()
        Me.lblUrl2 = New System.Windows.Forms.LinkLabel()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.imgDonate = New System.Windows.Forms.PictureBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.tableLayoutPanel4.SuspendLayout()
        CType(Me.imgDonate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.pnlHeader, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(536, 41)
        Me.tableLayoutPanel1.TabIndex = 11
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(530, 35)
        Me.pnlHeader.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(3, 7)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(51, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "About"
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 1
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.pnlFooter, 0, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 335)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(536, 41)
        Me.tableLayoutPanel2.TabIndex = 12
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFooter.Controls.Add(Me.btnOk)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFooter.Location = New System.Drawing.Point(3, 3)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(530, 35)
        Me.pnlFooter.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(227, 6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 1
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Controls.Add(Me.pictureBox1, 0, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.lblVersion, 0, 1)
        Me.tableLayoutPanel3.Controls.Add(Me.lblCopyright, 0, 2)
        Me.tableLayoutPanel3.Controls.Add(Me.lblUrl1, 0, 4)
        Me.tableLayoutPanel3.Controls.Add(Me.lblUrl2, 0, 5)
        Me.tableLayoutPanel3.Controls.Add(Me.groupBox1, 0, 6)
        Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 7
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(536, 376)
        Me.tableLayoutPanel3.TabIndex = 13
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(530, 107)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Location = New System.Drawing.Point(3, 113)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(530, 20)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "lblVersion"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCopyright.Location = New System.Drawing.Point(3, 133)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(530, 20)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "lblCopyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUrl1
        '
        Me.lblUrl1.AutoSize = True
        Me.lblUrl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUrl1.Location = New System.Drawing.Point(3, 173)
        Me.lblUrl1.Name = "lblUrl1"
        Me.lblUrl1.Size = New System.Drawing.Size(530, 20)
        Me.lblUrl1.TabIndex = 2
        Me.lblUrl1.TabStop = True
        Me.lblUrl1.Text = "lblUrl1"
        Me.lblUrl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUrl2
        '
        Me.lblUrl2.AutoSize = True
        Me.lblUrl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUrl2.Location = New System.Drawing.Point(3, 193)
        Me.lblUrl2.Name = "lblUrl2"
        Me.lblUrl2.Size = New System.Drawing.Size(530, 20)
        Me.lblUrl2.TabIndex = 2
        Me.lblUrl2.TabStop = True
        Me.lblUrl2.Text = "lblUrl2"
        Me.lblUrl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.tableLayoutPanel4)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(3, 216)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(530, 157)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        '
        'tableLayoutPanel4
        '
        Me.tableLayoutPanel4.ColumnCount = 2
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.05344!))
        Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.94657!))
        Me.tableLayoutPanel4.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel4.Controls.Add(Me.imgDonate, 1, 0)
        Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
        Me.tableLayoutPanel4.RowCount = 1
        Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel4.Size = New System.Drawing.Size(524, 138)
        Me.tableLayoutPanel4.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(400, 48)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Tech Source Code Store ialah toko jual beli full source code aplikasi web,pc,dan " &
    "android untuk dikembangkan kembali menjadi kreatif dan inovatif. Owner/Founder :" &
    " Ananda Rauf Maududi."
        '
        'imgDonate
        '
        Me.imgDonate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgDonate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgDonate.Image = CType(resources.GetObject("imgDonate.Image"), System.Drawing.Image)
        Me.imgDonate.Location = New System.Drawing.Point(411, 3)
        Me.imgDonate.Name = "imgDonate"
        Me.imgDonate.Size = New System.Drawing.Size(110, 132)
        Me.imgDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDonate.TabIndex = 1
        Me.imgDonate.TabStop = False
        '
        'AboutApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(536, 376)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.tableLayoutPanel2)
        Me.Controls.Add(Me.tableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutApp"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.tableLayoutPanel3.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.tableLayoutPanel4.ResumeLayout(False)
        Me.tableLayoutPanel4.PerformLayout()
        CType(Me.imgDonate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents pnlHeader As Panel
    Private WithEvents lblHeader As Label
    Private WithEvents tableLayoutPanel2 As TableLayoutPanel
    Private WithEvents pnlFooter As Panel
    Private WithEvents btnOk As Button
    Private WithEvents tableLayoutPanel3 As TableLayoutPanel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lblVersion As Label
    Private WithEvents lblCopyright As Label
    Private WithEvents lblUrl1 As LinkLabel
    Private WithEvents lblUrl2 As LinkLabel
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents tableLayoutPanel4 As TableLayoutPanel
    Private WithEvents label1 As Label
    Private WithEvents imgDonate As PictureBox
End Class
