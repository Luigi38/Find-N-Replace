Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class MainProject
    ''' <summary>
    ''' 파일 확장자. (.txt)
    ''' </summary>
    Public FileExt As String
    Dim IsSaved As Boolean
    Dim UseNTextBox As Boolean

    Private Sub MainProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerText.Text = "     Version. " & My.Application.Info.Version.ToString
        IsSaved = True

        UseNTextBox = True
        NTextBox2.Visible = False
    End Sub
    ''' <summary>
    ''' String의 수를 세줍니다. 결과는 Integer.
    ''' </summary>
    Public Function Cntstr(ByVal inputString As String, ByVal pattern As String) As Integer
        Return Regex.Split(inputString, pattern).Length - 1
    End Function

    Private Sub TrimButtons_CheckedChanged(sender As Object, e As EventArgs) Handles LTrimButton.CheckedChanged, RTrimButton.CheckedChanged, TrimButton.CheckedChanged
        If LTrimButton.Checked Then

            If UseNTextBox = True Then
                NTextBox1.Text = NTextBox1.Text.TrimStart()
            ElseIf UseNTextBox = False Then
                NTextBox2.Text = NTextBox2.Text.TrimStart()
            End If

        ElseIf RTrimButton.Checked Then

            If UseNTextBox = True Then
                NTextBox1.Text = NTextBox1.Text.TrimEnd()
            ElseIf UseNTextBox = False Then
                NTextBox2.Text = NTextBox2.Text.TrimEnd()
            End If

        ElseIf TrimButton.Checked Then

            If UseNTextBox = True Then
                NTextBox1.Text = NTextBox1.Text.Trim()
            ElseIf UseNTextBox = True Then
                NTextBox2.Text = NTextBox2.Text.Trim()
            End If

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
                If UseNTextBox = True Then
                    Fndint = Cntstr(NTextBox1.Text, FindTextBox.Text)
                    NTextBox1.Text = NTextBox1.Text.Replace(FindTextBox.Text, RepTextBox.Text)
                ElseIf UseNTextBox = False Then
                    Fndint = Cntstr(NTextBox2.Text, FindTextBox.Text)
                    NTextBox2.Text = NTextBox2.Text.Replace(FindTextBox.Text, RepTextBox.Text)
                End If

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
        If UseNTextBox = True Then
            Clipboard.SetText(NTextBox1.Text)
        ElseIf UseNTextBox = False Then
            Clipboard.SetText(NTextBox2.Text)
        End If
        MessageBox.Show("Text Copied!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OpenTextButton_Click(sender As Object, e As EventArgs) Handles OpenTextButton.Click
        ofd_path.Title = "Open Your Text File"
        If ofd_path.ShowDialog() = DialogResult.OK Then
            FileExt = Path.GetExtension(ofd_path.FileName)
            If UseNTextBox = True Then
                NTextBox1.Text = File.ReadAllText(ofd_path.FileName)
            ElseIf UseNTextBox = False Then
                NTextBox2.Text = File.ReadAllText(ofd_path.FileName)
            End If
            MessageBox.Show("Opened the Selected Text File!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                IsSaved = True
            End If
    End Sub

    Private Sub SaveTextButton_Click(sender As Object, e As EventArgs) Handles SaveTextButton.Click
        SaveText2File(True)
    End Sub

    Private Sub NTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NTextBox1.TextChanged
        If IsSaved = True Then IsSaved = False
    End Sub

    Private Sub NTextBox2_TextChanged(sender As Object, e As EventArgs) Handles NTextBox2.TextChanged
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
            If UseNTextBox = True Then
                File.WriteAllText(sfd_path.FileName, NTextBox1.Text)
            ElseIf UseNTextBox = False Then
                File.WriteAllText(sfd_path.FileName, NTextBox2.Text)
            End If
            If WaitDelay = True Then
                    IsSaved = True
                    MessageBox.Show("Text File Saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
    End Sub

    Private Sub UseOriginalButton_Click(sender As Object, e As EventArgs) Handles UseOriginalButton.Click
        If UseNTextBox = True Then
            NTextBox1.Visible = False
            NTextBox2.Visible = True
            UseOriginalButton.Text = "Use The NEW Text Box!"
            UseNTextBox = False
        ElseIf UseNTextBox = False Then
            NTextBox1.Visible = True
            NTextBox2.Visible = False
            UseOriginalButton.Text = "Use The Original Text Box!"
            UseNTextBox = True
        End If
    End Sub
End Class