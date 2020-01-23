<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toolbox))
        Me.ConXamppbut = New System.Windows.Forms.Button()
        Me.Browserbut = New System.Windows.Forms.Button()
        Me.OpenXampp = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'ConXamppbut
        '
        Me.ConXamppbut.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConXamppbut.Location = New System.Drawing.Point(13, 13)
        Me.ConXamppbut.Name = "ConXamppbut"
        Me.ConXamppbut.Size = New System.Drawing.Size(140, 31)
        Me.ConXamppbut.TabIndex = 0
        Me.ConXamppbut.Text = "Connect Xampp"
        Me.ConXamppbut.UseVisualStyleBackColor = True
        '
        'Browserbut
        '
        Me.Browserbut.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browserbut.Location = New System.Drawing.Point(12, 60)
        Me.Browserbut.Name = "Browserbut"
        Me.Browserbut.Size = New System.Drawing.Size(140, 31)
        Me.Browserbut.TabIndex = 1
        Me.Browserbut.Text = "Browser"
        Me.Browserbut.UseVisualStyleBackColor = True
        '
        'OpenXampp
        '
        Me.OpenXampp.FileName = "OpenXampp"
        '
        'Toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(154, 96)
        Me.Controls.Add(Me.Browserbut)
        Me.Controls.Add(Me.ConXamppbut)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Toolbox"
        Me.Text = "Toolbox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConXamppbut As Button
    Friend WithEvents Browserbut As Button
    Friend WithEvents OpenXampp As OpenFileDialog
End Class
