Public Class Form1
    ' Event handler for View Submissions button click
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Slidely Form App"
        Me.KeyPreview = True
    End Sub
    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    ' Event handler for Create New Submission button click
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.Show()
    End Sub

    ' Event handler for KeyDown event (for keyboard shortcuts)
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            BtnView_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            BtnCreate_Click(sender, e)
        End If
    End Sub
End Class
