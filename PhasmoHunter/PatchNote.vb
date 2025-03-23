Public Class PatchNote
    Private Sub PatchNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NoteText.BackColor = Color.FromArgb(17, 17, 17)
        NoteText.ReadOnly = True

        NoteText.Clear()

        NoteText.SelectionColor = MetroFramework.MetroColors.Red
        NoteText.AppendText("v0.0743 ")

        NoteText.SelectionColor = MetroFramework.MetroColors.White
        NoteText.AppendText(": 돈 무한 기능 삭제 & 소지금 설정 기능 추가, 무적 기능 추가, 점프 거리 기능 추가, 고스트 인포 기능 추가, 패치노트 기능 추가" + vbCrLf)

        NoteText.SelectionColor = MetroFramework.MetroColors.Red
        NoteText.AppendText("v0.0744 ")

        NoteText.SelectionColor = MetroFramework.MetroColors.White
        NoteText.AppendText(": 고스트 인포 기능 버그 수정" + vbCrLf)


        NoteText.SelectionColor = MetroFramework.MetroColors.Red
        NoteText.AppendText("v0.075 ")

        NoteText.SelectionColor = MetroFramework.MetroColors.White
        NoteText.AppendText(": 플레이어 & 텔레포트 통합 및 일부 기능 삭제" + vbCrLf)

        NoteText.SelectionColor = MetroFramework.MetroColors.Red
        NoteText.AppendText("v0.0751 ")

        NoteText.SelectionColor = MetroFramework.MetroColors.White
        NoteText.AppendText(": 점프 버그 수정" + vbCrLf)

    End Sub
End Class