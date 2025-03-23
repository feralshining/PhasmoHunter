Imports System.Management
Imports System.Net
Imports System.IO
Imports PhasmoHunter.PHClass

Public Class MainForm
#Region "Setting Environment Variable"
    Public OpenProc As Boolean
    Public GameLoading As Boolean
    Public ReadMoney, ReadLevel, ReadHoop As Integer
    Public ReadGrabLength, ReadXPos, ReadYPos, ReadZPos As Single
    Public ReadName As String
    Public Formshow As Boolean = True
    Public DirPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\" + "PhasmoHunter"
    Public JumpDistance As Integer
#End Region
#Region "Save Position Variable"
    Public SavXpos1, SavXpos2, SavXpos3, SavYpos1, SavYpos2, SavYpos3, SavZpos1, SavZpos2, SavZpos3 As Single
#End Region
    Private Sub ModActivate()
        PlayerTab.Enabled = True
#Region "Teleport Tab"
        XposBTN.Enabled = True
        YPosBTN.Enabled = True
        ZPosBTN.Enabled = True
        SavPosBTN1.Enabled = True
        SavPosBTN2.Enabled = True
        SavPosBTN3.Enabled = True
        MovPosBTN1.Enabled = True
        MovPosBTN2.Enabled = True
        MovPosBTN3.Enabled = True
        TelPosToggle.Enabled = True
        gravPosToggle.Enabled = True
        UpTelBTN.Enabled = True
        DownTelBTN.Enabled = True
        LeftTelBTN.Enabled = True
        RightTelBTN.Enabled = True
        yposupBTN.Enabled = True
        yposdownBTN.Enabled = True
        yposresetBTN.Enabled = True
#End Region
        GhostInfoTab.Enabled = True
#Region "Option Tab"
        bindingToggle.Enabled = True
        difficult1BTN.Enabled = True
        difficult2BTN.Enabled = True
        difficult3BTN.Enabled = True
        GhostShowToggle.Enabled = True
#End Region
        KeyBindingTimer.Enabled = True
        ParsePlayerSanity.Enabled = True
        ParseGhostInfo.Enabled = True
    End Sub
    Private Sub ModDeactivate()
        PlayerTab.Enabled = False
#Region "Teleport Tab"
        XposBTN.Enabled = False
        YPosBTN.Enabled = False
        ZPosBTN.Enabled = False
        SavPosBTN1.Enabled = False
        SavPosBTN2.Enabled = False
        SavPosBTN3.Enabled = False
        MovPosBTN1.Enabled = False
        MovPosBTN2.Enabled = False
        MovPosBTN3.Enabled = False
        TelPosToggle.Enabled = False
        gravPosToggle.Enabled = False
        UpTelBTN.Enabled = False
        DownTelBTN.Enabled = False
        LeftTelBTN.Enabled = False
        RightTelBTN.Enabled = False
        yposupBTN.Enabled = False
        yposdownBTN.Enabled = False
        yposresetBTN.Enabled = False
#End Region
        GhostInfoTab.Enabled = False
#Region "Option Tab"
        bindingToggle.Enabled = False
        difficult1BTN.Enabled = False
        difficult2BTN.Enabled = False
        difficult3BTN.Enabled = False
        GhostShowToggle.Enabled = False
#End Region
        KeyBindingTimer.Enabled = False
        ParsePlayerSanity.Enabled = False
        ParseGhostInfo.Enabled = False
    End Sub
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Public Function KeyFromString(theKey As String) As Keys
        Dim kc As KeysConverter = New KeysConverter()
        Return CType(kc.ConvertFrom(theKey), Keys)
    End Function
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "Environment Variable"
        Dim ProgramVer As Double = 0.0753
        Dim mainsplit, mainsplit2, updatelink As String
        Dim FuckMain, FuckMain2, FuckContent As String
        Dim OldVer As Boolean = False
        Dim Update As Boolean = False
        Dim PH As New PHClass
        Me.Location = New Point(0, 0)
