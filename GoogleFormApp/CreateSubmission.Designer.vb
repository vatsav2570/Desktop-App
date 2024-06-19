<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmission
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
        components = New ComponentModel.Container()
        NameTextBox = New TextBox()
        EmailTextBox = New TextBox()
        PhoneTextBox = New TextBox()
        GitHubTextBox = New TextBox()
        StartPauseButton = New Button()
        SubmitButton = New Button()
        StopwatchLabel = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(401, 109)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(125, 27)
        NameTextBox.TabIndex = 0
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(401, 170)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(125, 27)
        EmailTextBox.TabIndex = 1
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Location = New Point(401, 225)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(125, 27)
        PhoneTextBox.TabIndex = 2
        ' 
        ' GitHubTextBox
        ' 
        GitHubTextBox.Location = New Point(401, 282)
        GitHubTextBox.Name = "GitHubTextBox"
        GitHubTextBox.Size = New Size(125, 27)
        GitHubTextBox.TabIndex = 3
        ' 
        ' StartPauseButton
        ' 
        StartPauseButton.Location = New Point(283, 331)
        StartPauseButton.Name = "StartPauseButton"
        StartPauseButton.Size = New Size(94, 29)
        StartPauseButton.TabIndex = 4
        StartPauseButton.Text = "Pause"
        StartPauseButton.UseVisualStyleBackColor = True
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(412, 397)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(94, 29)
        SubmitButton.TabIndex = 5
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' StopwatchLabel
        ' 
        StopwatchLabel.AutoSize = True
        StopwatchLabel.Location = New Point(430, 340)
        StopwatchLabel.Name = "StopwatchLabel"
        StopwatchLabel.Size = New Size(47, 20)
        StopwatchLabel.TabIndex = 6
        StopwatchLabel.Text = "TImer"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(283, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(283, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 8
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(283, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 9
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(283, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 10
        Label4.Text = "Github"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' CreateSubmission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(StopwatchLabel)
        Controls.Add(SubmitButton)
        Controls.Add(StartPauseButton)
        Controls.Add(GitHubTextBox)
        Controls.Add(PhoneTextBox)
        Controls.Add(EmailTextBox)
        Controls.Add(NameTextBox)
        Name = "CreateSubmission"
        Text = "CreateSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents GitHubTextBox As TextBox
    Friend WithEvents StartPauseButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents StopwatchLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer


End Class
