<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MetroFramework.Forms.MetroForm
    ' Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.ModMenuTab = New MetroFramework.Controls.MetroTabControl()
        Me.PlayerTab = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.jumpToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.TelPosToggle = New MetroFramework.Controls.MetroToggle()
        Me.JumpBar = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.SetNameBTN = New MetroFramework.Controls.MetroButton()
        Me.NameText = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.XposText = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.XposBTN = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.YposText = New MetroFramework.Controls.MetroTextBox()
        Me.MovPosBTN3 = New MetroFramework.Controls.MetroButton()
        Me.YPosBTN = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MovPosBTN2 = New MetroFramework.Controls.MetroButton()
        Me.ZposText = New MetroFramework.Controls.MetroTextBox()
        Me.ZPosBTN = New MetroFramework.Controls.MetroButton()
        Me.MovPosBTN1 = New MetroFramework.Controls.MetroButton()
        Me.SavPosBTN1 = New MetroFramework.Controls.MetroButton()
        Me.SavPosBTN2 = New MetroFramework.Controls.MetroButton()
        Me.SavPosBTN3 = New MetroFramework.Controls.MetroButton()
        Me.GhostInfoTab = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.evidence3Lbl = New MetroFramework.Controls.MetroLabel()
        Me.evidence2Lbl = New MetroFramework.Controls.MetroLabel()
        Me.evidence1Lbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.GhostHuntLbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.GhostSpeedLbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.GhostTypeLbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.GhostNameLbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.GhostAgeLbl = New MetroFramework.Controls.MetroLabel()
        Me.GhostRoomLbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.OptionTab = New MetroFramework.Controls.MetroTabPage()
        Me.KillProcBTN = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.bindingToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.GhostShowToggle = New MetroFramework.Controls.MetroToggle()
        Me.HelpTab = New MetroFramework.Controls.MetroTabPage()
        Me.ghostInfoBTN = New MetroFramework.Controls.MetroButton()
        Me.helpText = New System.Windows.Forms.RichTextBox()
        Me.thanksBTN = New MetroFramework.Controls.MetroButton()
        Me.optionBTN = New MetroFramework.Controls.MetroButton()
        Me.telBTN = New MetroFramework.Controls.MetroButton()
        Me.playerBTN = New MetroFramework.Controls.MetroButton()
        Me.ProgramTab = New MetroFramework.Controls.MetroTabPage()
        Me.PatchNoteBTN = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.UpdateBTN = New MetroFramework.Controls.MetroButton()
        Me.newverlbl = New MetroFramework.Controls.MetroLabel()
        Me.oldverlbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GodModeToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.moneysetBTN = New MetroFramework.Controls.MetroButton()
        Me.playerMoneyText = New MetroFramework.Controls.MetroTextBox()
        Me.SanityBTN = New MetroFramework.Controls.MetroButton()
        Me.SanityText = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.GrabBar = New MetroFramework.Controls.MetroTrackBar()
        Me.HoopButton = New MetroFramework.Controls.MetroButton()
        Me.HoopScore = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.SetLevelBTN = New MetroFramework.Controls.MetroButton()
        Me.LevelTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.yposresetBTN = New MetroFramework.Controls.MetroButton()
        Me.yposdownBTN = New MetroFramework.Controls.MetroButton()
        Me.yposupBTN = New MetroFramework.Controls.MetroButton()
        Me.gravPosToggle = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.RightTelBTN = New MetroFramework.Controls.MetroButton()
        Me.LeftTelBTN = New MetroFramework.Controls.MetroButton()
        Me.DownTelBTN = New MetroFramework.Controls.MetroButton()
        Me.UpTelBTN = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.difficult3BTN = New MetroFramework.Controls.MetroButton()
        Me.difficult2BTN = New MetroFramework.Controls.MetroButton()
        Me.difficult1BTN = New MetroFramework.Controls.MetroButton()
        Me.LevelNumeric = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.StateOnLbl = New MetroFramework.Controls.MetroLabel()
        Me.StateOffLbl = New MetroFramework.Controls.MetroLabel()
        Me.CheckGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ParsePositionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.KeyBindingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.열기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LoadingState1 = New MetroFramework.Controls.MetroLabel()
        Me.LoadingState2 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ParsePlayerSanity = New System.Windows.Forms.Timer(Me.components)
        Me.ParseGhostInfo = New System.Windows.Forms.Timer(Me.components)
        Me.ModMenuTab.SuspendLayout()
        Me.PlayerTab.SuspendLayout()
        Me.GhostInfoTab.SuspendLayout()
        Me.OptionTab.SuspendLayout()
        Me.HelpTab.SuspendLayout()
        Me.ProgramTab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LevelNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(43, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(165, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "PHASMOHUNTER"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(355, 40)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(70, 15)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "소지금 설정"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseStyleColors = True
        '
        'ModMenuTab
        '
        Me.ModMenuTab.Controls.Add(Me.PlayerTab)
        Me.ModMenuTab.Controls.Add(Me.GhostInfoTab)
        Me.ModMenuTab.Controls.Add(Me.OptionTab)
        Me.ModMenuTab.Controls.Add(Me.HelpTab)
        Me.ModMenuTab.Controls.Add(Me.ProgramTab)
        Me.ModMenuTab.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.ModMenuTab.Location = New System.Drawing.Point(7, 86)
        Me.ModMenuTab.Name = "ModMenuTab"
        Me.ModMenuTab.SelectedIndex = 0
        Me.ModMenuTab.Size = New System.Drawing.Size(238, 384)
        Me.ModMenuTab.Style = MetroFramework.MetroColorStyle.Red
        Me.ModMenuTab.TabIndex = 3
        Me.ModMenuTab.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ModMenuTab.UseSelectable = True
        '
        'PlayerTab
        '
        Me.PlayerTab.BackColor = System.Drawing.Color.Black
        Me.PlayerTab.Controls.Add(Me.MetroLabel12)
        Me.PlayerTab.Controls.Add(Me.jumpToggle)
        Me.PlayerTab.Controls.Add(Me.MetroLabel17)
        Me.PlayerTab.Controls.Add(Me.TelPosToggle)
        Me.PlayerTab.Controls.Add(Me.JumpBar)
        Me.PlayerTab.Controls.Add(Me.MetroLabel8)
        Me.PlayerTab.Controls.Add(Me.SetNameBTN)
        Me.PlayerTab.Controls.Add(Me.NameText)
        Me.PlayerTab.Controls.Add(Me.MetroLabel6)
        Me.PlayerTab.Controls.Add(Me.XposText)
        Me.PlayerTab.Controls.Add(Me.MetroLabel9)
        Me.PlayerTab.Controls.Add(Me.XposBTN)
        Me.PlayerTab.Controls.Add(Me.MetroLabel10)
        Me.PlayerTab.Controls.Add(Me.YposText)
        Me.PlayerTab.Controls.Add(Me.MovPosBTN3)
        Me.PlayerTab.Controls.Add(Me.YPosBTN)
        Me.PlayerTab.Controls.Add(Me.MetroLabel11)
        Me.PlayerTab.Controls.Add(Me.MovPosBTN2)
        Me.PlayerTab.Controls.Add(Me.ZposText)
        Me.PlayerTab.Controls.Add(Me.ZPosBTN)
        Me.PlayerTab.Controls.Add(Me.MovPosBTN1)
        Me.PlayerTab.Controls.Add(Me.SavPosBTN1)
        Me.PlayerTab.Controls.Add(Me.SavPosBTN2)
        Me.PlayerTab.Controls.Add(Me.SavPosBTN3)
        Me.PlayerTab.HorizontalScrollbarBarColor = True
        Me.PlayerTab.HorizontalScrollbarHighlightOnWheel = False
        Me.PlayerTab.HorizontalScrollbarSize = 10
        Me.PlayerTab.Location = New System.Drawing.Point(4, 38)
        Me.PlayerTab.Name = "PlayerTab"
        Me.PlayerTab.Size = New System.Drawing.Size(230, 342)
        Me.PlayerTab.TabIndex = 0
        Me.PlayerTab.Text = "플레이어"
        Me.PlayerTab.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PlayerTab.VerticalScrollbarBarColor = True
        Me.PlayerTab.VerticalScrollbarHighlightOnWheel = False
        Me.PlayerTab.VerticalScrollbarSize = 10
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel12.Location = New System.Drawing.Point(10, 313)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(73, 15)
        Me.MetroLabel12.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroLabel12.TabIndex = 29
        Me.MetroLabel12.Text = "축지법 기능 "
        Me.MetroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel12.UseStyleColors = True
        '
        'jumpToggle
        '
        Me.jumpToggle.AutoSize = True
        Me.jumpToggle.Location = New System.Drawing.Point(89, 61)
        Me.jumpToggle.Name = "jumpToggle"
        Me.jumpToggle.Size = New System.Drawing.Size(80, 16)
        Me.jumpToggle.Style = MetroFramework.MetroColorStyle.Red
        Me.jumpToggle.TabIndex = 45
        Me.jumpToggle.Text = "Off"
        Me.jumpToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.jumpToggle.UseSelectable = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel17.Location = New System.Drawing.Point(10, 61)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(58, 15)
        Me.MetroLabel17.Style = MetroFramework.MetroColorStyle.Magenta
        Me.MetroLabel17.TabIndex = 44
        Me.MetroLabel17.Text = "점프 기능"
        Me.MetroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel17.UseStyleColors = True
        '
        'TelPosToggle
        '
        Me.TelPosToggle.AutoSize = True
        Me.TelPosToggle.Location = New System.Drawing.Point(89, 312)
        Me.TelPosToggle.Name = "TelPosToggle"
        Me.TelPosToggle.Size = New System.Drawing.Size(80, 16)
        Me.TelPosToggle.Style = MetroFramework.MetroColorStyle.Red
        Me.TelPosToggle.TabIndex = 28
        Me.TelPosToggle.Text = "Off"
        Me.TelPosToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TelPosToggle.UseSelectable = True
        '
        'JumpBar
        '
        Me.JumpBar.BackColor = System.Drawing.Color.Transparent
        Me.JumpBar.Enabled = False
        Me.JumpBar.LargeChange = 10
        Me.JumpBar.Location = New System.Drawing.Point(80, 99)
        Me.JumpBar.Minimum = 1
        Me.JumpBar.Name = "JumpBar"
        Me.JumpBar.Size = New System.Drawing.Size(125, 10)
        Me.JumpBar.TabIndex = 16
        Me.JumpBar.Text = "MetroTrackBar1"
        Me.JumpBar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.JumpBar.Value = 30
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.Location = New System.Drawing.Point(10, 97)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(58, 15)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroLabel8.TabIndex = 15
        Me.MetroLabel8.Text = "점프 거리"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseStyleColors = True
        '
        'SetNameBTN
        '
        Me.SetNameBTN.ForeColor = System.Drawing.Color.Black
        Me.SetNameBTN.Location = New System.Drawing.Point(171, 20)
        Me.SetNameBTN.Name = "SetNameBTN"
        Me.SetNameBTN.Size = New System.Drawing.Size(36, 23)
        Me.SetNameBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.SetNameBTN.TabIndex = 13
        Me.SetNameBTN.Text = "Set"
        Me.SetNameBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SetNameBTN.UseSelectable = True
        Me.SetNameBTN.UseStyleColors = True
        '
        'NameText
        '
        '
        '
        '
        Me.NameText.CustomButton.Image = Nothing
        Me.NameText.CustomButton.Location = New System.Drawing.Point(63, 1)
        Me.NameText.CustomButton.Name = ""
        Me.NameText.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.NameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NameText.CustomButton.TabIndex = 1
        Me.NameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NameText.CustomButton.UseSelectable = True
        Me.NameText.CustomButton.Visible = False
        Me.NameText.Lines = New String() {"Name"}
        Me.NameText.Location = New System.Drawing.Point(80, 20)
        Me.NameText.MaxLength = 32767
        Me.NameText.Name = "NameText"
        Me.NameText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NameText.SelectedText = ""
        Me.NameText.SelectionLength = 0
        Me.NameText.SelectionStart = 0
        Me.NameText.ShortcutsEnabled = True
        Me.NameText.Size = New System.Drawing.Size(85, 23)
        Me.NameText.Style = MetroFramework.MetroColorStyle.Silver
        Me.NameText.TabIndex = 12
        Me.NameText.Text = "Name"
        Me.NameText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.NameText.UseSelectable = True
        Me.NameText.UseStyleColors = True
        Me.NameText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NameText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(10, 25)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(58, 15)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "네임 변경"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseStyleColors = True
        '
        'XposText
        '
        '
        '
        '
        Me.XposText.CustomButton.Image = Nothing
        Me.XposText.CustomButton.Location = New System.Drawing.Point(90, 1)
        Me.XposText.CustomButton.Name = ""
        Me.XposText.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.XposText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.XposText.CustomButton.TabIndex = 1
        Me.XposText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.XposText.CustomButton.UseSelectable = True
        Me.XposText.CustomButton.Visible = False
        Me.XposText.Lines = New String() {"0"}
        Me.XposText.Location = New System.Drawing.Point(53, 126)
        Me.XposText.MaxLength = 32767
        Me.XposText.Name = "XposText"
        Me.XposText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.XposText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.XposText.SelectedText = ""
        Me.XposText.SelectionLength = 0
        Me.XposText.SelectionStart = 0
        Me.XposText.ShortcutsEnabled = True
        Me.XposText.Size = New System.Drawing.Size(112, 23)
        Me.XposText.Style = MetroFramework.MetroColorStyle.Silver
        Me.XposText.TabIndex = 11
        Me.XposText.Text = "0"
        Me.XposText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.XposText.UseSelectable = True
        Me.XposText.UseStyleColors = True
        Me.XposText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.XposText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel9.Location = New System.Drawing.Point(13, 131)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(35, 15)
        Me.MetroLabel9.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel9.TabIndex = 2
        Me.MetroLabel9.Text = "X Pos"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel9.UseStyleColors = True
        '
        'XposBTN
        '
        Me.XposBTN.ForeColor = System.Drawing.Color.Black
        Me.XposBTN.Location = New System.Drawing.Point(172, 126)
        Me.XposBTN.Name = "XposBTN"
        Me.XposBTN.Size = New System.Drawing.Size(36, 23)
        Me.XposBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.XposBTN.TabIndex = 10
        Me.XposBTN.Text = "Set"
        Me.XposBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.XposBTN.UseSelectable = True
        Me.XposBTN.UseStyleColors = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.Location = New System.Drawing.Point(13, 163)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(34, 15)
        Me.MetroLabel10.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel10.TabIndex = 12
        Me.MetroLabel10.Text = "Y Pos"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel10.UseStyleColors = True
        '
        'YposText
        '
        '
        '
        '
        Me.YposText.CustomButton.Image = Nothing
        Me.YposText.CustomButton.Location = New System.Drawing.Point(90, 1)
        Me.YposText.CustomButton.Name = ""
        Me.YposText.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.YposText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.YposText.CustomButton.TabIndex = 1
        Me.YposText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.YposText.CustomButton.UseSelectable = True
        Me.YposText.CustomButton.Visible = False
        Me.YposText.Lines = New String() {"0"}
        Me.YposText.Location = New System.Drawing.Point(53, 160)
        Me.YposText.MaxLength = 32767
        Me.YposText.Name = "YposText"
        Me.YposText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.YposText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.YposText.SelectedText = ""
        Me.YposText.SelectionLength = 0
        Me.YposText.SelectionStart = 0
        Me.YposText.ShortcutsEnabled = True
        Me.YposText.Size = New System.Drawing.Size(112, 23)
        Me.YposText.Style = MetroFramework.MetroColorStyle.Silver
        Me.YposText.TabIndex = 13
        Me.YposText.Text = "0"
        Me.YposText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.YposText.UseSelectable = True
        Me.YposText.UseStyleColors = True
        Me.YposText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.YposText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MovPosBTN3
        '
        Me.MovPosBTN3.ForeColor = System.Drawing.Color.Black
        Me.MovPosBTN3.Location = New System.Drawing.Point(155, 273)
        Me.MovPosBTN3.Name = "MovPosBTN3"
        Me.MovPosBTN3.Size = New System.Drawing.Size(69, 23)
        Me.MovPosBTN3.Style = MetroFramework.MetroColorStyle.Orange
        Me.MovPosBTN3.TabIndex = 23
        Me.MovPosBTN3.Text = "위치 이동 3"
        Me.MovPosBTN3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MovPosBTN3.UseSelectable = True
        Me.MovPosBTN3.UseStyleColors = True
        '
        'YPosBTN
        '
        Me.YPosBTN.ForeColor = System.Drawing.Color.Black
        Me.YPosBTN.Location = New System.Drawing.Point(172, 160)
        Me.YPosBTN.Name = "YPosBTN"
        Me.YPosBTN.Size = New System.Drawing.Size(36, 23)
        Me.YPosBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.YPosBTN.TabIndex = 14
        Me.YPosBTN.Text = "Set"
        Me.YPosBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.YPosBTN.UseSelectable = True
        Me.YPosBTN.UseStyleColors = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.Location = New System.Drawing.Point(12, 198)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(35, 15)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel11.TabIndex = 15
        Me.MetroLabel11.Text = "Z Pos"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel11.UseStyleColors = True
        '
        'MovPosBTN2
        '
        Me.MovPosBTN2.ForeColor = System.Drawing.Color.Black
        Me.MovPosBTN2.Location = New System.Drawing.Point(80, 273)
        Me.MovPosBTN2.Name = "MovPosBTN2"
        Me.MovPosBTN2.Size = New System.Drawing.Size(69, 23)
        Me.MovPosBTN2.Style = MetroFramework.MetroColorStyle.Green
        Me.MovPosBTN2.TabIndex = 22
        Me.MovPosBTN2.Text = "위치 이동 2"
        Me.MovPosBTN2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MovPosBTN2.UseSelectable = True
        Me.MovPosBTN2.UseStyleColors = True
        '
        'ZposText
        '
        '
        '
        '
        Me.ZposText.CustomButton.Image = Nothing
        Me.ZposText.CustomButton.Location = New System.Drawing.Point(90, 1)
        Me.ZposText.CustomButton.Name = ""
        Me.ZposText.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.ZposText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ZposText.CustomButton.TabIndex = 1
        Me.ZposText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ZposText.CustomButton.UseSelectable = True
        Me.ZposText.CustomButton.Visible = False
        Me.ZposText.Lines = New String() {"0"}
        Me.ZposText.Location = New System.Drawing.Point(53, 195)
        Me.ZposText.MaxLength = 32767
        Me.ZposText.Name = "ZposText"
        Me.ZposText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ZposText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ZposText.SelectedText = ""
        Me.ZposText.SelectionLength = 0
        Me.ZposText.SelectionStart = 0
        Me.ZposText.ShortcutsEnabled = True
        Me.ZposText.Size = New System.Drawing.Size(112, 23)
        Me.ZposText.Style = MetroFramework.MetroColorStyle.Silver
        Me.ZposText.TabIndex = 16
        Me.ZposText.Text = "0"
        Me.ZposText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ZposText.UseSelectable = True
        Me.ZposText.UseStyleColors = True
        Me.ZposText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ZposText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ZPosBTN
        '
        Me.ZPosBTN.ForeColor = System.Drawing.Color.Black
        Me.ZPosBTN.Location = New System.Drawing.Point(172, 195)
        Me.ZPosBTN.Name = "ZPosBTN"
        Me.ZPosBTN.Size = New System.Drawing.Size(36, 23)
        Me.ZPosBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.ZPosBTN.TabIndex = 17
        Me.ZPosBTN.Text = "Set"
        Me.ZPosBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ZPosBTN.UseSelectable = True
        Me.ZPosBTN.UseStyleColors = True
        '
        'MovPosBTN1
        '
        Me.MovPosBTN1.ForeColor = System.Drawing.Color.Black
        Me.MovPosBTN1.Location = New System.Drawing.Point(5, 273)
        Me.MovPosBTN1.Name = "MovPosBTN1"
        Me.MovPosBTN1.Size = New System.Drawing.Size(69, 23)
        Me.MovPosBTN1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MovPosBTN1.TabIndex = 21
        Me.MovPosBTN1.Text = "위치 이동 1"
        Me.MovPosBTN1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MovPosBTN1.UseSelectable = True
        Me.MovPosBTN1.UseStyleColors = True
        '
        'SavPosBTN1
        '
        Me.SavPosBTN1.ForeColor = System.Drawing.Color.Black
        Me.SavPosBTN1.Location = New System.Drawing.Point(5, 244)
        Me.SavPosBTN1.Name = "SavPosBTN1"
        Me.SavPosBTN1.Size = New System.Drawing.Size(69, 23)
        Me.SavPosBTN1.Style = MetroFramework.MetroColorStyle.Blue
        Me.SavPosBTN1.TabIndex = 18
        Me.SavPosBTN1.Text = "위치 저장 1"
        Me.SavPosBTN1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SavPosBTN1.UseSelectable = True
        Me.SavPosBTN1.UseStyleColors = True
        '
        'SavPosBTN2
        '
        Me.SavPosBTN2.ForeColor = System.Drawing.Color.Black
        Me.SavPosBTN2.Location = New System.Drawing.Point(80, 244)
        Me.SavPosBTN2.Name = "SavPosBTN2"
        Me.SavPosBTN2.Size = New System.Drawing.Size(69, 23)
        Me.SavPosBTN2.Style = MetroFramework.MetroColorStyle.Green
        Me.SavPosBTN2.TabIndex = 19
        Me.SavPosBTN2.Text = "위치 저장 2"
        Me.SavPosBTN2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SavPosBTN2.UseSelectable = True
        Me.SavPosBTN2.UseStyleColors = True
        '
        'SavPosBTN3
        '
        Me.SavPosBTN3.ForeColor = System.Drawing.Color.Black
        Me.SavPosBTN3.Location = New System.Drawing.Point(155, 244)
        Me.SavPosBTN3.Name = "SavPosBTN3"
        Me.SavPosBTN3.Size = New System.Drawing.Size(69, 23)
        Me.SavPosBTN3.Style = MetroFramework.MetroColorStyle.Orange
        Me.SavPosBTN3.TabIndex = 20
        Me.SavPosBTN3.Text = "위치 저장 3"
        Me.SavPosBTN3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SavPosBTN3.UseSelectable = True
        Me.SavPosBTN3.UseStyleColors = True
        '
        'GhostInfoTab
        '
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel31)
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel30)
        Me.GhostInfoTab.Controls.Add(Me.evidence3Lbl)
        Me.GhostInfoTab.Controls.Add(Me.evidence2Lbl)
        Me.GhostInfoTab.Controls.Add(Me.evidence1Lbl)
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel29)
        Me.GhostInfoTab.Controls.Add(Me.GhostHuntLbl)
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel28)
        Me.GhostInfoTab.Controls.Add(Me.GhostSpeedLbl)
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel26)
        Me.GhostInfoTab.Controls.Add(Me.GhostTypeLbl)
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel23)
        Me.GhostInfoTab.Controls.Add(Me.GhostNameLbl)
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel27)
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel24)
        Me.GhostInfoTab.Controls.Add(Me.GhostAgeLbl)
        Me.GhostInfoTab.Controls.Add(Me.GhostRoomLbl)
        Me.GhostInfoTab.Controls.Add(Me.MetroLabel25)
        Me.GhostInfoTab.HorizontalScrollbarBarColor = True
        Me.GhostInfoTab.HorizontalScrollbarHighlightOnWheel = False
        Me.GhostInfoTab.HorizontalScrollbarSize = 10
        Me.GhostInfoTab.Location = New System.Drawing.Point(4, 38)
        Me.GhostInfoTab.Name = "GhostInfoTab"
        Me.GhostInfoTab.Size = New System.Drawing.Size(230, 342)
        Me.GhostInfoTab.TabIndex = 6
        Me.GhostInfoTab.Text = " 고스트 인포"
        Me.GhostInfoTab.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GhostInfoTab.VerticalScrollbarBarColor = True
        Me.GhostInfoTab.VerticalScrollbarHighlightOnWheel = False
        Me.GhostInfoTab.VerticalScrollbarSize = 10
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel31.Location = New System.Drawing.Point(12, 312)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(85, 15)
        Me.MetroLabel31.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel31.TabIndex = 59
        Me.MetroLabel31.Text = "고스트 증거 3 :"
        Me.MetroLabel31.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel31.UseStyleColors = True
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel30.Location = New System.Drawing.Point(12, 279)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(85, 15)
        Me.MetroLabel30.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel30.TabIndex = 58
        Me.MetroLabel30.Text = "고스트 증거 2 :"
        Me.MetroLabel30.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel30.UseStyleColors = True
        '
        'evidence3Lbl
        '
        Me.evidence3Lbl.AutoSize = True
        Me.evidence3Lbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.evidence3Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.evidence3Lbl.Location = New System.Drawing.Point(106, 312)
        Me.evidence3Lbl.Name = "evidence3Lbl"
        Me.evidence3Lbl.Size = New System.Drawing.Size(54, 15)
        Me.evidence3Lbl.Style = MetroFramework.MetroColorStyle.White
        Me.evidence3Lbl.TabIndex = 57
        Me.evidence3Lbl.Text = "evidence"
        Me.evidence3Lbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.evidence3Lbl.UseStyleColors = True
        '
        'evidence2Lbl
        '
        Me.evidence2Lbl.AutoSize = True
        Me.evidence2Lbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.evidence2Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.evidence2Lbl.Location = New System.Drawing.Point(106, 279)
        Me.evidence2Lbl.Name = "evidence2Lbl"
        Me.evidence2Lbl.Size = New System.Drawing.Size(54, 15)
        Me.evidence2Lbl.Style = MetroFramework.MetroColorStyle.White
        Me.evidence2Lbl.TabIndex = 56
        Me.evidence2Lbl.Text = "evidence"
        Me.evidence2Lbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.evidence2Lbl.UseStyleColors = True
        '
        'evidence1Lbl
        '
        Me.evidence1Lbl.AutoSize = True
        Me.evidence1Lbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.evidence1Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.evidence1Lbl.Location = New System.Drawing.Point(106, 247)
        Me.evidence1Lbl.Name = "evidence1Lbl"
        Me.evidence1Lbl.Size = New System.Drawing.Size(54, 15)
        Me.evidence1Lbl.Style = MetroFramework.MetroColorStyle.White
        Me.evidence1Lbl.TabIndex = 55
        Me.evidence1Lbl.Text = "evidence"
        Me.evidence1Lbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.evidence1Lbl.UseStyleColors = True
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel29.Location = New System.Drawing.Point(12, 247)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(83, 15)
        Me.MetroLabel29.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel29.TabIndex = 52
        Me.MetroLabel29.Text = "고스트 증거 1 :"
        Me.MetroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel29.UseStyleColors = True
        '
        'GhostHuntLbl
        '
        Me.GhostHuntLbl.AutoSize = True
        Me.GhostHuntLbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.GhostHuntLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.GhostHuntLbl.Location = New System.Drawing.Point(94, 210)
        Me.GhostHuntLbl.Name = "GhostHuntLbl"
        Me.GhostHuntLbl.Size = New System.Drawing.Size(42, 15)
        Me.GhostHuntLbl.Style = MetroFramework.MetroColorStyle.White
        Me.GhostHuntLbl.TabIndex = 51
        Me.GhostHuntLbl.Text = "IsHunt"
        Me.GhostHuntLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GhostHuntLbl.UseStyleColors = True
        '
        'MetroLabel28
        '
        Me.MetroLabel28.AutoSize = True
        Me.MetroLabel28.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel28.Location = New System.Drawing.Point(12, 210)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(76, 15)
        Me.MetroLabel28.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel28.TabIndex = 50
        Me.MetroLabel28.Text = "고스트 헌팅 :"
        Me.MetroLabel28.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel28.UseStyleColors = True
        '
        'GhostSpeedLbl
        '
        Me.GhostSpeedLbl.AutoSize = True
        Me.GhostSpeedLbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.GhostSpeedLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.GhostSpeedLbl.Location = New System.Drawing.Point(106, 171)
        Me.GhostSpeedLbl.Name = "GhostSpeedLbl"
        Me.GhostSpeedLbl.Size = New System.Drawing.Size(39, 15)
        Me.GhostSpeedLbl.Style = MetroFramework.MetroColorStyle.White
        Me.GhostSpeedLbl.TabIndex = 49
        Me.GhostSpeedLbl.Text = "Speed"
        Me.GhostSpeedLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GhostSpeedLbl.UseStyleColors = True
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel26.Location = New System.Drawing.Point(12, 171)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(88, 15)
        Me.MetroLabel26.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel26.TabIndex = 48
        Me.MetroLabel26.Text = "고스트 스피드 :"
        Me.MetroLabel26.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel26.UseStyleColors = True
        '
        'GhostTypeLbl
        '
        Me.GhostTypeLbl.AutoSize = True
        Me.GhostTypeLbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.GhostTypeLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.GhostTypeLbl.Location = New System.Drawing.Point(93, 132)
        Me.GhostTypeLbl.Name = "GhostTypeLbl"
        Me.GhostTypeLbl.Size = New System.Drawing.Size(31, 15)
        Me.GhostTypeLbl.Style = MetroFramework.MetroColorStyle.White
        Me.GhostTypeLbl.TabIndex = 37
        Me.GhostTypeLbl.Text = "Type"
        Me.GhostTypeLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GhostTypeLbl.UseStyleColors = True
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel23.Location = New System.Drawing.Point(12, 25)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(76, 15)
        Me.MetroLabel23.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel23.TabIndex = 30
        Me.MetroLabel23.Text = "고스트 네임 :"
        Me.MetroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel23.UseStyleColors = True
        '
        'GhostNameLbl
        '
        Me.GhostNameLbl.AutoSize = True
        Me.GhostNameLbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.GhostNameLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.GhostNameLbl.Location = New System.Drawing.Point(93, 25)
        Me.GhostNameLbl.Name = "GhostNameLbl"
        Me.GhostNameLbl.Size = New System.Drawing.Size(38, 15)
        Me.GhostNameLbl.Style = MetroFramework.MetroColorStyle.White
        Me.GhostNameLbl.TabIndex = 31
        Me.GhostNameLbl.Text = "Ghost"
        Me.GhostNameLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GhostNameLbl.UseStyleColors = True
        '
        'MetroLabel27
        '
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel27.Location = New System.Drawing.Point(12, 132)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(79, 15)
        Me.MetroLabel27.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel27.TabIndex = 36
        Me.MetroLabel27.Text = "고스트 타입 : "
        Me.MetroLabel27.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel27.UseStyleColors = True
        '
        'MetroLabel24
        '
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel24.Location = New System.Drawing.Point(12, 61)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(37, 15)
        Me.MetroLabel24.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel24.TabIndex = 32
        Me.MetroLabel24.Text = "나이 :"
        Me.MetroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel24.UseStyleColors = True
        '
        'GhostAgeLbl
        '
        Me.GhostAgeLbl.AutoSize = True
        Me.GhostAgeLbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.GhostAgeLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.GhostAgeLbl.Location = New System.Drawing.Point(55, 61)
        Me.GhostAgeLbl.Name = "GhostAgeLbl"
        Me.GhostAgeLbl.Size = New System.Drawing.Size(17, 15)
        Me.GhostAgeLbl.Style = MetroFramework.MetroColorStyle.White
        Me.GhostAgeLbl.TabIndex = 33
        Me.GhostAgeLbl.Text = "??"
        Me.GhostAgeLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GhostAgeLbl.UseStyleColors = True
        '
        'GhostRoomLbl
        '
        Me.GhostRoomLbl.AutoSize = True
        Me.GhostRoomLbl.FontSize = MetroFramework.MetroLabelSize.Small
        Me.GhostRoomLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.GhostRoomLbl.Location = New System.Drawing.Point(82, 96)
        Me.GhostRoomLbl.Name = "GhostRoomLbl"
        Me.GhostRoomLbl.Size = New System.Drawing.Size(35, 15)
        Me.GhostRoomLbl.Style = MetroFramework.MetroColorStyle.White
        Me.GhostRoomLbl.TabIndex = 35
        Me.GhostRoomLbl.Text = "Place"
        Me.GhostRoomLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GhostRoomLbl.UseStyleColors = True
        '
        'MetroLabel25
        '
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel25.Location = New System.Drawing.Point(12, 96)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(64, 15)
        Me.MetroLabel25.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroLabel25.TabIndex = 34
        Me.MetroLabel25.Text = "고스트 룸 :"
        Me.MetroLabel25.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel25.UseStyleColors = True
        '
        'OptionTab
        '
        Me.OptionTab.Controls.Add(Me.KillProcBTN)
        Me.OptionTab.Controls.Add(Me.MetroLabel13)
        Me.OptionTab.Controls.Add(Me.bindingToggle)
        Me.OptionTab.Controls.Add(Me.MetroLabel14)
        Me.OptionTab.Controls.Add(Me.GhostShowToggle)
        Me.OptionTab.HorizontalScrollbarBarColor = True
        Me.OptionTab.HorizontalScrollbarHighlightOnWheel = False
        Me.OptionTab.HorizontalScrollbarSize = 10
        Me.OptionTab.Location = New System.Drawing.Point(4, 38)
        Me.OptionTab.Name = "OptionTab"
        Me.OptionTab.Size = New System.Drawing.Size(230, 342)
        Me.OptionTab.TabIndex = 2
        Me.OptionTab.Text = "옵션"
        Me.OptionTab.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.OptionTab.VerticalScrollbarBarColor = True
        Me.OptionTab.VerticalScrollbarHighlightOnWheel = False
        Me.OptionTab.VerticalScrollbarSize = 10
        '
        'KillProcBTN
        '
        Me.KillProcBTN.ForeColor = System.Drawing.Color.Black
        Me.KillProcBTN.Location = New System.Drawing.Point(0, 305)
        Me.KillProcBTN.Name = "KillProcBTN"
        Me.KillProcBTN.Size = New System.Drawing.Size(227, 23)
        Me.KillProcBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.KillProcBTN.TabIndex = 39
        Me.KillProcBTN.Text = "게임 강제 종료"
        Me.KillProcBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.KillProcBTN.UseSelectable = True
        Me.KillProcBTN.UseStyleColors = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel13.Location = New System.Drawing.Point(3, 21)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(61, 15)
        Me.MetroLabel13.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel13.TabIndex = 31
        Me.MetroLabel13.Text = "키 바인딩 "
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel13.UseStyleColors = True
        '
        'bindingToggle
        '
        Me.bindingToggle.AutoSize = True
        Me.bindingToggle.Location = New System.Drawing.Point(73, 21)
        Me.bindingToggle.Name = "bindingToggle"
        Me.bindingToggle.Size = New System.Drawing.Size(80, 16)
        Me.bindingToggle.Style = MetroFramework.MetroColorStyle.Red
        Me.bindingToggle.TabIndex = 30
        Me.bindingToggle.Text = "Off"
        Me.bindingToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.bindingToggle.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel14.Location = New System.Drawing.Point(3, 61)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(100, 15)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel14.TabIndex = 47
        Me.MetroLabel14.Text = "유령 발소리 듣기 "
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel14.UseStyleColors = True
        '
        'GhostShowToggle
        '
        Me.GhostShowToggle.AutoSize = True
        Me.GhostShowToggle.Location = New System.Drawing.Point(110, 61)
        Me.GhostShowToggle.Name = "GhostShowToggle"
        Me.GhostShowToggle.Size = New System.Drawing.Size(80, 16)
        Me.GhostShowToggle.Style = MetroFramework.MetroColorStyle.Red
        Me.GhostShowToggle.TabIndex = 46
        Me.GhostShowToggle.Text = "Off"
        Me.GhostShowToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GhostShowToggle.UseSelectable = True
        '
        'HelpTab
        '
        Me.HelpTab.Controls.Add(Me.ghostInfoBTN)
        Me.HelpTab.Controls.Add(Me.helpText)
        Me.HelpTab.Controls.Add(Me.thanksBTN)
        Me.HelpTab.Controls.Add(Me.optionBTN)
        Me.HelpTab.Controls.Add(Me.telBTN)
        Me.HelpTab.Controls.Add(Me.playerBTN)
        Me.HelpTab.HorizontalScrollbarBarColor = True
        Me.HelpTab.HorizontalScrollbarHighlightOnWheel = False
        Me.HelpTab.HorizontalScrollbarSize = 10
        Me.HelpTab.Location = New System.Drawing.Point(4, 38)
        Me.HelpTab.Name = "HelpTab"
        Me.HelpTab.Size = New System.Drawing.Size(230, 342)
        Me.HelpTab.TabIndex = 3
        Me.HelpTab.Text = "도움말"
        Me.HelpTab.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.HelpTab.VerticalScrollbarBarColor = True
        Me.HelpTab.VerticalScrollbarHighlightOnWheel = False
        Me.HelpTab.VerticalScrollbarSize = 10
        '
        'ghostInfoBTN
        '
        Me.ghostInfoBTN.ForeColor = System.Drawing.Color.Black
        Me.ghostInfoBTN.Location = New System.Drawing.Point(141, 288)
        Me.ghostInfoBTN.Name = "ghostInfoBTN"
        Me.ghostInfoBTN.Size = New System.Drawing.Size(69, 23)
        Me.ghostInfoBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.ghostInfoBTN.TabIndex = 25
        Me.ghostInfoBTN.Text = "고스트 인포"
        Me.ghostInfoBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ghostInfoBTN.UseSelectable = True
        Me.ghostInfoBTN.UseStyleColors = True
        '
        'helpText
        '
        Me.helpText.BackColor = System.Drawing.Color.White
        Me.helpText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.helpText.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.helpText.Location = New System.Drawing.Point(0, 12)
        Me.helpText.Name = "helpText"
        Me.helpText.Size = New System.Drawing.Size(230, 260)
        Me.helpText.TabIndex = 24
        Me.helpText.Text = ""
        '
        'thanksBTN
        '
        Me.thanksBTN.ForeColor = System.Drawing.Color.Black
        Me.thanksBTN.Location = New System.Drawing.Point(117, 317)
        Me.thanksBTN.Name = "thanksBTN"
        Me.thanksBTN.Size = New System.Drawing.Size(55, 23)
        Me.thanksBTN.Style = MetroFramework.MetroColorStyle.Green
        Me.thanksBTN.TabIndex = 23
        Me.thanksBTN.Text = "Thanks"
        Me.thanksBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.thanksBTN.UseSelectable = True
        Me.thanksBTN.UseStyleColors = True
        '
        'optionBTN
        '
        Me.optionBTN.ForeColor = System.Drawing.Color.Black
        Me.optionBTN.Location = New System.Drawing.Point(52, 316)
        Me.optionBTN.Name = "optionBTN"
        Me.optionBTN.Size = New System.Drawing.Size(59, 23)
        Me.optionBTN.Style = MetroFramework.MetroColorStyle.Blue
        Me.optionBTN.TabIndex = 22
        Me.optionBTN.Text = "옵션"
        Me.optionBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.optionBTN.UseSelectable = True
        Me.optionBTN.UseStyleColors = True
        '
        'telBTN
        '
        Me.telBTN.ForeColor = System.Drawing.Color.Black
        Me.telBTN.Location = New System.Drawing.Point(82, 288)
        Me.telBTN.Name = "telBTN"
        Me.telBTN.Size = New System.Drawing.Size(55, 23)
        Me.telBTN.Style = MetroFramework.MetroColorStyle.Yellow
        Me.telBTN.TabIndex = 21
        Me.telBTN.Text = "텔레포트"
        Me.telBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.telBTN.UseSelectable = True
        Me.telBTN.UseStyleColors = True
        '
        'playerBTN
        '
        Me.playerBTN.ForeColor = System.Drawing.Color.Black
        Me.playerBTN.Location = New System.Drawing.Point(21, 288)
        Me.playerBTN.Name = "playerBTN"
        Me.playerBTN.Size = New System.Drawing.Size(55, 23)
        Me.playerBTN.Style = MetroFramework.MetroColorStyle.Pink
        Me.playerBTN.TabIndex = 20
        Me.playerBTN.Text = "플레이어"
        Me.playerBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.playerBTN.UseSelectable = True
        Me.playerBTN.UseStyleColors = True
        '
        'ProgramTab
        '
        Me.ProgramTab.Controls.Add(Me.PatchNoteBTN)
        Me.ProgramTab.Controls.Add(Me.MetroLabel19)
        Me.ProgramTab.Controls.Add(Me.UpdateBTN)
        Me.ProgramTab.Controls.Add(Me.newverlbl)
        Me.ProgramTab.Controls.Add(Me.oldverlbl)
        Me.ProgramTab.Controls.Add(Me.MetroLabel21)
        Me.ProgramTab.Controls.Add(Me.MetroLabel20)
        Me.ProgramTab.Controls.Add(Me.PictureBox2)
        Me.ProgramTab.HorizontalScrollbarBarColor = True
        Me.ProgramTab.HorizontalScrollbarHighlightOnWheel = False
        Me.ProgramTab.HorizontalScrollbarSize = 10
        Me.ProgramTab.Location = New System.Drawing.Point(4, 38)
        Me.ProgramTab.Name = "ProgramTab"
        Me.ProgramTab.Size = New System.Drawing.Size(230, 342)
        Me.ProgramTab.TabIndex = 4
        Me.ProgramTab.Text = "프로그램"
        Me.ProgramTab.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ProgramTab.VerticalScrollbarBarColor = True
        Me.ProgramTab.VerticalScrollbarHighlightOnWheel = False
        Me.ProgramTab.VerticalScrollbarSize = 10
        '
        'PatchNoteBTN
        '
        Me.PatchNoteBTN.ForeColor = System.Drawing.Color.Black
        Me.PatchNoteBTN.Location = New System.Drawing.Point(127, 287)
        Me.PatchNoteBTN.Name = "PatchNoteBTN"
        Me.PatchNoteBTN.Size = New System.Drawing.Size(91, 37)
        Me.PatchNoteBTN.Style = MetroFramework.MetroColorStyle.Yellow
        Me.PatchNoteBTN.TabIndex = 45
        Me.PatchNoteBTN.Text = "패치노트"
        Me.PatchNoteBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PatchNoteBTN.UseSelectable = True
        Me.PatchNoteBTN.UseStyleColors = True
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel19.Location = New System.Drawing.Point(54, 16)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(125, 25)
        Me.MetroLabel19.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroLabel19.TabIndex = 44
        Me.MetroLabel19.Text = "프로그램 정보"
        Me.MetroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel19.UseStyleColors = True
        '
        'UpdateBTN
        '
        Me.UpdateBTN.ForeColor = System.Drawing.Color.Black
        Me.UpdateBTN.Location = New System.Drawing.Point(12, 287)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(91, 37)
        Me.UpdateBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.UpdateBTN.TabIndex = 43
        Me.UpdateBTN.Text = "업데이트"
        Me.UpdateBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UpdateBTN.UseSelectable = True
        Me.UpdateBTN.UseStyleColors = True
        '
        'newverlbl
        '
        Me.newverlbl.AutoSize = True
        Me.newverlbl.Location = New System.Drawing.Point(135, 233)
        Me.newverlbl.Name = "newverlbl"
        Me.newverlbl.Size = New System.Drawing.Size(45, 19)
        Me.newverlbl.Style = MetroFramework.MetroColorStyle.Green
        Me.newverlbl.TabIndex = 13
        Me.newverlbl.Text = "0.0751"
        Me.newverlbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.newverlbl.UseStyleColors = True
        '
        'oldverlbl
        '
        Me.oldverlbl.AutoSize = True
        Me.oldverlbl.Location = New System.Drawing.Point(135, 200)
        Me.oldverlbl.Name = "oldverlbl"
        Me.oldverlbl.Size = New System.Drawing.Size(47, 19)
        Me.oldverlbl.Style = MetroFramework.MetroColorStyle.Blue
        Me.oldverlbl.TabIndex = 12
        Me.oldverlbl.Text = "0.0753"
        Me.oldverlbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.oldverlbl.UseStyleColors = True
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(51, 233)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel21.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel21.TabIndex = 11
        Me.MetroLabel21.Text = "최신 버전 : "
        Me.MetroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel21.UseStyleColors = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(51, 200)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel20.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel20.TabIndex = 10
        Me.MetroLabel20.Text = "현재 버전 : "
        Me.MetroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel20.UseStyleColors = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BackgroundImage = Global.PhasmoHunter.My.Resources.Resources.피눙물_black_ver___
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(32, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 122)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GodModeToggle
        '
        Me.GodModeToggle.AutoSize = True
        Me.GodModeToggle.Location = New System.Drawing.Point(434, 185)
        Me.GodModeToggle.Name = "GodModeToggle"
        Me.GodModeToggle.Size = New System.Drawing.Size(80, 16)
        Me.GodModeToggle.Style = MetroFramework.MetroColorStyle.Red
        Me.GodModeToggle.TabIndex = 52
        Me.GodModeToggle.Text = "Off"
        Me.GodModeToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GodModeToggle.UseSelectable = True
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel22.Location = New System.Drawing.Point(355, 186)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(58, 15)
        Me.MetroLabel22.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel22.TabIndex = 51
        Me.MetroLabel22.Text = "무적 모드"
        Me.MetroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel22.UseStyleColors = True
        '
        'moneysetBTN
        '
        Me.moneysetBTN.ForeColor = System.Drawing.Color.Black
        Me.moneysetBTN.Location = New System.Drawing.Point(493, 37)
        Me.moneysetBTN.Name = "moneysetBTN"
        Me.moneysetBTN.Size = New System.Drawing.Size(36, 23)
        Me.moneysetBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.moneysetBTN.TabIndex = 50
        Me.moneysetBTN.Text = "Set"
        Me.moneysetBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.moneysetBTN.UseSelectable = True
        Me.moneysetBTN.UseStyleColors = True
        '
        'playerMoneyText
        '
        '
        '
        '
        Me.playerMoneyText.CustomButton.Image = Nothing
        Me.playerMoneyText.CustomButton.Location = New System.Drawing.Point(24, 1)
        Me.playerMoneyText.CustomButton.Name = ""
        Me.playerMoneyText.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.playerMoneyText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.playerMoneyText.CustomButton.TabIndex = 1
        Me.playerMoneyText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.playerMoneyText.CustomButton.UseSelectable = True
        Me.playerMoneyText.CustomButton.Visible = False
        Me.playerMoneyText.Lines = New String() {"0"}
        Me.playerMoneyText.Location = New System.Drawing.Point(437, 37)
        Me.playerMoneyText.MaxLength = 32767
        Me.playerMoneyText.Name = "playerMoneyText"
        Me.playerMoneyText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.playerMoneyText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.playerMoneyText.SelectedText = ""
        Me.playerMoneyText.SelectionLength = 0
        Me.playerMoneyText.SelectionStart = 0
        Me.playerMoneyText.ShortcutsEnabled = True
        Me.playerMoneyText.Size = New System.Drawing.Size(46, 23)
        Me.playerMoneyText.Style = MetroFramework.MetroColorStyle.Silver
        Me.playerMoneyText.TabIndex = 49
        Me.playerMoneyText.Text = "0"
        Me.playerMoneyText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.playerMoneyText.UseSelectable = True
        Me.playerMoneyText.UseStyleColors = True
        Me.playerMoneyText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.playerMoneyText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'SanityBTN
        '
        Me.SanityBTN.ForeColor = System.Drawing.Color.Black
        Me.SanityBTN.Location = New System.Drawing.Point(498, 212)
        Me.SanityBTN.Name = "SanityBTN"
        Me.SanityBTN.Size = New System.Drawing.Size(36, 23)
        Me.SanityBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.SanityBTN.TabIndex = 48
        Me.SanityBTN.Text = "Set"
        Me.SanityBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SanityBTN.UseSelectable = True
        Me.SanityBTN.UseStyleColors = True
        '
        'SanityText
        '
        '
        '
        '
        Me.SanityText.CustomButton.Image = Nothing
        Me.SanityText.CustomButton.Location = New System.Drawing.Point(33, 1)
        Me.SanityText.CustomButton.Name = ""
        Me.SanityText.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.SanityText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SanityText.CustomButton.TabIndex = 1
        Me.SanityText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SanityText.CustomButton.UseSelectable = True
        Me.SanityText.CustomButton.Visible = False
        Me.SanityText.Lines = New String() {"0"}
        Me.SanityText.Location = New System.Drawing.Point(438, 212)
        Me.SanityText.MaxLength = 32767
        Me.SanityText.Name = "SanityText"
        Me.SanityText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SanityText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SanityText.SelectedText = ""
        Me.SanityText.SelectionLength = 0
        Me.SanityText.SelectionStart = 0
        Me.SanityText.ShortcutsEnabled = True
        Me.SanityText.Size = New System.Drawing.Size(55, 23)
        Me.SanityText.Style = MetroFramework.MetroColorStyle.Silver
        Me.SanityText.TabIndex = 47
        Me.SanityText.Text = "0"
        Me.SanityText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SanityText.UseSelectable = True
        Me.SanityText.UseStyleColors = True
        Me.SanityText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SanityText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel18.Location = New System.Drawing.Point(355, 215)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(70, 15)
        Me.MetroLabel18.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel18.TabIndex = 46
        Me.MetroLabel18.Text = "정신력 수치"
        Me.MetroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel18.UseStyleColors = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.Location = New System.Drawing.Point(355, 152)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(58, 15)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "그랩 거리"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseStyleColors = True
        '
        'GrabBar
        '
        Me.GrabBar.BackColor = System.Drawing.Color.Transparent
        Me.GrabBar.LargeChange = 1
        Me.GrabBar.Location = New System.Drawing.Point(425, 154)
        Me.GrabBar.Maximum = 50
        Me.GrabBar.Minimum = 1
        Me.GrabBar.MouseWheelBarPartitions = 5
        Me.GrabBar.Name = "GrabBar"
        Me.GrabBar.Size = New System.Drawing.Size(125, 10)
        Me.GrabBar.TabIndex = 11
        Me.GrabBar.Text = "MetroTrackBar1"
        Me.GrabBar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.GrabBar.Value = 1
        '
        'HoopButton
        '
        Me.HoopButton.ForeColor = System.Drawing.Color.Black
        Me.HoopButton.Location = New System.Drawing.Point(493, 113)
        Me.HoopButton.Name = "HoopButton"
        Me.HoopButton.Size = New System.Drawing.Size(36, 23)
        Me.HoopButton.Style = MetroFramework.MetroColorStyle.Red
        Me.HoopButton.TabIndex = 9
        Me.HoopButton.Text = "Set"
        Me.HoopButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.HoopButton.UseSelectable = True
        Me.HoopButton.UseStyleColors = True
        '
        'HoopScore
        '
        '
        '
        '
        Me.HoopScore.CustomButton.Image = Nothing
        Me.HoopScore.CustomButton.Location = New System.Drawing.Point(24, 1)
        Me.HoopScore.CustomButton.Name = ""
        Me.HoopScore.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.HoopScore.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.HoopScore.CustomButton.TabIndex = 1
        Me.HoopScore.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.HoopScore.CustomButton.UseSelectable = True
        Me.HoopScore.CustomButton.Visible = False
        Me.HoopScore.Lines = New String() {"0"}
        Me.HoopScore.Location = New System.Drawing.Point(437, 113)
        Me.HoopScore.MaxLength = 32767
        Me.HoopScore.Name = "HoopScore"
        Me.HoopScore.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HoopScore.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HoopScore.SelectedText = ""
        Me.HoopScore.SelectionLength = 0
        Me.HoopScore.SelectionStart = 0
        Me.HoopScore.ShortcutsEnabled = True
        Me.HoopScore.Size = New System.Drawing.Size(46, 23)
        Me.HoopScore.Style = MetroFramework.MetroColorStyle.Silver
        Me.HoopScore.TabIndex = 8
        Me.HoopScore.Text = "0"
        Me.HoopScore.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.HoopScore.UseSelectable = True
        Me.HoopScore.UseStyleColors = True
        Me.HoopScore.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HoopScore.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(355, 113)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(58, 15)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "농구 점수"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseStyleColors = True
        '
        'SetLevelBTN
        '
        Me.SetLevelBTN.ForeColor = System.Drawing.Color.Black
        Me.SetLevelBTN.Location = New System.Drawing.Point(493, 75)
        Me.SetLevelBTN.Name = "SetLevelBTN"
        Me.SetLevelBTN.Size = New System.Drawing.Size(36, 23)
        Me.SetLevelBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.SetLevelBTN.TabIndex = 6
        Me.SetLevelBTN.Text = "Set"
        Me.SetLevelBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SetLevelBTN.UseSelectable = True
        Me.SetLevelBTN.UseStyleColors = True
        '
        'LevelTextBox
        '
        '
        '
        '
        Me.LevelTextBox.CustomButton.Image = Nothing
        Me.LevelTextBox.CustomButton.Location = New System.Drawing.Point(24, 1)
        Me.LevelTextBox.CustomButton.Name = ""
        Me.LevelTextBox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.LevelTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LevelTextBox.CustomButton.TabIndex = 1
        Me.LevelTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LevelTextBox.CustomButton.UseSelectable = True
        Me.LevelTextBox.CustomButton.Visible = False
        Me.LevelTextBox.Lines = New String() {"0"}
        Me.LevelTextBox.Location = New System.Drawing.Point(437, 75)
        Me.LevelTextBox.MaxLength = 32767
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LevelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LevelTextBox.SelectedText = ""
        Me.LevelTextBox.SelectionLength = 0
        Me.LevelTextBox.SelectionStart = 0
        Me.LevelTextBox.ShortcutsEnabled = True
        Me.LevelTextBox.Size = New System.Drawing.Size(46, 23)
        Me.LevelTextBox.Style = MetroFramework.MetroColorStyle.Silver
        Me.LevelTextBox.TabIndex = 5
        Me.LevelTextBox.Text = "0"
        Me.LevelTextBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LevelTextBox.UseSelectable = True
        Me.LevelTextBox.UseStyleColors = True
        Me.LevelTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.LevelTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(354, 78)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(58, 15)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Brown
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "레벨 조정"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseStyleColors = True
        '
        'yposresetBTN
        '
        Me.yposresetBTN.ForeColor = System.Drawing.Color.Black
        Me.yposresetBTN.Location = New System.Drawing.Point(464, 334)
        Me.yposresetBTN.Name = "yposresetBTN"
        Me.yposresetBTN.Size = New System.Drawing.Size(29, 23)
        Me.yposresetBTN.Style = MetroFramework.MetroColorStyle.Magenta
        Me.yposresetBTN.TabIndex = 34
        Me.yposresetBTN.Text = "리셋"
        Me.yposresetBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.yposresetBTN.UseSelectable = True
        Me.yposresetBTN.UseStyleColors = True
        '
        'yposdownBTN
        '
        Me.yposdownBTN.ForeColor = System.Drawing.Color.Black
        Me.yposdownBTN.Location = New System.Drawing.Point(430, 334)
        Me.yposdownBTN.Name = "yposdownBTN"
        Me.yposdownBTN.Size = New System.Drawing.Size(29, 23)
        Me.yposdownBTN.Style = MetroFramework.MetroColorStyle.Magenta
        Me.yposdownBTN.TabIndex = 33
        Me.yposdownBTN.Text = "z축↓"
        Me.yposdownBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.yposdownBTN.UseSelectable = True
        Me.yposdownBTN.UseStyleColors = True
        '
        'yposupBTN
        '
        Me.yposupBTN.ForeColor = System.Drawing.Color.Black
        Me.yposupBTN.Location = New System.Drawing.Point(395, 334)
        Me.yposupBTN.Name = "yposupBTN"
        Me.yposupBTN.Size = New System.Drawing.Size(29, 23)
        Me.yposupBTN.Style = MetroFramework.MetroColorStyle.Magenta
        Me.yposupBTN.TabIndex = 32
        Me.yposupBTN.Text = "z축↑"
        Me.yposupBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.yposupBTN.UseSelectable = True
        Me.yposupBTN.UseStyleColors = True
        '
        'gravPosToggle
        '
        Me.gravPosToggle.AutoSize = True
        Me.gravPosToggle.Location = New System.Drawing.Point(445, 304)
        Me.gravPosToggle.Name = "gravPosToggle"
        Me.gravPosToggle.Size = New System.Drawing.Size(80, 16)
        Me.gravPosToggle.Style = MetroFramework.MetroColorStyle.Red
        Me.gravPosToggle.TabIndex = 31
        Me.gravPosToggle.Text = "Off"
        Me.gravPosToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.gravPosToggle.UseSelectable = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel16.Location = New System.Drawing.Point(355, 305)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(88, 15)
        Me.MetroLabel16.Style = MetroFramework.MetroColorStyle.Magenta
        Me.MetroLabel16.TabIndex = 30
        Me.MetroLabel16.Text = "공중부양 기능 :"
        Me.MetroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel16.UseStyleColors = True
        '
        'RightTelBTN
        '
        Me.RightTelBTN.ForeColor = System.Drawing.Color.Black
        Me.RightTelBTN.Location = New System.Drawing.Point(478, 254)
        Me.RightTelBTN.Name = "RightTelBTN"
        Me.RightTelBTN.Size = New System.Drawing.Size(29, 23)
        Me.RightTelBTN.Style = MetroFramework.MetroColorStyle.Pink
        Me.RightTelBTN.TabIndex = 27
        Me.RightTelBTN.Text = "x축↓"
        Me.RightTelBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.RightTelBTN.UseSelectable = True
        Me.RightTelBTN.UseStyleColors = True
        '
        'LeftTelBTN
        '
        Me.LeftTelBTN.ForeColor = System.Drawing.Color.Black
        Me.LeftTelBTN.Location = New System.Drawing.Point(443, 254)
        Me.LeftTelBTN.Name = "LeftTelBTN"
        Me.LeftTelBTN.Size = New System.Drawing.Size(29, 23)
        Me.LeftTelBTN.Style = MetroFramework.MetroColorStyle.Pink
        Me.LeftTelBTN.TabIndex = 26
        Me.LeftTelBTN.Text = "x축↑"
        Me.LeftTelBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LeftTelBTN.UseSelectable = True
        Me.LeftTelBTN.UseStyleColors = True
        '
        'DownTelBTN
        '
        Me.DownTelBTN.ForeColor = System.Drawing.Color.Black
        Me.DownTelBTN.Location = New System.Drawing.Point(408, 254)
        Me.DownTelBTN.Name = "DownTelBTN"
        Me.DownTelBTN.Size = New System.Drawing.Size(29, 23)
        Me.DownTelBTN.Style = MetroFramework.MetroColorStyle.Pink
        Me.DownTelBTN.TabIndex = 25
        Me.DownTelBTN.Text = "y축↓"
        Me.DownTelBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.DownTelBTN.UseSelectable = True
        Me.DownTelBTN.UseStyleColors = True
        '
        'UpTelBTN
        '
        Me.UpTelBTN.ForeColor = System.Drawing.Color.Black
        Me.UpTelBTN.Location = New System.Drawing.Point(373, 254)
        Me.UpTelBTN.Name = "UpTelBTN"
        Me.UpTelBTN.Size = New System.Drawing.Size(29, 23)
        Me.UpTelBTN.Style = MetroFramework.MetroColorStyle.Pink
        Me.UpTelBTN.TabIndex = 24
        Me.UpTelBTN.Text = "y축↑"
        Me.UpTelBTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UpTelBTN.UseSelectable = True
        Me.UpTelBTN.UseStyleColors = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel15.Location = New System.Drawing.Point(355, 402)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(70, 15)
        Me.MetroLabel15.Style = MetroFramework.MetroColorStyle.Magenta
        Me.MetroLabel15.TabIndex = 45
        Me.MetroLabel15.Text = "난이도 설정"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel15.UseStyleColors = True
        '
        'difficult3BTN
        '
        Me.difficult3BTN.ForeColor = System.Drawing.Color.Black
        Me.difficult3BTN.Location = New System.Drawing.Point(534, 394)
        Me.difficult3BTN.Name = "difficult3BTN"
        Me.difficult3BTN.Size = New System.Drawing.Size(46, 23)
        Me.difficult3BTN.Style = MetroFramework.MetroColorStyle.Red
        Me.difficult3BTN.TabIndex = 44
        Me.difficult3BTN.Text = "전문가"
        Me.difficult3BTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.difficult3BTN.UseSelectable = True
        Me.difficult3BTN.UseStyleColors = True
        '
        'difficult2BTN
        '
        Me.difficult2BTN.ForeColor = System.Drawing.Color.Black
        Me.difficult2BTN.Location = New System.Drawing.Point(483, 394)
        Me.difficult2BTN.Name = "difficult2BTN"
        Me.difficult2BTN.Size = New System.Drawing.Size(46, 23)
        Me.difficult2BTN.Style = MetroFramework.MetroColorStyle.Yellow
        Me.difficult2BTN.TabIndex = 43
        Me.difficult2BTN.Text = "중급자"
        Me.difficult2BTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.difficult2BTN.UseSelectable = True
        Me.difficult2BTN.UseStyleColors = True
        '
        'difficult1BTN
        '
        Me.difficult1BTN.ForeColor = System.Drawing.Color.Black
        Me.difficult1BTN.Location = New System.Drawing.Point(431, 394)
        Me.difficult1BTN.Name = "difficult1BTN"
        Me.difficult1BTN.Size = New System.Drawing.Size(46, 23)
        Me.difficult1BTN.Style = MetroFramework.MetroColorStyle.Green
        Me.difficult1BTN.TabIndex = 42
        Me.difficult1BTN.Text = "초보자"
        Me.difficult1BTN.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.difficult1BTN.UseSelectable = True
        Me.difficult1BTN.UseStyleColors = True
        '
        'LevelNumeric
        '
        Me.LevelNumeric.Location = New System.Drawing.Point(686, 86)
        Me.LevelNumeric.Name = "LevelNumeric"
        Me.LevelNumeric.Size = New System.Drawing.Size(68, 21)
        Me.LevelNumeric.TabIndex = 4
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(73, 477)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Game State : "
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseStyleColors = True
        '
        'StateOnLbl
        '
        Me.StateOnLbl.AutoSize = True
        Me.StateOnLbl.Location = New System.Drawing.Point(156, 477)
        Me.StateOnLbl.Name = "StateOnLbl"
        Me.StateOnLbl.Size = New System.Drawing.Size(30, 19)
        Me.StateOnLbl.Style = MetroFramework.MetroColorStyle.Green
        Me.StateOnLbl.TabIndex = 4
        Me.StateOnLbl.Text = "ON"
        Me.StateOnLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.StateOnLbl.UseStyleColors = True
        '
        'StateOffLbl
        '
        Me.StateOffLbl.AutoSize = True
        Me.StateOffLbl.Location = New System.Drawing.Point(156, 477)
        Me.StateOffLbl.Name = "StateOffLbl"
        Me.StateOffLbl.Size = New System.Drawing.Size(34, 19)
        Me.StateOffLbl.Style = MetroFramework.MetroColorStyle.Red
        Me.StateOffLbl.TabIndex = 5
        Me.StateOffLbl.Text = "OFF"
        Me.StateOffLbl.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.StateOffLbl.UseStyleColors = True
        '
        'CheckGameTimer
        '
        '
        'ParsePositionTimer
        '
        '
        'KeyBindingTimer
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "PhasmoHunter TrayMode"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.열기ToolStripMenuItem, Me.종료ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(99, 48)
        '
        '열기ToolStripMenuItem
        '
        Me.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem"
        Me.열기ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.열기ToolStripMenuItem.Text = "열기"
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.종료ToolStripMenuItem.Text = "종료"
        '
        'AuthTimer
        '
        Me.AuthTimer.Interval = 60000
        '
        'LoadingState1
        '
        Me.LoadingState1.AutoSize = True
        Me.LoadingState1.Location = New System.Drawing.Point(54, 473)
        Me.LoadingState1.Name = "LoadingState1"
        Me.LoadingState1.Size = New System.Drawing.Size(88, 19)
        Me.LoadingState1.Style = MetroFramework.MetroColorStyle.Silver
        Me.LoadingState1.TabIndex = 7
        Me.LoadingState1.Text = "Game State : "
        Me.LoadingState1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LoadingState1.UseStyleColors = True
        '
        'LoadingState2
        '
        Me.LoadingState2.AutoSize = True
        Me.LoadingState2.Location = New System.Drawing.Point(138, 473)
        Me.LoadingState2.Name = "LoadingState2"
        Me.LoadingState2.Size = New System.Drawing.Size(62, 19)
        Me.LoadingState2.Style = MetroFramework.MetroColorStyle.Green
        Me.LoadingState2.TabIndex = 8
        Me.LoadingState2.Text = "Loading.."
        Me.LoadingState2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LoadingState2.UseStyleColors = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PhasmoHunter.My.Resources.Resources.header1
        Me.PictureBox1.Location = New System.Drawing.Point(7, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ParsePlayerSanity
        '
        '
        'ParseGhostInfo
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 500)
        Me.Controls.Add(Me.LoadingState2)
        Me.Controls.Add(Me.SanityBTN)
        Me.Controls.Add(Me.GodModeToggle)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.difficult3BTN)
        Me.Controls.Add(Me.SanityText)
        Me.Controls.Add(Me.difficult2BTN)
        Me.Controls.Add(Me.yposresetBTN)
        Me.Controls.Add(Me.difficult1BTN)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.MetroLabel22)
        Me.Controls.Add(Me.RightTelBTN)
        Me.Controls.Add(Me.LoadingState1)
        Me.Controls.Add(Me.moneysetBTN)
        Me.Controls.Add(Me.yposdownBTN)
        Me.Controls.Add(Me.LeftTelBTN)
        Me.Controls.Add(Me.playerMoneyText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DownTelBTN)
        Me.Controls.Add(Me.yposupBTN)
        Me.Controls.Add(Me.StateOffLbl)
        Me.Controls.Add(Me.gravPosToggle)
        Me.Controls.Add(Me.UpTelBTN)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.StateOnLbl)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.GrabBar)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.ModMenuTab)
        Me.Controls.Add(Me.LevelNumeric)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.LevelTextBox)
        Me.Controls.Add(Me.HoopButton)
        Me.Controls.Add(Me.SetLevelBTN)
        Me.Controls.Add(Me.HoopScore)
        Me.Controls.Add(Me.MetroLabel5)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Opacity = 0.7R
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "PhasmoHunter"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TopMost = True
        Me.ModMenuTab.ResumeLayout(False)
        Me.PlayerTab.ResumeLayout(False)
        Me.PlayerTab.PerformLayout()
        Me.GhostInfoTab.ResumeLayout(False)
        Me.GhostInfoTab.PerformLayout()
        Me.OptionTab.ResumeLayout(False)
        Me.OptionTab.PerformLayout()
        Me.HelpTab.ResumeLayout(False)
        Me.ProgramTab.ResumeLayout(False)
        Me.ProgramTab.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LevelNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ModMenuTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PlayerTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents StateOnLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents StateOffLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents CheckGameTimer As Timer
    Friend WithEvents LevelNumeric As NumericUpDown
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LevelTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents SetLevelBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents HoopButton As MetroFramework.Controls.MetroButton
    Friend WithEvents HoopScore As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GrabBar As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SetNameBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents NameText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents JumpBar As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents XposText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents XposBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents ParsePositionTimer As Timer
    Friend WithEvents YPosBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents YposText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ZPosBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents ZposText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MovPosBTN3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MovPosBTN2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MovPosBTN1 As MetroFramework.Controls.MetroButton
    Friend WithEvents SavPosBTN3 As MetroFramework.Controls.MetroButton
    Friend WithEvents SavPosBTN2 As MetroFramework.Controls.MetroButton
    Friend WithEvents SavPosBTN1 As MetroFramework.Controls.MetroButton
    Friend WithEvents UpTelBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents RightTelBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents LeftTelBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents DownTelBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents TelPosToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents OptionTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents KeyBindingTimer As Timer
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents bindingToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 열기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KillProcBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents HelpTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents playerBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents thanksBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents optionBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents telBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents helpText As RichTextBox
    Friend WithEvents AuthTimer As Timer
    Friend WithEvents gravPosToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents yposdownBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents yposupBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents yposresetBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents jumpToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents difficult3BTN As MetroFramework.Controls.MetroButton
    Friend WithEvents difficult2BTN As MetroFramework.Controls.MetroButton
    Friend WithEvents difficult1BTN As MetroFramework.Controls.MetroButton
    Friend WithEvents LoadingState1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingState2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents SanityBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents SanityText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProgramTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UpdateBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents newverlbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents oldverlbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents moneysetBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents playerMoneyText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ParsePlayerSanity As Timer
    Friend WithEvents GodModeToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GhostShowToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GhostNameLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents ParseGhostInfo As Timer
    Friend WithEvents GhostTypeLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GhostRoomLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GhostAgeLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ghostInfoBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents PatchNoteBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents GhostInfoTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GhostHuntLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GhostSpeedLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents evidence1Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents evidence2Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents evidence3Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
End Class