#End Region
#Region "Auto Update"
        '        Try
        '            Dim testResp As WebResponse
        '            Dim testResq As WebRequest = HttpWebRequest.Create("https://phasmohunter.tistory.com/2")
        '            Dim testver As String = ""
        '            testResp = testResq.GetResponse()
        '        Catch ex As Exception
        '            MsgBox("업데이트 서버에 접근할 수 없습니다", vbCritical, "알림")
        '            Dim ErrorReader As New StreamReader(DirPath + "\" + "PhasmoHunter_CriticalError.log")
        '            Dim Errortxt As String = ErrorReader.ReadToEnd
        '            Dim ErrorWriter As New StreamWriter(DirPath + "\" + "PhasmoHunter_CriticalError.log")
        '            ErrorWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " // " + Errortxt + vbCrLf + ex.Message)
        '            ErrorWriter.Flush()
        '        End Try

        '        Dim UpdateResp As WebResponse
        '        Dim UpdateWReq As WebRequest = HttpWebRequest.Create("https://phasmohunter.tistory.com/2")
        '        Dim version As String = ""
        '        UpdateResp = UpdateWReq.GetResponse()
        '        Using Updates As New StreamReader(UpdateResp.GetResponseStream())
        '            version = Updates.ReadToEnd()
        '            Updates.Close()
        '            mainsplit = Split(Split(version, "<!-- BEGIN STRUCTURED_DATA -->")(1), "<!-- END STRUCTURED_DATA -->")(0)
        '            mainsplit2 = Split(Split(mainsplit, "description"":""")(1), """,""author")(0)
        '            mainsplit2 = Replace(mainsplit2, " ", vbNewLine)
        '            updatelink = Split(Split(version, "<figure class=""fileblock"" data-ke-align=""alignCenter""><a href=""")(1), """><div class=""image""></div>")(0)

        '            If ProgramVer < Convert.ToDouble(Split(mainsplit2, vbNewLine)(0)) Then
        '                Dim UpdateYesNo As MsgBoxResult = MsgBox("업데이트 된 버전이 존재합니다. 업데이트 하시겠습니까?", vbYesNo, "알림")
        '                If UpdateYesNo = MsgBoxResult.Yes Then
        '                    Dim client As New WebClient
        '                    client.DownloadFile(updatelink, Application.StartupPath + "\" + "PhasmoHunter v" + mainsplit2 + ".exe")
        '                    Process.Start(Application.StartupPath + "\" + "PhasmoHunter v" + mainsplit2 + ".exe")
        '                    OldVer = True
        '                    Update = True
        '                Else
        '                    Dim updateWriter As New StreamWriter(DirPath + "\" + "Update_Info.ini")
        '                    updateWriter.WriteLine("OldVersion : " + Application.ExecutablePath)
        '                    updateWriter.WriteLine("Update : No")
        '                    updateWriter.Flush()
        '                    updateWriter.Close()
        '                    updateWriter.Dispose()
        '                    newverlbl.Text = mainsplit2
        '                End If
        '            End If
        '            If OldVer = True Then
        '                My.Computer.FileSystem.CreateDirectory(DirPath)
        '                Dim updateWriter As New StreamWriter(DirPath + "\" + "Update_Info.ini")
        '                updateWriter.WriteLine("OldVersion : " + Application.ExecutablePath)
        '                updateWriter.WriteLine("Update : Yes")
        '                updateWriter.Flush()
        '                updateWriter.Dispose()
        '                Dim FilePath As String = Application.ExecutablePath.Substring(Application.ExecutablePath.LastIndexOf("\") + 1)
        '                FilePath = Replace(FilePath, ".exe", "")
        '                For Each p As Process In Process.GetProcesses
        '                    If p.ProcessName = FilePath Then
        '                        p.Kill()
        '                    End If
        '                Next
        '            Else
        '                Try
        '                    Dim CatchInfo As New StreamReader(DirPath + "\" + "Update_Info.ini")
        '                    Dim CatchPath As String = CatchInfo.ReadToEnd
        '                    CatchInfo.Dispose()
        '                Catch
        '                    My.Computer.FileSystem.CreateDirectory(DirPath)
        '                    Dim updateWriter As New StreamWriter(DirPath + "\" + "Update_Info.ini")
        '                    updateWriter.WriteLine("OldVersion : " + Application.ExecutablePath)
        '                    updateWriter.WriteLine("Update : No")
        '                    updateWriter.Flush()
        '                End Try
        '                Dim ReadUpdateInfo As New StreamReader(DirPath + "\" + "Update_Info.ini")
        '                Dim ReadPath As String = ReadUpdateInfo.ReadToEnd
        '                Dim ReadOldPath = Split(Split(ReadPath, "OldVersion : ")(1), vbNewLine)(0)
        '                Dim ReadUpdateBool As String = Split(ReadPath, "Update : ")(1)
        '                Try
        '                    If ReadUpdateBool.Contains("Yes") Then
        '                        My.Computer.FileSystem.DeleteFile(ReadOldPath)
        '                    End If
        '                Catch ex As Exception
        '                    Dim updateWriter As New StreamWriter(DirPath + "\" + "PhasmoHunter_Error.log")
        '                    updateWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " // " + ex.Message)
        '                    updateWriter.Flush()
        '                End Try
        '                newverlbl.Text = mainsplit2
        '            End If
        '        End Using
#End Region
#Region "Recognize Fuck"
        '        Dim FuckWResp As WebResponse
        '        Dim FuckWReq As WebRequest = HttpWebRequest.Create("https://phasmohunter.tistory.com/3")
        '        Dim FuckVer As String = ""
        '        Dim IsFucking As String = ""
        '        FuckWResp = FuckWReq.GetResponse()
        '        Using Fucking As New StreamReader(FuckWResp.GetResponseStream())
        '            FuckContent = Fucking.ReadToEnd()
        '            Fucking.Close()
        '            FuckMain = Split(Split(FuckContent, "<!-- BEGIN STRUCTURED_DATA -->")(1), "<!-- END STRUCTURED_DATA -->")(0)
        '            FuckMain2 = Split(Split(FuckMain, "description"":""")(1), """,""author")(0)
        '            FuckMain2 = Replace(FuckMain2, " ", vbCrLf)
        '            FuckVer = Split(Split(FuckMain2, "version:")(1), vbCrLf)(0)
        '            IsFucking = Split(FuckMain2, "Fuck:")(1)

        '            If IsFucking = "True" Then
        '                If ProgramVer <= FuckVer Then
        '                    MsgBox("더 이상 지원하지 않는 버전이므로 이용하실 수 없습니다.", vbCritical, "알림")
        '                    Application.Exit()
        '                End If
        '            End If
        '        End Using
#End Region
#Region "Serial Auth"
        'Dim HDD_Serial As String
        'Dim hdd As New ManagementObjectSearcher("select * from Win32_DiskDrive")
        'For Each hd In hdd.Get
        '    HDD_Serial = hd("SerialNumber")
        '    HDD_Serial = Replace(HDD_Serial, " ", "")
        'Next

        'Try
        '    Dim AuthResp As WebResponse
        '    Dim AuthResq As WebRequest = HttpWebRequest.Create("https://phasmohunter.tistory.com/1")
        '    AuthResp = AuthResq.GetResponse()
        '    AuthResp.Dispose()
        'Catch ex As Exception
        '    MsgBox("인증 서버에 접근할 수 없습니다", vbCritical, "알림")
        '    Dim ErrorReader As New StreamReader(DirPath + "\" + "PhasmoHunter_CriticalError.log")
        '    Dim Errortxt As String = ErrorReader.ReadToEnd
        '    Dim ErrorWriter As New StreamWriter(DirPath + "\" + "PhasmoHunter_CriticalError.log")
        '    ErrorWriter.WriteLine(Errortxt + vbCrLf + ex.Message)
        '    ErrorWriter.Flush()
        '    Exit Sub
        'End Try

        'Dim wresp As WebResponse
        'Dim wreq As WebRequest = HttpWebRequest.Create("https://phasmohunter.tistory.com/1")
        'Dim str As String = ""
        'wresp = wreq.GetResponse()

        'Using sr As New StreamReader(wresp.GetResponseStream())
        '    str = sr.ReadToEnd()
        '    sr.Close()
        '    mainsplit = Split(Split(str, "<!-- BEGIN STRUCTURED_DATA -->")(1), "<!-- END STRUCTURED_DATA -->")(0)
        '    mainsplit2 = Split(Split(mainsplit, "description"":""")(1), """,""author")(0)
        '    mainsplit2 = Replace(mainsplit2, " ", vbNewLine)
        'End Using
