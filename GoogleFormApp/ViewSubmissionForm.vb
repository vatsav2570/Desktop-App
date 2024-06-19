Imports System.Net
Imports Newtonsoft.Json

Public Class ViewSubmissionForm
    Private submissions As List(Of Dictionary(Of String, String))
    Private currentIndex As Integer

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submissions = LoadSubmissions()
        currentIndex = 0
        DisplaySubmission()
    End Sub

    Private Function LoadSubmissions() As List(Of Dictionary(Of String, String))
        Try
            Using client As New WebClient()
                Dim allSubmissions As New List(Of Dictionary(Of String, String))
                Dim index As Integer = 0
                Dim response As String = client.DownloadString($"http://localhost:3001/read?index={index}")
                While Not String.IsNullOrEmpty(response)
                    Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(response)
                    If submission IsNot Nothing Then
                        allSubmissions.Add(submission)
                    End If
                    index += 1
                    response = client.DownloadString($"http://localhost:3001/read?index={index}")
                End While
                Return allSubmissions
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}")
            Return New List(Of Dictionary(Of String, String))
        End Try
    End Function

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(currentIndex)
            SubmissionTextBox.Text = $"Name: {submission("name")}{Environment.NewLine}" &
                                     $"Email: {submission("email")}{Environment.NewLine}" &
                                     $"Phone: {submission("phone")}{Environment.NewLine}" &
                                     $"GitHub: {submission("github_link")}{Environment.NewLine}" &
                                     $"Time: {submission("stopwatch_time")}"
        Else
            SubmissionTextBox.Text = "No submissions found."
        End If
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim response = MessageBox.Show("Are you sure you want to delete this submission?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then
                Dim submission = submissions(currentIndex)
                Dim name As String = submission("name")
                DeleteSubmission(name)
            End If
        End If
    End Sub

    Private Sub DeleteSubmission(name As String)
        Try
            Using client As New WebClient()
                Dim response As String = client.UploadString($"http://localhost:3002/delete/{name}", "DELETE", "")
                MessageBox.Show(response, "Deletion Status")
                ' Remove the deleted submission from the list
                submissions.RemoveAt(currentIndex)
                ' Display the next submission if available
                If currentIndex < submissions.Count Then
                    DisplaySubmission()
                Else
                    SubmissionTextBox.Text = "No submissions found."
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting submission: {ex.Message}")
        End Try
    End Sub




    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim searchEmail As String = EmailSearchTextBox.Text
        If Not String.IsNullOrEmpty(searchEmail) Then
            Dim foundSubmission = submissions.FirstOrDefault(Function(submission) submission("email") = searchEmail)
            If foundSubmission IsNot Nothing Then
                Dim index = submissions.IndexOf(foundSubmission)
                currentIndex = index
                DisplaySubmission()
            Else
                MessageBox.Show("No submission found with the provided email.", "Search Result")
            End If
        Else
            MessageBox.Show("Please enter an email for search.", "Search Error")
        End If
    End Sub

End Class
