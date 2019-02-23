Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class MainProject
    ''' <summary>
    ''' 파일 확장자. (.txt)
    ''' </summary>
    Public FileExt As String
    Dim IsSaved As Boolean

    Private Sub MainProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerText.Text = "     Version. " & My.Application.Info.Version.ToString
        IsSaved = True
    End Sub
    ''' <summary>
    ''' String의 수를 세줍니다. 결과는 Integer.
    ''' </summary>
    Public Function Cntstr(ByVal inputString As String, ByVal pattern As String) As Integer
        Return Regex.Split(inputString, pattern).Length - 1
    End Function

    Private Sub TrimButtons_CheckedChanged(sender As Object, e As EventArgs) Handles LTrimButton.CheckedChanged, RTrimButton.CheckedChanged, TrimButton.CheckedChanged
        If LTrimButton.Checked Then
            NTextBox.Text = NTextBox.Text.TrimStart()
        ElseIf RTrimButton.Checked Then
            NTextBox.Text = NTextBox.Text.TrimEnd()
        ElseIf TrimButton.Checked Then
            NTextBox.Text = NTextBox.Text.Trim()
        End If

        IsSaved = False
    End Sub

    Private Sub FNRButton_Click(sender As Object, e As EventArgs) Handles FNRButton.Click
        If Not FindTextBox.Text = Nothing Then
            If Not FindTextBox.Text = "" Then
                If RepTextBox.Text = Nothing Then
                    RepTextBox.Text = ""
                End If

                Dim Fndint As Integer
                Fndint = Cntstr(NTextBox.Text, FindTextBox.Text)
                NTextBox.Text = NTextBox.Text.Replace(FindTextBox.Text, RepTextBox.Text)

                If Fndint < 0 Or Fndint = 0 Then
                    MessageBox.Show("Nothing Replaced!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If Fndint = 1 Then
                        MessageBox.Show(Fndint & " occurrence Replaced!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ElseIf Fndint > 1 Then
                        MessageBox.Show(Fndint & " occurrences Replaced!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

                IsSaved = False

            End If
        End If
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Clipboard.SetText(NTextBox.Text)
        MessageBox.Show("Text Copied!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OpenTextButton_Click(sender As Object, e As EventArgs) Handles OpenTextButton.Click
        ofd_path.Title = "Open Your Text File"
        If ofd_path.ShowDialog() = DialogResult.OK Then
            FileExt = Path.GetExtension(ofd_path.FileName)
            NTextBox.Text = File.ReadAllText(ofd_path.FileName)
            MessageBox.Show("Opened the Selected Text File!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            IsSaved = True
        End If
    End Sub

    Private Sub SaveTextButton_Click(sender As Object, e As EventArgs) Handles SaveTextButton.Click
        SaveText2File(True)
    End Sub

    Private Sub NTextBox_TextChanged(sender As Object, e As EventArgs) Handles NTextBox.TextChanged
        If IsSaved = True Then IsSaved = False
    End Sub

    Private Sub MainProject_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsSaved = False Then
            Dim result As DialogResult = MessageBox.Show("You didn't save your Text. Would you like to save your Text?", "Find N Replace: Not Saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SaveText2File(False)
            ElseIf result = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub SaveText2File(WaitDelay As Boolean)
        If FileExt = Nothing Then
            sfd_path.DefaultExt = ".txt"
            sfd_path.Filter = "All Files|*.*"
        Else
            sfd_path.DefaultExt = FileExt
            sfd_path.Filter = FileExt.Replace(".", "").ToUpper & " File|*" & FileExt
        End If

        sfd_path.Title = "Save Your Text File"
        If sfd_path.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd_path.FileName, NTextBox.Text)
            If WaitDelay = True Then
                IsSaved = True
                MessageBox.Show("Text File Saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class