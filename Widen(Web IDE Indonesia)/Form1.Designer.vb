<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadingBar = New System.Windows.Forms.ProgressBar()
        Me.Status_loadingLBL = New System.Windows.Forms.Label()
        Me.Percent_loadingLBL = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 310)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoadingBar
        '
        Me.LoadingBar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LoadingBar.Location = New System.Drawing.Point(13, 331)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(490, 23)
        Me.LoadingBar.TabIndex = 1
        '
        'Status_loadingLBL
        '
        Me.Status_loadingLBL.AutoSize = True
        Me.Status_loadingLBL.Location = New System.Drawing.Point(12, 357)
        Me.Status_loadingLBL.Name = "Status_loadingLBL"
        Me.Status_loadingLBL.Size = New System.Drawing.Size(97, 20)
        Me.Status_loadingLBL.TabIndex = 2
        Me.Status_loadingLBL.Text = "Status Loading"
        '
        'Percent_loadingLBL
        '
        Me.Percent_loadingLBL.AutoSize = True
        Me.Percent_loadingLBL.Location = New System.Drawing.Point(509, 334)
        Me.Percent_loadingLBL.Name = "Percent_loadingLBL"
        Me.Percent_loadingLBL.Size = New System.Drawing.Size(21, 20)
        Me.Percent_loadingLBL.TabIndex = 3
        Me.Percent_loadingLBL.Text = "%"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 381)
        Me.Controls.Add(Me.Percent_loadingLBL)
        Me.Controls.Add(Me.Status_loadingLBL)
        Me.Controls.Add(Me.LoadingBar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Loading"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadingBar As ProgressBar
    Friend WithEvents Status_loadingLBL As Label
    Friend WithEvents Percent_loadingLBL As Label
    Friend WithEvents Timer1 As Timer
End Class