#End Region
#Region "Auth OK"
        'If mainsplit2.Contains(HDD_Serial) = False Then
        '    MsgBox("인증되지 않은 사용자입니다.", vbCritical, "알림")
        '    Application.Exit()
        'ElseIf mainsplit2.Contains(HDD_Serial) = True Then
        OpenProc = PH.getGameState()
        If OpenProc = False Then
            MsgBox("PhasmoPhobia 프로세스를 찾을 수 없습니다", vbCritical, "알림")
            Application.Exit()
        ElseIf OpenProc = True Then
#Region "기능 활성화"
            ModActivate()
            CheckGameTimer.Enabled = True
            ParsePositionTimer.Enabled = True
            AuthTimer.Enabled = True
#End Region
#Region "폼 환경 셋팅"
            helpText.ReadOnly = True
            helpText.BackColor = Color.FromArgb(17, 17, 17)
            PictureBox2.BackColor = Color.FromArgb(17, 17, 17)
            playerBTN_Click(sender, e)
            ModMenuTab.SelectTab(0)
#End Region
            oldverlbl.Text = ProgramVer.ToString
            If Convert.ToDouble(oldverlbl.Text) < Convert.ToDouble(newverlbl.Text) Then
                UpdateBTN.Enabled = True
            Else
                UpdateBTN.Enabled = False
            End If
        End If
        'End If
#End Region
    End Sub

    Private Sub CheckGameTimer_Tick(sender As Object, e As EventArgs) Handles CheckGameTimer.Tick
        Dim PH As New PHClass
        OpenProc = PH.getGameState()
        If OpenProc = True Then
            If GameLoading = False Then
#Region "Game State : ON"
                LoadingState1.Visible = False
                LoadingState2.Visible = False

                MetroLabel3.Visible = True
                StateOffLbl.Visible = False
                StateOnLbl.Visible = True
                ModActivate()
#End Region
            ElseIf GameLoading = True Then
#Region "Game State : Loading.."
                MetroLabel3.Visible = False
                StateOffLbl.Visible = False
                StateOnLbl.Visible = False
                LoadingState1.Visible = True
                LoadingState2.Visible = True
                ModDeactivate()
#End Region
            End If
        ElseIf OpenProc = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles LevelNumeric.ValueChanged
        Dim EmptyLevel As String = "00"
        Dim SetLevel As Integer
        Dim PH As New PHClass
        SetLevel = Convert.ToInt32(LevelNumeric.Value.ToString + EmptyLevel)
        PH.setLevel(SetLevel)
    End Sub

    Private Sub SetLevelBTN_Click(sender As Object, e As EventArgs) Handles SetLevelBTN.Click
        Dim EmptyLevel As String = "00"
        Dim SetLevel As Integer
        Try
            SetLevel = Convert.ToInt32(LevelTextBox.Text + EmptyLevel)
        Catch
            MsgBox("레벨은 오로지 정수만 입력할 수 있습니다", vbCritical, "알림")
            Exit Sub
        End Try
        Dim PH As New PHClass
        PH.setLevel(SetLevel)
    End Sub

    Private Sub SavPosBTN2_Click(sender As Object, e As EventArgs) Handles SavPosBTN2.Click
        Dim PH As New PHClass

        SavXpos2 = PH.getPlayerXpos()
        SavYpos2 = PH.getPlayerYpos()
        SavZpos2 = PH.getPlayerZpos()

    End Sub

    Private Sub SavPosBTN3_Click(sender As Object, e As EventArgs) Handles SavPosBTN3.Click
        Dim PH As New PHClass

        SavXpos3 = PH.getPlayerXpos()
        SavYpos3 = PH.getPlayerYpos()
        SavZpos3 = PH.getPlayerZpos()
    End Sub

    Private Sub MovPosBTN1_Click(sender As Object, e As EventArgs) Handles MovPosBTN1.Click
        Dim PH As New PHClass
        PH.setPlayerXPos(SavXpos1)
        PH.setPlayerYPos(SavYpos1)
        PH.setPlayerZPos(SavZpos1)
    End Sub

    Private Sub MovPosBTN2_Click(sender As Object, e As EventArgs) Handles MovPosBTN2.Click
        Dim PH As New PHClass
        PH.setPlayerXPos(SavXpos2)
        PH.setPlayerYPos(SavYpos2)
        PH.setPlayerZPos(SavZpos2)
    End Sub

    Private Sub XposText_Enter(sender As Object, e As EventArgs) Handles XposText.Enter
        ParsePositionTimer.Enabled = False
    End Sub

    Private Sub YPosBTN_Enter(sender As Object, e As EventArgs) Handles YPosBTN.Enter
        ParsePositionTimer.Enabled = False
    End Sub

    Private Sub ZposText_Enter(sender As Object, e As EventArgs) Handles ZposText.Enter
        ParsePositionTimer.Enabled = False
    End Sub

    Private Sub ZposText_Leave(sender As Object, e As EventArgs) Handles ZposText.Leave
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub UpTelBTN_Click(sender As Object, e As EventArgs) Handles UpTelBTN.Click
        If TelPosToggle.Checked = True Then
            Dim PH As New PHClass
            PH.setPlayerYPos(PH.getPlayerYpos - 0.125)
            ParsePositionTimer.Enabled = True
        ElseIf TelPosToggle.Checked = False Then
            Exit Sub
        End If
    End Sub

    Private Sub YPosBTN_Click_1(sender As Object, e As EventArgs) Handles YPosBTN.Click
        Try
            Convert.ToSingle(YposText.Text)
        Catch
            MsgBox("위치는 정수 혹은 실수로만 입력할 수 있습니다.")
            Exit Sub
        End Try
        Dim PH As New PHClass
        PH.setPlayerXPos(YposText.Text)
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub DownTelBTN_Click(sender As Object, e As EventArgs) Handles DownTelBTN.Click
        If TelPosToggle.Checked = True Then
            Dim PH As New PHClass
            PH.setPlayerYPos(PH.getPlayerYpos() + 0.125)
            ParsePositionTimer.Enabled = True
        ElseIf TelPosToggle.Checked = False Then
            Exit Sub
        End If
    End Sub

    Private Sub LeftTelBTN_Click(sender As Object, e As EventArgs) Handles LeftTelBTN.Click
        If TelPosToggle.Checked = True Then
            Dim PH As New PHClass
            PH.setPlayerXPos(PH.getPlayerXpos - 0.125)
            ParsePositionTimer.Enabled = True
        ElseIf TelPosToggle.Checked = False Then
            Exit Sub
        End If
    End Sub

    Private Sub RightTelBTN_Click(sender As Object, e As EventArgs) Handles RightTelBTN.Click
        If TelPosToggle.Checked = True Then
            Dim PH As New PHClass
            PH.setPlayerXPos(PH.getPlayerXpos + 0.125)
            ParsePositionTimer.Enabled = True
        ElseIf TelPosToggle.Checked = False Then
            Exit Sub
        End If
    End Sub


    Private Sub KeyBindingTimer_Tick(sender As Object, e As EventArgs) Handles KeyBindingTimer.Tick

        If bindingToggle.Checked = True Then
