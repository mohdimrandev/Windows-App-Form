<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearchEmail = New System.Windows.Forms.TextBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.TxtStopwatch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblGitHub = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtGithub = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Lime
        Me.BtnSave.Location = New System.Drawing.Point(147, 330)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(149, 24)
        Me.BtnSave.TabIndex = 39
        Me.BtnSave.Text = "SAVE  (Ctrl + S)"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(33, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(377, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Mohammed Imran, Slidely Task 2 - View Submissions Form"
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Orange
        Me.BtnEdit.Location = New System.Drawing.Point(41, 300)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(149, 24)
        Me.BtnEdit.TabIndex = 37
        Me.BtnEdit.Text = "EDIT (Ctrl  + E)"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnSearch.Location = New System.Drawing.Point(280, 49)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(142, 24)
        Me.BtnSearch.TabIndex = 36
        Me.BtnSearch.Text = "SEARCH  (Ctrl + F)"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TxtSearchEmail
        '
        Me.TxtSearchEmail.Location = New System.Drawing.Point(52, 52)
        Me.TxtSearchEmail.Name = "TxtSearchEmail"
        Me.TxtSearchEmail.Size = New System.Drawing.Size(179, 20)
        Me.TxtSearchEmail.TabIndex = 35
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Location = New System.Drawing.Point(246, 300)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(149, 24)
        Me.BtnDelete.TabIndex = 34
        Me.BtnDelete.Text = "DELETE (Ctrl + D)"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'TxtStopwatch
        '
        Me.TxtStopwatch.Location = New System.Drawing.Point(201, 227)
        Me.TxtStopwatch.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtStopwatch.Name = "TxtStopwatch"
        Me.TxtStopwatch.ReadOnly = True
        Me.TxtStopwatch.Size = New System.Drawing.Size(200, 20)
        Me.TxtStopwatch.TabIndex = 33
        Me.TxtStopwatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(39, 228)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Stopwatch Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblGitHub
        '
        Me.LblGitHub.AutoSize = True
        Me.LblGitHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblGitHub.Location = New System.Drawing.Point(39, 189)
        Me.LblGitHub.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblGitHub.Name = "LblGitHub"
        Me.LblGitHub.Size = New System.Drawing.Size(152, 17)
        Me.LblGitHub.TabIndex = 31
        Me.LblGitHub.Text = "Github Link For Task 2"
        Me.LblGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblPhone.Location = New System.Drawing.Point(39, 149)
        Me.LblPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(82, 17)
        Me.LblPhone.TabIndex = 30
        Me.LblPhone.Text = "Phone Num"
        Me.LblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblEmail.Location = New System.Drawing.Point(39, 114)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(42, 17)
        Me.LblEmail.TabIndex = 29
        Me.LblEmail.Text = "Email"
        Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblName.Location = New System.Drawing.Point(39, 80)
        Me.LblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(45, 17)
        Me.LblName.TabIndex = 28
        Me.LblName.Text = "Name"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtGithub
        '
        Me.TxtGithub.Location = New System.Drawing.Point(201, 188)
        Me.TxtGithub.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtGithub.Name = "TxtGithub"
        Me.TxtGithub.ReadOnly = True
        Me.TxtGithub.Size = New System.Drawing.Size(200, 20)
        Me.TxtGithub.TabIndex = 27
        Me.TxtGithub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(201, 113)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(200, 20)
        Me.TxtEmail.TabIndex = 26
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(201, 148)
        Me.TxtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.ReadOnly = True
        Me.TxtPhone.Size = New System.Drawing.Size(200, 20)
        Me.TxtPhone.TabIndex = 25
        Me.TxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnNext.Location = New System.Drawing.Point(246, 262)
        Me.BtnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(149, 24)
        Me.BtnNext.TabIndex = 24
        Me.BtnNext.Text = "NEXT (Ctrl + N)"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(201, 80)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(200, 20)
        Me.TxtName.TabIndex = 23
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnPrevious.Location = New System.Drawing.Point(41, 262)
        Me.BtnPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(149, 24)
        Me.BtnPrevious.TabIndex = 22
        Me.BtnPrevious.Text = "PREVIOUS (Ctrl + P)"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 366)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearchEmail)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.TxtStopwatch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblGitHub)
        Me.Controls.Add(Me.LblPhone)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TxtGithub)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearchEmail As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents TxtStopwatch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblGitHub As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblName As Label
    Friend WithEvents TxtGithub As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents BtnNext As Button
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnPrevious As Button
End Class
