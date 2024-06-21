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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(54, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mohammed Imran, Slidely Task 2 - Slidely Form App"
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnCreate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCreate.Location = New System.Drawing.Point(108, 227)
        Me.BtnCreate.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(224, 24)
        Me.BtnCreate.TabIndex = 4
        Me.BtnCreate.Text = "CREATE NEW SUBMISSION (Ctrl + N)"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'BtnView
        '
        Me.BtnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnView.Location = New System.Drawing.Point(108, 163)
        Me.BtnView.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(224, 24)
        Me.BtnView.TabIndex = 3
        Me.BtnView.Text = "VIEW SUBMISSIONS (Ctrl + V)"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 366)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnView As Button
End Class