#Region "축지법 기능 예외 처리"
            If TelPosToggle.Checked = True Then
                If CBool(GetAsyncKeyState(Keys.Up)) Then
                    UpTelBTN_Click(sender, e)
                ElseIf CBool(GetAsyncKeyState(Keys.Down)) Then
                    DownTelBTN_Click(sender, e)
                ElseIf CBool(GetAsyncKeyState(Keys.Right)) Then
                    RightTelBTN_Click(sender, e)
                ElseIf CBool(GetAsyncKeyState(Keys.Left)) Then
                    LeftTelBTN_Click(sender, e)
                End If
            End If
#End Region
#Region "위치 저장 기능 예외 처리"
            If CBool(GetAsyncKeyState(Keys.F1)) Then
                MovPosBTN1_Click(sender, e)
            ElseIf CBool(GetAsyncKeyState(Keys.F2)) Then
                MovPosBTN2_Click(sender, e)
            ElseIf CBool(GetAsyncKeyState(Keys.F3)) Then
                MovPosBTN3_Click(sender, e)
            ElseIf CBool(GetAsyncKeyState(Keys.Multiply)) Then
                If Formshow = True Then
                    Me.Hide()
                    Formshow = False
                ElseIf Formshow = False Then
                    Me.Show()
                    Formshow = True
                End If
            End If
#End Region
#Region "공중부양 기능 예외 처리"
            If gravPosToggle.Checked = True Then
                If CBool(GetAsyncKeyState(Keys.NumPad8)) Then
                    yposupBTN_Click(sender, e)
                End If
                If CBool(GetAsyncKeyState(Keys.NumPad5)) Then
                    yposdownBTN_Click(sender, e)
                End If
                If CBool(GetAsyncKeyState(Keys.NumPad0)) Then
                    yposresetBTN_Click(sender, e)
                End If
            End If
#End Region
#Region "점프 기능 예외 처리"
            If jumpToggle.Checked = True Then
                JumpBar.Enabled = True
                JumpDistance = JumpBar.Value
                If CBool(GetAsyncKeyState(Keys.Space)) Then
                    Dim PH As New PHClass
                    PH.setPlayerJump(JumpDistance)
                End If
            ElseIf jumpToggle.Checked = False Then
                JumpBar.Enabled = False
            End If
