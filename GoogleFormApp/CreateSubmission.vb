Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmission
    Private stopwatch As Stopwatch
    Private stopwatchRunning As Boolean = False

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        stopwatch.Start()
        Timer1.Start() ' Start the timer to update the label
        stopwatchRunning = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatchRunning Then
            StopwatchLabel.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub StartPauseButton_Click(sender As Object, e As EventArgs) Handles StartPauseButton.Click
        If stopwatchRunning Then
            stopwatch.Stop()
            stopwatchRunning = False
            StartPauseButton.Text = "Resume"
        Else
            stopwatch.Start()
            stopwatchRunning = True
            StartPauseButton.Text = "Pause"
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim submission As New Dictionary(Of String, String) From {
            {"name", NameTextBox.Text},
            {"email", EmailTextBox.Text},
            {"phone", PhoneTextBox.Text},
            {"github_link", GitHubTextBox.Text},
            {"stopwatch_time", stopwatch.Elapsed.ToString("hh\:mm\:ss")}
        }
        SubmitToBackend(submission)
        ResetForm()
    End Sub

    Private Async Function SubmitToBackend(submission As Dictionary(Of String, String)) As Task
        Using client As New HttpClient()
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3002/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Submission failed.")
            End If
        End Using
    End Function

    Private Sub ResetForm()
        NameTextBox.Clear()
        EmailTextBox.Clear()
        PhoneTextBox.Clear()
        GitHubTextBox.Clear()
        stopwatch.Reset()
        stopwatchRunning = False
        StartPauseButton.Text = "Start"
        StopwatchLabel.Text = "00:00:00" ' Reset the label to 00:00:00
    End Sub
End Class
