<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatchNote
    Inherits MetroFramework.Forms.MetroForm

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
        Me.NoteText = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'NoteText
        '
        Me.NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NoteText.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.NoteText.Location = New System.Drawing.Point(10, 74)
        Me.NoteText.Name = "NoteText"
        Me.NoteText.Size = New System.Drawing.Size(284, 287)
        Me.NoteText.TabIndex = 0
        Me.NoteText.Text = ""
        '
        'PatchNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 376)
        Me.Controls.Add(Me.NoteText)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatchNote"
        Me.Opacity = 0.7R
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "PatchNote"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NoteText As RichTextBox
End Class
