Imports System.Text.RegularExpressions
Imports System.Net.Http

Public Class CreateSubmissionForm

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GithubLink As String
        Public Property StopwatchTime As String

        Public Sub New(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String)
            Me.Name = name
            Me.Email = email
            Me.Phone = phone
            Me.GithubLink = githubLink
            Me.StopwatchTime = stopwatchTime
        End Sub
    End Class

    Private stopwatch As New System.Diagnostics.Stopwatch()
    Private WithEvents TimerUpdate As New Timer()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Create New Submission"
        Me.KeyPreview = True
        TxtStopwatch.Text = "00:00:00"
    End Sub

    ' Submit button click event
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim name As String = TxtName.Text.Trim()
        Dim email As String = TxtEmail.Text.Trim()
        Dim phone As String = TxtPhone.Text.Trim()
        Dim githubLink As String = TxtGithub.Text.Trim()

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidPhone(phone) Then
            MessageBox.Show("Please enter a valid phone number. Only numeric values are allowed.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Call API to submit data
        CallSubmitAPI(name, email, phone, githubLink)
    End Sub

    ' Validate email format
    Private Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    ' Validate phone number format
    Private Function IsValidPhone(phone As String) As Boolean
        Dim pattern As String = "^[\d\s-+]+$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(phone)
    End Function

    ' Call API to submit data
    Private Sub CallSubmitAPI(name As String, email As String, phone As String, githubLink As String)
        Dim apiUrl As String = "http://localhost:3000/submit"

        Try
            If stopwatch.IsRunning Then
                stopwatch.Stop()
            End If

            Dim stopwatchTime As String = stopwatch.Elapsed.ToString("hh\:mm\:ss")

            ' Prepare HTTP request
            Using client As New HttpClient()
                Dim postData As String = $"{{""name"": ""{name}"", ""email"": ""{email}"", ""phone"": ""{phone}"", ""github_link"": ""{githubLink}"", ""stopwatch_time"": ""{stopwatchTime}""}}"
                Dim content As New StringContent(postData, System.Text.Encoding.UTF8, "application/json")

                ' Send POST request to API
                Dim response = client.PostAsync(apiUrl, content).Result

                ' Show appropriate message based on response
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Submission failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Handle keyboard shortcuts
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check for Ctrl + S shortcut to submit
        If e.Control AndAlso e.KeyCode = Keys.S Then
            BtnSubmit_Click(sender, e)
        End If

        ' Check for Ctrl + T shortcut to toggle stopwatch
        If e.Control AndAlso e.KeyCode = Keys.T Then
            BtnToggleStopwatch_Click(sender, e)
        End If
    End Sub

    ' Handle stopwatch toggle button click
    Private Sub BtnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles BtnToggleStopwatch.Click
        If Not stopwatch.IsRunning Then
            stopwatch.Start()
            TimerUpdate.Start()
        Else
            stopwatch.Stop()
            TimerUpdate.Stop()
        End If
    End Sub

    ' Update stopwatch display periodically
    Private Sub TimerUpdate_Tick(sender As Object, e As EventArgs) Handles TimerUpdate.Tick
        Dim elapsed = stopwatch.Elapsed
        TxtStopwatch.Text = $"{elapsed.Hours:00}:{elapsed.Minutes:00}:{elapsed.Seconds:00}"
    End Sub

    Private Sub CreateSubmissionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            TimerUpdate.Stop()
        End If
    End Sub
End Class
