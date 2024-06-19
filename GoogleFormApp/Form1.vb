Public Class Form1
    Private Sub ViewSubmissionsButton_Click(sender As Object, e As EventArgs) Handles ViewSubmissionsButton.Click
        Dim viewForm As New ViewSubmissionform()
        viewForm.ShowDialog()
    End Sub

    Private Sub CreateSubmissionButton_Click(sender As Object, e As EventArgs) Handles CreateSubmissionButton.Click
        Dim createForm As New CreateSubmission()
        createForm.ShowDialog()
    End Sub
End Class