#End Region
        ElseIf bindingToggle.Checked = False Then
            Exit Sub
        End If
    End Sub
    Private Sub 열기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 열기ToolStripMenuItem.Click
        Me.Show()
        Formshow = True
    End Sub
    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub playerBTN_Click(sender As Object, e As EventArgs) Handles playerBTN.Click

        helpText.Clear()

        helpText.SelectionColor = MetroFramework.MetroColors.Red
        helpText.AppendText("소지금 설정 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 현재 소지한 금액 텍스트 박스에 입력한 값으로 조정합니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Brown
        helpText.AppendText("레벨 조정 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 현재 레벨을 텍스트 박스에 입력한 값으로 조정합니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Yellow
        helpText.AppendText("농구 점수 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 로비에서의 농구 점수판의 점수를 텍스트 박스에 입력한 값으로 조정합니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Purple
        helpText.AppendText("네임 변경 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 현재 이름을 텍스트 박스에 입력한 값으로 변경합니다. 최대 7글자까지 인식합니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Orange
        helpText.AppendText("그랩 거리 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 로비 또는 인게임에서의 E키 혹은 마우스를 이용한 잡기 기능의 거리를 조정합니다. 초기 값은 1.6이며 최대 50까지 조정 가능합니다. 로비와 인게임 따로 그랩 거리를 조정해야 적용 가능합니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Pink
        helpText.AppendText("스피드 핵 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 현재 사용 불가능" + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Green
        helpText.AppendText("무적 모드 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 유령의 헌팅 대상에 걸리지 않도록 무적 상태로 만듭니다. 무적 상태일 때에는 손전등, 물건 줍기 등의 사물과의 상호작용이 불가능합니다. " + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Magenta
        helpText.AppendText("점프 기능 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 스페이스바 키를 눌러서 점프 기능을 이용할 수 있습니다. 키 바인딩 기능을 활성화해야 이용 가능하며 로비에서는 이용할 수 없습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Pink
        helpText.AppendText("점프 거리 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 스크롤바를 조작해 점프할 수 있는 거리를 조작할 수 있습니다. 점프 기능이 활성화되어야 이용할 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Teal
        helpText.AppendText("정신력 수치 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 플레이어의 정신력 수치를 실시간으로 값을 받아 텍스트 박스에 표시합니다. 텍스트 박스에 원하는 수치를 입력하고 Set버튼을 누를 경우 입력한 수치만큼 정신력의 수치가 변경됩니다.")
    End Sub

    Private Sub telBTN_Click(sender As Object, e As EventArgs) Handles telBTN.Click
        helpText.Clear()

        helpText.SelectionColor = MetroFramework.MetroColors.Red
        helpText.AppendText("X Pos ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 실시간으로 플레이어의 X 좌표를 구합니다. Set 버튼으로 임의로 좌표 변경을 할 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Blue
        helpText.AppendText("Y Pos ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 실시간으로 플레이어의 Y 좌표를 구합니다. Set 버튼으로 임의로 좌표 변경을 할 수 있습니다. PhasmoPhobia에서의 Y축은 실제로는 Z축입니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Yellow
        helpText.AppendText("Z Pos ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 실시간으로 플레이어의 Z 좌표를 구합니다. Set 버튼으로 임의로 좌표 변경을 할 수 있습니다. PhasmoPhobia에서의 Z축은 실제로는 Y축입니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Green
        helpText.AppendText("위치 저장 기능 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 위치 저장 버튼을 이용해 현재 플레이어의 위치를 저장할 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Orange
        helpText.AppendText("위치 이동 기능 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 플레이어의 위치를 위치 저장 버튼을 이용해 저장한 값으로 즉시 이동합니다. 각각 F1, F2, F3 단축키를 통해 게임 내에서 즉시 이동할 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Pink
        helpText.AppendText("축지법 기능 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 키보드 방향키를 조작해 현재 플레이어의 X좌표와 Z좌표를 변경할 수 있습니다. ↑ = Z축 +0.125, ↓ = Z축 -0.125, ← = X축 -0.125, → = X축 +0.125 입니다. 옵션 탭의 키 바인딩 기능과 텔레포트 탭의 축지법 기능 토글을 둘 다 켜야 키보드 방향키로 조작할 수 있습니다. 축지법 기능만 킬 경우 버튼으로만 조작할 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Magenta
        helpText.AppendText("공중부양 기능 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 넘패드 키를 조작해 현재 플레이어의 y좌표를 변경할 수 있습니다. Numpad8 = Y축 + 0.1, Numpad5 = Y축 - 0.1 입니다. 옵션 탭의 키 바인딩 기능과 텔레포트 탭의 공중부양 기능 토글을 둘 다 켜야 넘패드로 조작할 수 있습니다. 공중부양 기능만 킬 경우 버튼으로만 조작할 수 있습니다. 로비에서는 이용할 수 없습니다.")
    End Sub

    Private Sub optionBTN_Click(sender As Object, e As EventArgs) Handles optionBTN.Click
        helpText.Clear()

        helpText.SelectionColor = MetroFramework.MetroColors.Blue
        helpText.AppendText("키 바인딩 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": PhasmoHunter의 기능들을 방향키로 이용할 수 있게 만드는 기능입니다. Insert = 창 열기/내리기, F1 F2 F3 = 위치 이동, 키보드 방향키 = 좌표 변경 등의 기능을 사용할 수 있게 합니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Magenta
        helpText.AppendText("난이도 설정 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 현재 선택한 의뢰의 난이도를 버튼에 맞게 설정한 값으로 조정합니다. 개인만 적용되며 타인은 적용되지 않습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Green
        helpText.AppendText("유령 발소리 듣기 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 플레이어가 방장일 경우에만 해당 기능을 사용할 수 있으며, 타인에게는 귀신의 발소리가 들리지 않습니다. 발소리를 통해 귀신의 방을 알아낼 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Red
        helpText.AppendText("게임 강제 종료 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": ""게임 강제 종료"" 버튼을 통해 즉시 프로세스를 종료하여 게임을 종료합니다.")
    End Sub

    Private Sub KillProcBTN_Click(sender As Object, e As EventArgs) Handles KillProcBTN.Click
        On Error Resume Next
        Dim pcProcess() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName("Phasmophobia")
        For Each killproc In pcProcess
            killproc.Kill()
        Next
    End Sub

    Private Sub AuthTimer_Tick(sender As Object, e As EventArgs) Handles AuthTimer.Tick
        Dim mainsplit, mainsplit2 As String
#Region "Serial Auth"
        Dim HDD_Serial As String
        Dim hdd As New ManagementObjectSearcher("select * from Win32_DiskDrive")
        For Each hd In hdd.Get
            HDD_Serial = hd("SerialNumber")
            HDD_Serial = Replace(HDD_Serial, " ", "")
        Next

        Dim wresp As WebResponse
        Dim wreq As WebRequest = HttpWebRequest.Create("https://phasmohunter.tistory.com/1")
        Dim str As String = ""
        wresp = wreq.GetResponse()

        Using sr As New StreamReader(wresp.GetResponseStream())
            str = sr.ReadToEnd()
            sr.Close()
            mainsplit = Split(Split(str, "<!-- BEGIN STRUCTURED_DATA -->")(1), "<!-- END STRUCTURED_DATA -->")(0)
            mainsplit2 = Split(Split(mainsplit, "description"":""")(1), """,""author")(0)
            mainsplit2 = Replace(mainsplit2, " ", vbNewLine)
        End Using
#End Region

        If mainsplit2.Contains(HDD_Serial) = False Then
            MsgBox("인증되지 않은 사용자입니다.", vbCritical, "알림")
            Application.Exit()
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles thanksBTN.Click
        helpText.Clear()

        helpText.SelectionColor = MetroFramework.MetroColors.Blue
        helpText.AppendText("Thanks To :")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(" BOMBOY, ssipjil, krgdy, choko, moodog" + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Red
        helpText.AppendText("Created By feralshining")
    End Sub

    Private Sub TelPosToggle_CheckStateChanged(sender As Object, e As EventArgs) Handles TelPosToggle.CheckStateChanged

        If TelPosToggle.Checked = True Then
            UpTelBTN.Enabled = True
            DownTelBTN.Enabled = True
            LeftTelBTN.Enabled = True
            RightTelBTN.Enabled = True
        ElseIf TelPosToggle.Checked = False Then
            UpTelBTN.Enabled = False
            DownTelBTN.Enabled = False
            LeftTelBTN.Enabled = False
            RightTelBTN.Enabled = False
        End If

    End Sub

    Private Sub yposupBTN_Click(sender As Object, e As EventArgs) Handles yposupBTN.Click
        Dim PH As New PHClass
        PH.setGroundForce(0)
        PH.setGravity(0)
        Dim playerYpos As Single = PH.getPlayerZpos()
        PH.setPlayerZPos(playerYpos + 0.05)
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub yposdownBTN_Click(sender As Object, e As EventArgs) Handles yposdownBTN.Click
        Dim PH As New PHClass
        PH.setGroundForce(0)
        PH.setGravity(0)
        Dim playerYpos As Single = PH.getPlayerZpos()
        PH.setPlayerZPos(playerYpos - 0.05)
        ParsePositionTimer.Enabled = True
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub gravPosToggle_CheckStateChanged(sender As Object, e As EventArgs) Handles gravPosToggle.CheckStateChanged
        If gravPosToggle.Checked = True Then
            yposupBTN.Enabled = True
            yposdownBTN.Enabled = True
            yposresetBTN.Enabled = True
        ElseIf gravPosToggle.Checked = False Then
            yposupBTN.Enabled = False
            yposdownBTN.Enabled = False
            yposresetBTN.Enabled = False
        End If
    End Sub

    Private Sub yposresetBTN_Click(sender As Object, e As EventArgs) Handles yposresetBTN.Click
        Dim PH As New PHClass
        PH.setGroundForce(100)
        PH.setGravity(2)
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub difficult1BTN_Click(sender As Object, e As EventArgs) Handles difficult1BTN.Click
        Dim PH As New PHClass
        PH.setDifficult(0)
    End Sub

    Private Sub SanityBTN_Click(sender As Object, e As EventArgs) Handles SanityBTN.Click
        ParsePlayerSanity.Enabled = False
        System.Threading.Thread.Sleep(100)
        Dim ReplacePercent As String = Replace(SanityText.Text, "%", "")
        Try
            Convert.ToInt32(ReplacePercent)
        Catch
            MsgBox("정신력은 정수 또는 실수만 입력할 수 있습니다.")
            Exit Sub
        End Try
        Dim PH As New PHClass
        If SanityText.Text.Contains("%") Then
            PH.setPlayerSanity(Convert.ToInt32(ReplacePercent))
        Else
            PH.setPlayerSanity(Convert.ToInt32(SanityText.Text))
        End If
        System.Threading.Thread.Sleep(100)
        ParsePlayerSanity.Enabled = True
    End Sub

    Private Sub SanityText_Enter(sender As Object, e As EventArgs) Handles SanityText.Enter
        ParsePlayerSanity.Enabled = False
    End Sub

    Private Sub SanityText_Leave(sender As Object, e As EventArgs) Handles SanityText.Leave
        System.Threading.Thread.Sleep(1500)
        ParsePlayerSanity.Enabled = True
    End Sub

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        Dim ProgramVer As Double = 0.0753
        Dim mainsplit, mainsplit2, updatelink As String
        Dim OldVer As Boolean = False
        Dim Update As Boolean = False
        Try
            Dim testResp As WebResponse
            Dim testResq As WebRequest = HttpWebRequest.Create("https://phasmohunter.tistory.com/2")
            Dim testver As String = ""
            testResp = testResq.GetResponse()
        Catch ex As Exception
            MsgBox("업데이트 서버에 접근할 수 없습니다", vbCritical, "알림")
            Dim ErrorReader As New StreamReader(DirPath + "\" + "PhasmoHunter_CriticalError.log")
            Dim Errortxt As String = ErrorReader.ReadToEnd
            Dim ErrorWriter As New StreamWriter(DirPath + "\" + "PhasmoHunter_CriticalError.log")
            ErrorWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " // " + Errortxt + vbCrLf + ex.Message)
            ErrorWriter.Flush()
            Exit Sub
        End Try

        Dim UpdateResp As WebResponse
        Dim UpdateWReq As WebRequest = HttpWebRequest.Create("https://phasmohunter.tistory.com/2")
        Dim version As String = ""
        UpdateResp = UpdateWReq.GetResponse()
        Using Updates As New StreamReader(UpdateResp.GetResponseStream())
            version = Updates.ReadToEnd()
            Updates.Close()
            mainsplit = Split(Split(version, "<!-- BEGIN STRUCTURED_DATA -->")(1), "<!-- END STRUCTURED_DATA -->")(0)
            mainsplit2 = Split(Split(mainsplit, "description"":""")(1), """,""author")(0)
            mainsplit2 = Replace(mainsplit2, " ", vbNewLine)
            updatelink = Split(Split(version, "<figure class=""fileblock"" data-ke-align=""alignCenter""><a href=""")(1), """><div class=""image""></div>")(0)

            If ProgramVer < Convert.ToDouble(Split(mainsplit2, vbNewLine)(0)) Then
                Dim UpdateYesNo As MsgBoxResult = MsgBox("업데이트 된 버전이 존재합니다. 업데이트 하시겠습니까?", vbYesNo, "알림")
                If UpdateYesNo = MsgBoxResult.Yes Then
                    Dim client As New WebClient
                    client.DownloadFile(updatelink, Application.StartupPath + "\" + "PhasmoHunter v" + mainsplit2 + ".exe")
                    Process.Start(Application.StartupPath + "\" + "PhasmoHunter v" + mainsplit2 + ".exe")
                    OldVer = True
                    Update = True
                Else
                    Dim updateWriter As New StreamWriter(DirPath + "\" + "Update_Info.ini")
                    updateWriter.WriteLine("OldVersion : " + Application.ExecutablePath)
                    updateWriter.WriteLine("Update : No")
                    updateWriter.Flush()
                    updateWriter.Close()
                    newverlbl.Text = mainsplit2
                End If
            End If
            If OldVer = True Then
                My.Computer.FileSystem.CreateDirectory(DirPath)
                Dim updateWriter As New StreamWriter(DirPath + "\" + "Update_Info.ini")
                updateWriter.WriteLine("OldVersion : " + Application.ExecutablePath)
                updateWriter.WriteLine("Update : Yes")
                updateWriter.Flush()
                updateWriter.Dispose()
                Dim FilePath As String = Application.ExecutablePath.Substring(Application.ExecutablePath.LastIndexOf("\") + 1)
                FilePath = Replace(FilePath, ".exe", "")
                For Each p As Process In Process.GetProcesses
                    If p.ProcessName = FilePath Then
                        p.Kill()
                    End If
                Next
            Else
                Try
                    Dim CatchInfo As New StreamReader(DirPath + "\" + "Update_Info.ini")
                    Dim CatchPath As String = CatchInfo.ReadToEnd
                Catch
                    My.Computer.FileSystem.CreateDirectory(DirPath)
                    Dim updateWriter As New StreamWriter(DirPath + "\" + "Update_Info.ini")
                    updateWriter.WriteLine("OldVersion : " + Application.ExecutablePath)
                    updateWriter.WriteLine("Update : No")
                    updateWriter.Flush()
                End Try
                Dim ReadUpdateInfo As New StreamReader(DirPath + "\" + "Update_Info.ini")
                Dim ReadPath As String = ReadUpdateInfo.ReadToEnd
                Dim ReadOldPath = Split(Split(ReadPath, "OldVersion : ")(1), vbNewLine)(0)
                Dim ReadUpdateBool As String = Split(ReadPath, "Update : ")(1)
                Try
                    If ReadUpdateBool.Contains("Yes") Then
                        My.Computer.FileSystem.DeleteFile(ReadOldPath)
                    End If
                Catch ex As Exception
                    Dim updateWriter As New StreamWriter(DirPath + "\" + "PhasmoHunter_Error.log")
                    updateWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " // " + ex.Message)
                    updateWriter.Flush()
                End Try
            End If
        End Using
    End Sub

    Private Sub SanityText_Click(sender As Object, e As EventArgs) Handles SanityText.Click
        ParsePlayerSanity.Enabled = False
    End Sub

    Private Sub moneysetBTN_Click(sender As Object, e As EventArgs) Handles moneysetBTN.Click
        Dim playerMoney As Integer
        Try
            playerMoney = Convert.ToInt32(playerMoneyText.Text)
        Catch
            MsgBox("돈은 오로지 정수만 입력할 수 있습니다", vbCritical, "알림")
            Exit Sub
        End Try
        Dim PH As New PHClass
        PH.setMoney(playerMoney)
    End Sub

    Private Sub ParsePlayerSanity_Tick(sender As Object, e As EventArgs) Handles ParsePlayerSanity.Tick
        Dim PH As New PHClass
        SanityText.Text = PH.getPlayerSanity.ToString + "%"
    End Sub

    Private Sub JumpBar_Scroll(sender As Object, e As ScrollEventArgs) Handles JumpBar.Scroll
        JumpDistance = JumpBar.Value
    End Sub

    Private Sub GodModeToggle_CheckedChanged(sender As Object, e As EventArgs) Handles GodModeToggle.CheckedChanged
        Dim PH As New PHClass
        If GodModeToggle.Checked = True Then
            PH.setGodMode()
        ElseIf GodModeToggle.Checked = False Then
            PH.setUnGodMode()
        End If
    End Sub

    Private Sub ParseGhostInfo_Tick(sender As Object, e As EventArgs) Handles ParseGhostInfo.Tick
        On Error Resume Next
        Dim PH As New PHClass
        GhostNameLbl.Text = System.Text.Encoding.Unicode.GetString(PH.getGhostName)
        GhostAgeLbl.Text = PH.getGhostAge
        GhostRoomLbl.Text = System.Text.Encoding.Unicode.GetString(PH.getGhostRoom)
        GhostTypeLbl.Text = PH.getGhostType
        GhostSpeedLbl.Text = PH.getGhostSpeed
        GhostHuntLbl.Text = PH.IsGhostHunting
        If GhostHuntLbl.Text = 0 Then
            GhostHuntLbl.Text = "헌팅 활성화"
        ElseIf GhostHuntLbl.Text = 1 Then
            GhostHuntLbl.Text = "헌팅 비활성화"
        End If

        Select Case GhostTypeLbl.Text
            Case "스피릿"
                evidence1Lbl.Text = "EMF 5단계"
                evidence2Lbl.Text = "주파수 측정기"
                evidence3Lbl.Text = "고스트 라이팅"
            Case "레이스"
                evidence1Lbl.Text = "EMF 5단계"
                evidence2Lbl.Text = "주파수 측정기"
                evidence3Lbl.Text = "도트 프로젝터"
            Case "팬텀"
                evidence1Lbl.Text = "주파수 측정기"
                evidence2Lbl.Text = "손자국"
                evidence3Lbl.Text = "도트 프로젝터"
            Case "폴터가이스트"
                evidence1Lbl.Text = "주파수 측정기"
                evidence2Lbl.Text = "손자국"
                evidence3Lbl.Text = "고스트 라이팅"
            Case "밴시"
                evidence1Lbl.Text = "손자국"
                evidence2Lbl.Text = "고스트 오브"
                evidence3Lbl.Text = "도트 프로젝터"
            Case "진"
                evidence1Lbl.Text = "EMF 5단계"
                evidence2Lbl.Text = "손자국"
                evidence3Lbl.Text = "서늘함"
            Case "메어"
                evidence1Lbl.Text = "주파수 측정기"
                evidence2Lbl.Text = "고스트 오브"
                evidence3Lbl.Text = "고스트 라이팅"
            Case "레버넌트"
                evidence1Lbl.Text = "고스트 오브"
                evidence2Lbl.Text = "고스트 라이팅"
                evidence3Lbl.Text = "서늘함"
            Case "셰이드"
                evidence1Lbl.Text = "EMF 5단계"
                evidence2Lbl.Text = "고스트 라이팅"
                evidence3Lbl.Text = "서늘함"
            Case "데몬"
                evidence1Lbl.Text = "손자국"
                evidence2Lbl.Text = "고스트 라이팅"
                evidence3Lbl.Text = "서늘함"
            Case "유레이"
                evidence1Lbl.Text = "고스트 오브"
                evidence2Lbl.Text = "서늘함"
                evidence3Lbl.Text = "도트 프로젝터"
            Case "오니"
                evidence1Lbl.Text = "EMF 5단계"
                evidence2Lbl.Text = "서늘함"
                evidence3Lbl.Text = "도트 프로젝터"
            Case "한투"
                evidence1Lbl.Text = "손자국"
                evidence2Lbl.Text = "고스트 오브"
                evidence3Lbl.Text = "서늘함"
            Case "요괴"
                evidence1Lbl.Text = "주파수 측정기"
                evidence2Lbl.Text = "고스트 오브"
                evidence3Lbl.Text = "도트 프로젝터"
            Case "고료"
                evidence1Lbl.Text = "EMF 5단계"
                evidence2Lbl.Text = "손자국"
                evidence3Lbl.Text = "도트 프로젝터"
            Case "마일링"
                evidence1Lbl.Text = "EMF 5단계"
                evidence2Lbl.Text = "손자국"
                evidence3Lbl.Text = "고스트 라이팅"
        End Select
    End Sub

    Private Sub ghostInfoBTN_Click(sender As Object, e As EventArgs) Handles ghostInfoBTN.Click
        helpText.Clear()

        helpText.SelectionColor = MetroFramework.MetroColors.Red
        helpText.AppendText("고스트 네임 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 유령의 이름을 알 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Yellow
        helpText.AppendText("나이 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 유령의 나이를 알 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Pink
        helpText.AppendText("고스트 룸 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 유령의 방을 알 수 있습니다." + vbCrLf)

        helpText.SelectionColor = MetroFramework.MetroColors.Blue
        helpText.AppendText("고스트 타입 ")

        helpText.SelectionColor = MetroFramework.MetroColors.White
        helpText.AppendText(": 유령의 종류를 알 수 있습니다.")

    End Sub

    Private Sub PatchNoteBTN_Click(sender As Object, e As EventArgs) Handles PatchNoteBTN.Click
        PatchNote.Show()
    End Sub

    Private Sub jumpToggle_CheckedChanged(sender As Object, e As EventArgs) Handles jumpToggle.CheckedChanged

    End Sub

    Private Sub MetroLabel30_Click(sender As Object, e As EventArgs) Handles evidence2Lbl.Click

    End Sub

    Private Sub PlayerTab_Click(sender As Object, e As EventArgs) Handles PlayerTab.Click

    End Sub

    Private Sub GhostShowToggle_CheckedChanged(sender As Object, e As EventArgs) Handles GhostShowToggle.CheckedChanged
        Dim PH As New PHClass
        If GhostShowToggle.Checked = True Then
            PH.setGhostSound(1)
        ElseIf GhostShowToggle.Checked = False Then
            PH.setGhostSound(0)
        End If
    End Sub


    Private Sub difficult2BTN_Click(sender As Object, e As EventArgs) Handles difficult2BTN.Click
        Dim PH As New PHClass
        PH.setDifficult(1)
    End Sub

    Private Sub difficult3BTN_Click(sender As Object, e As EventArgs) Handles difficult3BTN.Click
        Dim PH As New PHClass
        PH.setDifficult(2)
    End Sub

    Private Sub YPosBTN_Leave(sender As Object, e As EventArgs) Handles YPosBTN.Leave
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub XposText_Leave(sender As Object, e As EventArgs) Handles XposText.Leave
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub MovPosBTN3_Click(sender As Object, e As EventArgs) Handles MovPosBTN3.Click
        Dim PH As New PHClass
        PH.setPlayerXPos(SavXpos3)
        PH.setPlayerYPos(SavYpos3)
        PH.setPlayerZPos(SavZpos3)
    End Sub

    Private Sub HoopButton_Click(sender As Object, e As EventArgs) Handles HoopButton.Click
    End Sub

    Private Sub ParsePositionTimer_Tick(sender As Object, e As EventArgs) Handles ParsePositionTimer.Tick
        Dim PH As New PHClass
        XposText.Text = PH.getPlayerXpos
        YposText.Text = PH.getPlayerYpos
        ZposText.Text = PH.getPlayerZpos

        If (XposText.Text = "0" And YposText.Text = "0" And ZposText.Text = "0") = False Then
            GameLoading = False
        ElseIf (XposText.Text = "0" And YposText.Text = "0" And ZposText.Text = "0") = True Then
            GameLoading = True
        End If
    End Sub
    Private Sub ZPosBTN_Click(sender As Object, e As EventArgs) Handles ZPosBTN.Click
        Try
            Convert.ToSingle(ZposText.Text)
        Catch
            MsgBox("위치는 정수 혹은 실수로만 입력할 수 있습니다.")
            Exit Sub
        End Try
        Dim PH As New PHClass
        PH.setPlayerZPos(ZposText.Text)
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub SavPosBTN1_Click(sender As Object, e As EventArgs) Handles SavPosBTN1.Click
        Dim PH As New PHClass

        SavXpos1 = PH.getPlayerXpos()
        SavYpos1 = PH.getPlayerYpos()
        SavZpos1 = PH.getPlayerZpos()
    End Sub

    Private Sub GrabBar_Scroll(sender As Object, e As ScrollEventArgs) Handles GrabBar.Scroll
        Dim PH As New PHClass
        PH.setGrabDistance(GrabBar.Value)
    End Sub
    Private Sub XposBTN_Click(sender As Object, e As EventArgs) Handles XposBTN.Click
        Try
            Convert.ToSingle(XposText.Text)
        Catch
            MsgBox("위치는 정수 혹은 실수로만 입력할 수 있습니다.")
            Exit Sub
        End Try
        Dim PH As New PHClass
        PH.setPlayerXPos(XposText.Text)
        ParsePositionTimer.Enabled = True
    End Sub

    Private Sub SetNameBTN_Click(sender As Object, e As EventArgs) Handles SetNameBTN.Click
        Dim PH As New PHClass
        PH.setPlayerName(NameText.Text)
    End Sub
End Class
