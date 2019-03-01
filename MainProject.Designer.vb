<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainProject
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainProject))
        Me.VerText = New System.Windows.Forms.Label()
        Me.InfoText1 = New System.Windows.Forms.Label()
        Me.FNR_Icon = New System.Windows.Forms.PictureBox()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.FNRButton = New System.Windows.Forms.Button()
        Me.OpenTextButton = New System.Windows.Forms.Button()
        Me.SaveTextButton = New System.Windows.Forms.Button()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.TipLabel1 = New System.Windows.Forms.Label()
        Me.TipLabel2 = New System.Windows.Forms.Label()
        Me.RepTextBox = New System.Windows.Forms.TextBox()
        Me.OptionGroupBox = New System.Windows.Forms.GroupBox()
        Me.TrimGroupBox = New System.Windows.Forms.GroupBox()
        Me.TrimButton = New System.Windows.Forms.RadioButton()
        Me.RTrimButton = New System.Windows.Forms.RadioButton()
        Me.LTrimButton = New System.Windows.Forms.RadioButton()
        Me.UseOriginalButton = New System.Windows.Forms.Button()
        Me.ofd_path = New System.Windows.Forms.OpenFileDialog()
        Me.sfd_path = New System.Windows.Forms.SaveFileDialog()
        Me.NTextBox2 = New System.Windows.Forms.TextBox()
        Me.NTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        CType(Me.FNR_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OptionGroupBox.SuspendLayout()
        Me.TrimGroupBox.SuspendLayout()
        CType(Me.NTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VerText
        '
        Me.VerText.AutoSize = True
        Me.VerText.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerText.Location = New System.Drawing.Point(761, 525)
        Me.VerText.Name = "VerText"
        Me.VerText.Size = New System.Drawing.Size(162, 24)
        Me.VerText.TabIndex = 24
        Me.VerText.Text = "     Version. 1.0.0.0"
        '
        'InfoText1
        '
        Me.InfoText1.AutoSize = True
        Me.InfoText1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoText1.Location = New System.Drawing.Point(756, 505)
        Me.InfoText1.Name = "InfoText1"
        Me.InfoText1.Size = New System.Drawing.Size(167, 20)
        Me.InfoText1.TabIndex = 23
        Me.InfoText1.Text = "By MineEric64 (최에릭)"
        '
        'FNR_Icon
        '
        Me.FNR_Icon.Image = Global.Find_N_Replace.My.Resources.Resources.FindNReplace
        Me.FNR_Icon.Location = New System.Drawing.Point(764, 399)
        Me.FNR_Icon.Name = "FNR_Icon"
        Me.FNR_Icon.Size = New System.Drawing.Size(159, 150)
        Me.FNR_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FNR_Icon.TabIndex = 22
        Me.FNR_Icon.TabStop = False
        '
        'CopyButton
        '
        Me.CopyButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyButton.Location = New System.Drawing.Point(531, 466)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(189, 83)
        Me.CopyButton.TabIndex = 43
        Me.CopyButton.Text = "Copy Text"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'FNRButton
        '
        Me.FNRButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNRButton.Location = New System.Drawing.Point(210, 466)
        Me.FNRButton.Name = "FNRButton"
        Me.FNRButton.Size = New System.Drawing.Size(295, 83)
        Me.FNRButton.TabIndex = 44
        Me.FNRButton.Text = "Find N Replace"
        Me.FNRButton.UseVisualStyleBackColor = True
        '
        'OpenTextButton
        '
        Me.OpenTextButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenTextButton.Location = New System.Drawing.Point(29, 466)
        Me.OpenTextButton.Name = "OpenTextButton"
        Me.OpenTextButton.Size = New System.Drawing.Size(158, 39)
        Me.OpenTextButton.TabIndex = 46
        Me.OpenTextButton.Text = "Open Text File"
        Me.OpenTextButton.UseVisualStyleBackColor = True
        '
        'SaveTextButton
        '
        Me.SaveTextButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveTextButton.Location = New System.Drawing.Point(29, 512)
        Me.SaveTextButton.Name = "SaveTextButton"
        Me.SaveTextButton.Size = New System.Drawing.Size(158, 37)
        Me.SaveTextButton.TabIndex = 47
        Me.SaveTextButton.Text = "Save Text File"
        Me.SaveTextButton.UseVisualStyleBackColor = True
        '
        'FindTextBox
        '
        Me.FindTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindTextBox.Location = New System.Drawing.Point(749, 40)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(174, 22)
        Me.FindTextBox.TabIndex = 48
        '
        'TipLabel1
        '
        Me.TipLabel1.AutoSize = True
        Me.TipLabel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipLabel1.Location = New System.Drawing.Point(749, 23)
        Me.TipLabel1.Name = "TipLabel1"
        Me.TipLabel1.Size = New System.Drawing.Size(81, 14)
        Me.TipLabel1.TabIndex = 49
        Me.TipLabel1.Text = "To Find Text"
        '
        'TipLabel2
        '
        Me.TipLabel2.AutoSize = True
        Me.TipLabel2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipLabel2.Location = New System.Drawing.Point(749, 76)
        Me.TipLabel2.Name = "TipLabel2"
        Me.TipLabel2.Size = New System.Drawing.Size(104, 14)
        Me.TipLabel2.TabIndex = 51
        Me.TipLabel2.Text = "To Replace Text"
        '
        'RepTextBox
        '
        Me.RepTextBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepTextBox.Location = New System.Drawing.Point(749, 93)
        Me.RepTextBox.Name = "RepTextBox"
        Me.RepTextBox.Size = New System.Drawing.Size(174, 22)
        Me.RepTextBox.TabIndex = 50
        '
        'OptionGroupBox
        '
        Me.OptionGroupBox.Controls.Add(Me.TrimGroupBox)
        Me.OptionGroupBox.Controls.Add(Me.UseOriginalButton)
        Me.OptionGroupBox.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionGroupBox.Location = New System.Drawing.Point(749, 132)
        Me.OptionGroupBox.Name = "OptionGroupBox"
        Me.OptionGroupBox.Size = New System.Drawing.Size(174, 203)
        Me.OptionGroupBox.TabIndex = 52
        Me.OptionGroupBox.TabStop = False
        Me.OptionGroupBox.Text = "Options"
        '
        'TrimGroupBox
        '
        Me.TrimGroupBox.Controls.Add(Me.TrimButton)
        Me.TrimGroupBox.Controls.Add(Me.RTrimButton)
        Me.TrimGroupBox.Controls.Add(Me.LTrimButton)
        Me.TrimGroupBox.Location = New System.Drawing.Point(7, 21)
        Me.TrimGroupBox.Name = "TrimGroupBox"
        Me.TrimGroupBox.Size = New System.Drawing.Size(161, 96)
        Me.TrimGroupBox.TabIndex = 0
        Me.TrimGroupBox.TabStop = False
        Me.TrimGroupBox.Text = "Trim"
        '
        'TrimButton
        '
        Me.TrimButton.AutoSize = True
        Me.TrimButton.Location = New System.Drawing.Point(8, 69)
        Me.TrimButton.Name = "TrimButton"
        Me.TrimButton.Size = New System.Drawing.Size(50, 18)
        Me.TrimButton.TabIndex = 3
        Me.TrimButton.Text = "Trim"
        Me.TrimButton.UseVisualStyleBackColor = True
        '
        'RTrimButton
        '
        Me.RTrimButton.AutoSize = True
        Me.RTrimButton.Location = New System.Drawing.Point(8, 45)
        Me.RTrimButton.Name = "RTrimButton"
        Me.RTrimButton.Size = New System.Drawing.Size(121, 18)
        Me.RTrimButton.TabIndex = 2
        Me.RTrimButton.Text = "RTrim (TrimEnd)"
        Me.RTrimButton.UseVisualStyleBackColor = True
        '
        'LTrimButton
        '
        Me.LTrimButton.AutoSize = True
        Me.LTrimButton.Location = New System.Drawing.Point(8, 21)
        Me.LTrimButton.Name = "LTrimButton"
        Me.LTrimButton.Size = New System.Drawing.Size(126, 18)
        Me.LTrimButton.TabIndex = 1
        Me.LTrimButton.Text = "LTrim (TrimStart)"
        Me.LTrimButton.UseVisualStyleBackColor = True
        '
        'UseOriginalButton
        '
        Me.UseOriginalButton.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseOriginalButton.Location = New System.Drawing.Point(7, 123)
        Me.UseOriginalButton.Name = "UseOriginalButton"
        Me.UseOriginalButton.Size = New System.Drawing.Size(161, 69)
        Me.UseOriginalButton.TabIndex = 53
        Me.UseOriginalButton.Text = "Use The Original Text Box!"
        Me.UseOriginalButton.UseVisualStyleBackColor = True
        '
        'NTextBox2
        '
        Me.NTextBox2.Location = New System.Drawing.Point(11, 12)
        Me.NTextBox2.Multiline = True
        Me.NTextBox2.Name = "NTextBox2"
        Me.NTextBox2.Size = New System.Drawing.Size(731, 436)
        Me.NTextBox2.TabIndex = 54
        '
        'NTextBox1
        '
        Me.NTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.NTextBox1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.NTextBox1.BackBrush = Nothing
        Me.NTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NTextBox1.CharHeight = 14
        Me.NTextBox1.CharWidth = 8
        Me.NTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.NTextBox1.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.NTextBox1.IsReplaceMode = False
        Me.NTextBox1.Location = New System.Drawing.Point(11, 12)
        Me.NTextBox1.Name = "NTextBox1"
        Me.NTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.NTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NTextBox1.Size = New System.Drawing.Size(731, 436)
        Me.NTextBox1.TabIndex = 55
        Me.NTextBox1.Zoom = 100
        '
        'MainProject
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 561)
        Me.Controls.Add(Me.NTextBox1)
        Me.Controls.Add(Me.NTextBox2)
        Me.Controls.Add(Me.OptionGroupBox)
        Me.Controls.Add(Me.TipLabel2)
        Me.Controls.Add(Me.RepTextBox)
        Me.Controls.Add(Me.TipLabel1)
        Me.Controls.Add(Me.FindTextBox)
        Me.Controls.Add(Me.SaveTextButton)
        Me.Controls.Add(Me.OpenTextButton)
        Me.Controls.Add(Me.FNRButton)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.VerText)
        Me.Controls.Add(Me.InfoText1)
        Me.Controls.Add(Me.FNR_Icon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainProject"
        Me.Text = "Find N Replace"
        CType(Me.FNR_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OptionGroupBox.ResumeLayout(False)
        Me.TrimGroupBox.ResumeLayout(False)
        Me.TrimGroupBox.PerformLayout()
        CType(Me.NTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VerText As Label
    Friend WithEvents InfoText1 As Label
    Friend WithEvents FNR_Icon As PictureBox
    Friend WithEvents CopyButton As Button
    Friend WithEvents FNRButton As Button
    Friend WithEvents OpenTextButton As Button
    Friend WithEvents SaveTextButton As Button
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents TipLabel1 As Label
    Friend WithEvents TipLabel2 As Label
    Friend WithEvents RepTextBox As TextBox
    Friend WithEvents OptionGroupBox As GroupBox
    Friend WithEvents TrimGroupBox As GroupBox
    Friend WithEvents RTrimButton As RadioButton
    Friend WithEvents LTrimButton As RadioButton
    Friend WithEvents ofd_path As OpenFileDialog
    Friend WithEvents sfd_path As SaveFileDialog
    Friend WithEvents TrimButton As RadioButton
    Friend WithEvents UseOriginalButton As Button
    Friend WithEvents NTextBox2 As TextBox
    Friend WithEvents NTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
End Class
