<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionform
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
        PreviousButton = New Button()
        NextButton = New Button()
        SubmissionTextBox = New TextBox()
        DeleteButton = New Button()
        SearchButton = New Button()
        EmailSearchTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' PreviousButton
        ' 
        PreviousButton.Location = New Point(97, 191)
        PreviousButton.Name = "PreviousButton"
        PreviousButton.Size = New Size(94, 29)
        PreviousButton.TabIndex = 0
        PreviousButton.Text = "Previous"
        PreviousButton.UseVisualStyleBackColor = True
        ' 
        ' NextButton
        ' 
        NextButton.Location = New Point(624, 191)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(94, 29)
        NextButton.TabIndex = 2
        NextButton.Text = "Next"
        NextButton.UseVisualStyleBackColor = True
        ' 
        ' SubmissionTextBox
        ' 
        SubmissionTextBox.Location = New Point(258, 102)
        SubmissionTextBox.Multiline = True
        SubmissionTextBox.Name = "SubmissionTextBox"
        SubmissionTextBox.ReadOnly = True
        SubmissionTextBox.Size = New Size(289, 211)
        SubmissionTextBox.TabIndex = 3
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(347, 382)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(94, 29)
        DeleteButton.TabIndex = 4
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' SearchButton
        ' 
        SearchButton.Location = New Point(163, 34)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(94, 29)
        SearchButton.TabIndex = 5
        SearchButton.Text = "Search"
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' EmailSearchTextBox
        ' 
        EmailSearchTextBox.Location = New Point(289, 36)
        EmailSearchTextBox.Name = "EmailSearchTextBox"
        EmailSearchTextBox.Size = New Size(258, 27)
        EmailSearchTextBox.TabIndex = 6
        ' 
        ' ViewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(EmailSearchTextBox)
        Controls.Add(SearchButton)
        Controls.Add(DeleteButton)
        Controls.Add(SubmissionTextBox)
        Controls.Add(NextButton)
        Controls.Add(PreviousButton)
        Name = "ViewSubmissionForm"
        Text = "ViewSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents SubmissionTextBox As TextBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents EmailSearchTextBox As TextBox
End Class
