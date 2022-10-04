Public Class LaboratoryWork1
    Private Sub LaboratoryWork1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
        CheckBox2.Checked = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShowMessage.Click
        Dim Text As String

        Text = TextBox1.Text
        If Text = "" Then
            MsgBox("The input field is empty")
        Else
            MsgBox(Text)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub MessageOneButton_Click(sender As Object, e As EventArgs) Handles MessageOneButton.Click
        TextBox1.Text = "This is my defaul message"
    End Sub

    Private Sub MessageTwoButton_Click(sender As Object, e As EventArgs) Handles MessageTwoButton.Click
        TextBox1.Text = "This is another defaul message"
    End Sub

    Private Sub ExecuteButton_Click(sender As Object, e As EventArgs) Handles ExecuteButton.Click
        Dim Text As String

        'Get the text from combobox
        Text = ComboBox1.Text

        'Check chosen command
        If Text = "Clear field" Then
            TextBox1.Clear()
            ComboBox1.Text = ""

        ElseIf Text = "Copy text" Then
            'Set the text to a buffer
            If TextBox1.Text = "" Then
                MsgBox("Cannot execute this command because input field is empty", MessageBoxIcon.Error)
            Else
                My.Computer.Clipboard.SetText(TextBox1.Text)
            End If
            ComboBox1.Text = ""

        ElseIf Text = "Paste text" Then

            If My.Computer.Clipboard.ContainsText Then
                'If buffer contains text, then execute something
                TextBox1.Text = My.Computer.Clipboard.GetText()
            Else
                'If buffer contains something that is not a text - do not execute command
                MsgBox("Cannot execute this command because buffer does not contain text", MessageBoxIcon.Error)
            End If
            ComboBox1.Text = ""

        Else
            MsgBox("Cannot execute command. Choose command from the list", MessageBoxIcon.Error)
            ComboBox1.Text = ""

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Enabled = False
            MessageOneButton.Enabled = False
            MessageTwoButton.Enabled = False
            Label1.Enabled = False
            ShowMessage.Enabled = False
        Else
            TextBox1.Enabled = True
            MessageOneButton.Enabled = True
            MessageTwoButton.Enabled = True
            Label1.Enabled = True
            ShowMessage.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ComboBox1.Enabled = False
            Label2.Enabled = False
            ExecuteButton.Enabled = False
        Else
            ComboBox1.Enabled = True
            Label2.Enabled = True
            ExecuteButton.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Visible = True
            MessageOneButton.Visible = True
            MessageTwoButton.Visible = True
            Label1.Visible = True
            ShowMessage.Visible = True
        Else
            TextBox1.Hide()
            MessageOneButton.Hide()
            MessageTwoButton.Hide()
            Label1.Hide()
            ShowMessage.Hide()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ComboBox1.Visible = True
            Label2.Visible = True
            ExecuteButton.Visible = True
        Else
            ComboBox1.Hide()
            Label2.Hide()
            ExecuteButton.Hide()
        End If
    End Sub
End Class
