Imports System.Net.Http
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String

        <JsonProperty("github_link")>
        Public Property GithubLink As String

        <JsonProperty("stopwatch_time")>
        Public Property StopwatchTime As String

        Public Sub New(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String)
            Me.Name = name
            Me.Email = email
            Me.Phone = phone
            Me.GithubLink = githubLink
            Me.StopwatchTime = stopwatchTime
        End Sub
    End Class

    ' List to hold submissions
    Private submissions As List(Of Submission)
    Private currentIndex As Integer
    Private originalEmail As String
    Private originalSubmissions As List(Of Submission)

    Private Const placeholderText As String = "Search by email"

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "View Submissions"
        Me.KeyPreview = True

        TxtSearchEmail.Text = placeholderText
        TxtSearchEmail.ForeColor = Color.Gray

        BtnSave.Enabled = False

        ' Fetch submissions from the backend
        Await FetchSubmissionsAsync()
    End Sub


    ' Constructor
    Public Sub New()

        InitializeComponent()

        ' Initialize submissions list
        Me.submissions = New List(Of Submission)()
        Me.Text = "View Submissions"
        currentIndex = 0
    End Sub

    ' Method to fetch submissions from the backend
    Private Async Function FetchSubmissionsAsync() As Task
        Dim apiUrl As String = "http://localhost:3000/read"
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Me.submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                    ' Initialize the backup list with the original submissions
                    Me.originalSubmissions = New List(Of Submission)(Me.submissions)

                    ' Display the first submission (if available)
                    If submissions.Count > 0 Then
                        DisplaySubmission(currentIndex)
                    End If
                Else
                    MessageBox.Show("Failed to fetch submissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    ' Method to display submission at specified index
    Private Sub DisplaySubmission(index As Integer)
        If index < 0 OrElse index >= submissions.Count Then
            Return
        End If

        Dim submission = submissions(index)
        TxtName.Text = submission.Name
        TxtEmail.Text = submission.Email
        TxtPhone.Text = submission.Phone
        TxtGithub.Text = submission.GithubLink
        TxtStopwatch.Text = submission.StopwatchTime

        ' Disable Save button after displaying a submission
        BtnSave.Enabled = False
    End Sub

    ' Event handler for Edit button click
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' Store the original email before editing
        originalEmail = TxtEmail.Text

        ' Enable editing of text fields
        TxtName.ReadOnly = False
        TxtEmail.ReadOnly = False
        TxtPhone.ReadOnly = False
        TxtGithub.ReadOnly = False
        TxtStopwatch.ReadOnly = False

        BtnSave.Enabled = True
    End Sub


    ' Event handler for Save button click (after editing)
    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' Get updated data from text fields
        Dim updatedName As String = TxtName.Text
        Dim updatedEmail As String = TxtEmail.Text
        Dim updatedPhone As String = TxtPhone.Text
        Dim updatedGithub As String = TxtGithub.Text
        Dim updatedStopwatch As String = TxtStopwatch.Text

        If Not IsValidEmail(updatedEmail) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate phone number
        If Not IsValidPhone(updatedPhone) Then
            MessageBox.Show("Please enter a valid phone number. Only numeric values, spaces, hyphens, and the '+' symbol are allowed.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Make PUT request to update backend
        Await UpdateSubmission(updatedName, updatedEmail, updatedPhone, updatedGithub, updatedStopwatch)

        ' Fetch updated submissions from backend after saving
        Await FetchSubmissionsAsync()

        ' Optionally, disable editing mode and reset UI
        TxtName.ReadOnly = True
        TxtEmail.ReadOnly = True
        TxtPhone.ReadOnly = True
        TxtGithub.ReadOnly = True
        TxtStopwatch.ReadOnly = True

        ' Disable Save button after saving
        BtnSave.Enabled = False
    End Sub



    ' Method to update submission via API
    Private Async Function UpdateSubmission(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task
        Dim apiUrl As String = $"http://localhost:3000/edit/{Uri.EscapeDataString(originalEmail)}"

        Try
            Using client As New HttpClient()
                Dim postData As String = $"{{""name"": ""{name}"", ""email"": ""{email}"", ""phone"": ""{phone}"", ""github_link"": ""{githubLink}"", ""stopwatch_time"": ""{stopwatchTime}""}}"
                Dim content As New StringContent(postData, System.Text.Encoding.UTF8, "application/json")

                Dim response = Await client.PutAsync(apiUrl, content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to update submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function



    Private Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Function IsValidPhone(phone As String) As Boolean
        Dim pattern As String = "^[\d\s-+]+$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(phone)
    End Function

    ' Event handler for Previous button click
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        ' Reset to original list if applicable
        If originalSubmissions IsNot Nothing AndAlso submissions.Count < originalSubmissions.Count Then
            submissions = New List(Of Submission)(originalSubmissions)
        End If

        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub


    ' Event handler for Next button click
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        ' Reset to original list if applicable
        If originalSubmissions IsNot Nothing AndAlso submissions.Count < originalSubmissions.Count Then
            submissions = New List(Of Submission)(originalSubmissions)
        End If

        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub



    ' Keyboard shortcut handling for Previous, Next, Edit, Save
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            BtnPrevious_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            BtnNext_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.F Then
            BtnSearch_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            BtnDelete_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            BtnEdit_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            BtnSave_Click(sender, e)
        End If
    End Sub

    ' Event handler for Search button click
    Private Async Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim email As String = TxtSearchEmail.Text.Trim()
        If email = placeholderText OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter an email to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim apiUrl As String = $"http://localhost:3000/search?email={Uri.EscapeDataString(email)}"
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim searchResults = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                    If searchResults.Count > 0 Then
                        submissions = searchResults
                        currentIndex = 0
                        DisplaySubmission(currentIndex)
                    Else
                        MessageBox.Show("No submissions found for the given email.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Failed to search submissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error searching submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for Delete button click
    Private Async Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim apiUrl As String = $"http://localhost:3000/delete?email={Uri.EscapeDataString(submissions(currentIndex).Email)}"
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.DeleteAsync(apiUrl)
                If response.IsSuccessStatusCode Then
                    submissions.RemoveAt(currentIndex)
                    If currentIndex > 0 Then currentIndex -= 1
                    If submissions.Count > 0 Then
                        DisplaySubmission(currentIndex)
                    Else
                        ClearSubmissionFields()
                    End If
                    MessageBox.Show("Submission deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to delete submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Methods to handle placeholder text
    Private Sub TxtSearchEmail_GotFocus(sender As Object, e As EventArgs) Handles TxtSearchEmail.GotFocus
        If TxtSearchEmail.Text = placeholderText Then
            TxtSearchEmail.Text = ""
            TxtSearchEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtSearchEmail_LostFocus(sender As Object, e As EventArgs) Handles TxtSearchEmail.LostFocus
        If String.IsNullOrWhiteSpace(TxtSearchEmail.Text) Then
            TxtSearchEmail.Text = placeholderText
            TxtSearchEmail.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ClearSubmissionFields()
        TxtName.Text = ""
        TxtEmail.Text = ""
        TxtPhone.Text = ""
        TxtGithub.Text = ""
        TxtStopwatch.Text = ""
    End Sub
End Class