Imports PhasmoHunter.Memory_Address
Imports Memory
Public Class PHClass
    Private ReadMoney1, ReadMoney2, ReadMoney3, ReadMoney4, ReadMoney5, ReadMoney6 As Integer
    Private m As Mem = New Mem()
    Public Sub New()
        m.OpenProcess("PhasmoPhobia.exe")
    End Sub
    ''' <summary>
    ''' PhasmoPhobia의 프로세스 상태를 반환합니다.
    ''' </summary>  
    Public Overridable Function getGameState() As Boolean
        Return m.OpenProcess("PhasmoPhobia.exe")
    End Function
    ''' <summary>
    ''' 현재 플레이어의 소지금을 반환합니다.
    ''' </summary>
    Public Overridable Function getMoney() As Integer
        Return m.ReadInt(Money_Address)
    End Function
    ''' <summary>
    ''' 현재 플레이어의 소지금을 입력받은 정수 값으로 변경합니다.
    ''' </summary>
    Public Sub setMoney(ByVal value As Integer)
        m.WriteMemory(Money_Address, "Int", value)
    End Sub
    ''' <summary>
    ''' 현재 플레이어의 정신력 수치를 반환합니다.
    ''' </summary>
    Public Overridable Function getPlayerSanity() As Single
        Dim PlayerSanity As Single = m.ReadFloat(MP_Sanity)
        Dim Sanity_Percent As Single = 100 - PlayerSanity
        Return Sanity_Percent
    End Function
    ''' <summary>
    ''' 현재 플레이어의 정신력을 입력받은 정수 값으로 변경합니다.
    ''' </summary>
    Public Sub setPlayerSanity(ByVal value As Integer)
        Dim CalculValue As Integer = 100 - value
        m.WriteMemory(MP_Sanity, "Float", CalculValue)
    End Sub
    ''' <summary>
    ''' 현재 플레이어의 레벨을 반환합니다.
    ''' </summary>
    Public Overridable Function getLevel() As Integer
        Return m.ReadInt(Level_Address)
    End Function
    ''' <summary>
    ''' 현재 플레이어의 레벨을 입력받은 정수 값으로 변경합니다.
    ''' </summary>
    Public Sub setLevel(ByVal value As Integer)
        m.WriteMemory(Level_Address, "Int", value)
    End Sub
    ''' <summary>
    ''' 현재 플레이어의 닉네임을 빈 값으로 설정합니다.
    ''' </summary>
    Public Sub removePlayerName()
        m.WriteMemory(MP_NameLength, "Int", 0)
        m.WriteMemory(MP_Name, "String", "          ", , stringEncoding:=System.Text.Encoding.Unicode)
    End Sub
    ''' <summary>
    ''' 현재 플레이어의 닉네임을 입력받은 문자열 값으로 변경합니다.
    ''' </summary>
    Public Sub setPlayerName(ByVal value As String)
        m.WriteMemory(MP_NameLength, "Int", value.Length)
        m.WriteMemory(MP_Name, "String", value, , stringEncoding:=System.Text.Encoding.Unicode)
    End Sub
    ''' <summary>
    ''' 현재 플레이어의 그랩 거리를 반환합니다.
    ''' </summary>
    Public Overridable Function getGrabDistance() As Single
        Return m.ReadFloat(GrabDistance_Address)
    End Function
    ''' <summary>
    ''' 현재 플레이어의 그랩 거리를 입력받은 정수 값으로 변경합니다.
    ''' </summary>
    Public Sub setGrabDistance(ByVal value As Integer)
        m.WriteMemory(GrabDistance_Address, "Float", value)
    End Sub
    ''' <summary>
    ''' 유령의 발소리를 설정합니다. (1 = 발소리 듣기, 0 = 발소리 듣지 않기)
    ''' </summary>
    Public Sub setGhostSound(ByVal value As Integer)
        If value = 0 Then
            m.UnfreezeValue(GhostFootSound_Address)
        ElseIf value = 1 Then
            m.FreezeValue(GhostFootSound_Address, "Byte", value)
        End If
    End Sub
    ''' <summary>
    ''' PhasmoPhobia의 중력을 조작해 점프 기능을 이용할 수 있게 합니다.
    ''' </summary>
    Public Sub setJump()
        Dim current_Zpos As Single = m.ReadFloat(Player_ZPos_Address)
        current_Zpos = current_Zpos + 0.2
        m.FreezeValue(Player_ZPos_Address, "Float", current_Zpos)
        Threading.Thread.Sleep(1000)
        m.UnfreezeValue(Player_ZPos_Address)
#Region "Old Code"
        'm.WriteMemory(GroundForce_1_Address, "Float", -5)
        'm.WriteMemory(GroundForce_2_Address, "Float", -5)
        'm.WriteMemory(GroundForce_3_Address, "Float", -5)
        'm.WriteMemory(GroundForce_4_Address, "Float", -5)
        'm.WriteMemory(GroundForce_5_Address, "Float", -5)
        'm.WriteMemory(GroundForce_6_Address, "Float", -5)
        'System.Threading.Thread.Sleep(250)
        'm.WriteMemory(GroundForce_1_Address, "Float", 100)
        'm.WriteMemory(GroundForce_2_Address, "Float", 100)
        'm.WriteMemory(GroundForce_3_Address, "Float", 100)
        'm.WriteMemory(GroundForce_4_Address, "Float", 100)
        'm.WriteMemory(GroundForce_5_Address, "Float", 100)
        'm.WriteMemory(GroundForce_6_Address, "Float", 100)
#End Region
    End Sub
    ''' <summary>
    ''' 점프할 수 있는 거리를 입력받은 정수 값으로 변경합니다.
    ''' </summary>
    Public Sub setPlayerJump(ByVal value As Integer)
        Dim current_Zpos As Single = m.ReadFloat(Player_ZPos_Address)
        Dim Add_Zpos As Single = (value / 100)
        current_Zpos = current_Zpos + Add_Zpos
        m.FreezeValue(Player_ZPos_Address, "Float", current_Zpos)
        Threading.Thread.Sleep(200)
        m.UnfreezeValue(Player_ZPos_Address)
#Region "Old Code"
        'm.WriteMemory(GroundForce_1_Address, "Float", 0 - value)
        'm.WriteMemory(GroundForce_2_Address, "Float", 0 - value)
        'm.WriteMemory(GroundForce_3_Address, "Float", 0 - value)
        'm.WriteMemory(GroundForce_4_Address, "Float", 0 - value)
        'm.WriteMemory(GroundForce_5_Address, "Float", 0 - value)
        'm.WriteMemory(GroundForce_6_Address, "Float", 0 - value)
        'System.Threading.Thread.Sleep(250)
        'm.WriteMemory(GroundForce_1_Address, "Float", 100)
        'm.WriteMemory(GroundForce_2_Address, "Float", 100)
        'm.WriteMemory(GroundForce_3_Address, "Float", 100)
        'm.WriteMemory(GroundForce_4_Address, "Float", 100)
        'm.WriteMemory(GroundForce_5_Address, "Float", 100)
        'm.WriteMemory(GroundForce_6_Address, "Float", 100)
#End Region
    End Sub
    ''' <summary>
    ''' PhasmoPhobia의 중력을 입력받은 Float형태의 실수 값으로 변경합니다. (기본값은 2입니다.)
    ''' </summary>
    Public Sub setGravity(ByVal value As Single)
        m.WriteMemory(Gravity_Multiplier_1_Address, "Float", value)
        m.WriteMemory(Gravity_Multiplier_2_Address, "Float", value)
        m.WriteMemory(Gravity_Multiplier_3_Address, "Float", value)
        m.WriteMemory(Gravity_Multiplier_4_Address, "Float", value)
        m.WriteMemory(Gravity_Multiplier_5_Address, "Float", value)
    End Sub
    ''' <summary>
    ''' PhasmoPhobia의 땅으로부터의 충격량을 입력받은 Float형태의 실수 값으로 변경합니다. (기본값은 100입니다.)
    ''' </summary>
    Public Sub setGroundForce(ByVal value As Single)
        m.WriteMemory(GroundForce_1_Address, "Float", value)
        m.WriteMemory(GroundForce_2_Address, "Float", value)
        m.WriteMemory(GroundForce_3_Address, "Float", value)
        m.WriteMemory(GroundForce_4_Address, "Float", value)
        m.WriteMemory(GroundForce_5_Address, "Float", value)
        m.WriteMemory(GroundForce_6_Address, "Float", value)
    End Sub
    ''' <summary>
    ''' 현재 플레이어의 x좌표 값을 반환합니다.
    ''' </summary>
    Public Overridable Function getPlayerXpos() As Single
        Return m.ReadFloat(Player_XPos_Address)
    End Function
    ''' <summary>
    ''' 현재 플레이어의 x좌표 값을 입력받은 Float형태의 실수 값으로 변경합니다.
    ''' </summary>
    Public Sub setPlayerXPos(ByVal value As Single)
        m.WriteMemory(Player_XPos_Address, "Float", value)
    End Sub
    ''' <summary>
    ''' 현재 플레이어의 y좌표 값을 반환합니다.
    ''' </summary>
    Public Overridable Function getPlayerYpos() As Single
        Return m.ReadFloat(Player_YPos_Address)
    End Function
    ''' <summary>
    ''' 현재 플레이어의 y좌표 값을 입력받은 Float형태의 실수 값으로 변경합니다. PhasmoPhobia 에서의 Y값은 수학에서의 Z값입니다.
    ''' </summary>
    Public Sub setPlayerYPos(ByVal value As Single)
        m.WriteMemory(Player_YPos_Address, "Float", value)
    End Sub
    ''' <summary>
    ''' 현재 플레이어의 z좌표 값을 반환합니다.
    ''' </summary>
    Public Overridable Function getPlayerZpos() As Single
        Return m.ReadFloat(Player_ZPos_Address)
    End Function
    ''' <summary>
    ''' 현재 플레이어의 z좌표 값을 입력받은 Float형태의 실수 값으로 변경합니다. PhasmoPhobia 에서의 Z값은 수학에서의 Y값입니다.
    ''' </summary>
    Public Sub setPlayerZPos(ByVal value As Single)
        m.WriteMemory(Player_ZPos_Address, "Float", value)
    End Sub
    ''' <summary>
    ''' 현재 의뢰 난이도를 입력받은 정수 값으로 설정합니다. (0 = 초보, 1 = 중급자, 2 = 전문가)
    ''' </summary>
    Public Sub setDifficult(ByVal value As Integer)
        m.WriteMemory(Difficult_Address, "Byte", value)
    End Sub

    ''' <summary>
    ''' 플레이어를 죽은 상태로 변경하여 유령의 공격을 받지 않게 무적 상태로 만듭니다.
    ''' </summary>
    Public Sub setGodMode()
        m.WriteMemory(GodMode_1_Address, "Byte", 1)
        m.WriteMemory(GodMode_2_Address, "Byte", 1)
        m.WriteMemory(GodMode_3_Address, "Byte", 1)
    End Sub
    ''' <summary>
    ''' 플레이어의 무적 상태를 해제합니다. 죽은 후에 사용 시 부활할 수 있습니다.
    ''' </summary>
    Public Sub setUnGodMode()
        m.WriteMemory(GodMode_1_Address, "Byte", 0)
        m.WriteMemory(GodMode_2_Address, "Byte", 0)
        m.WriteMemory(GodMode_3_Address, "Byte", 0)
    End Sub
    ''' <summary>
    ''' 유령의 이름을 바이트 배열로 출력합니다.
    ''' </summary>
    Public Overridable Function getGhostName() As Byte()
        Return m.ReadBytes(GhostName_Address, 1000)
    End Function
    ''' <summary>
    ''' 유령의 나이를 정수로 출력합니다.
    ''' </summary>
    Public Overridable Function getGhostAge() As Integer
        Return m.ReadInt(GhostAge_Address)
    End Function
    ''' <summary>
    ''' 유령이 존재하는 방의 위치를 바이트 배열로 출력합니다.
    ''' </summary>
    Public Overridable Function getGhostRoom() As Byte()
        Return m.ReadBytes(GhostRoom_Address, 1000)
    End Function
    ''' <summary>
    ''' 유령이 헌팅 중인지를 정수로 출력합니다. 0은 헌팅, 1은 비헌팅을 의미합니다.
    ''' </summary>
    Public Overridable Function IsGhostHunting() As Integer
        Return m.ReadInt(GhostIsHunting_Address)
    End Function
    ''' <summary>
    ''' 유령의 속도를 정수로 출력합니다.
    ''' </summary>
    Public Overridable Function getGhostSpeed() As Single
        Return m.ReadFloat(GhostSpeed_Address)
    End Function
    ''' <summary>
    ''' 유령의 타입을 문자열로 출력합니다.
    ''' </summary>
    Public Overridable Function getGhostType() As String
        Dim GhostType As Integer = m.ReadInt(GhostType_Address)
        Dim TypeToString As String = String.Empty
        If GhostType = 0 Then
            TypeToString = "NULL"
        ElseIf GhostType = 1 Then
            TypeToString = "스피릿" 'Spirit
        ElseIf GhostType = 2 Then
            TypeToString = "레이스" 'Wraith
        ElseIf GhostType = 3 Then
            TypeToString = "팬텀" 'Phantom
        ElseIf GhostType = 4 Then
            TypeToString = "폴터가이스트" 'Poltergeist
        ElseIf GhostType = 5 Then
            TypeToString = "밴시" 'Banshee
        ElseIf GhostType = 6 Then
            TypeToString = "진" 'Djinn
        ElseIf GhostType = 7 Then
            TypeToString = "메어" 'Nightmare
        ElseIf GhostType = 8 Then
            TypeToString = "레버넌트" 'Revenant
        ElseIf GhostType = 9 Then
            TypeToString = "셰이드" 'Shade
        ElseIf GhostType = 10 Then
            TypeToString = "데몬" 'Demon
        ElseIf GhostType = 11 Then
            TypeToString = "유레이" 'Yurei
        ElseIf GhostType = 12 Then
            TypeToString = "오니" 'Oni
        ElseIf GhostType = 13 Then
            TypeToString = "한투" 'Hantu
        ElseIf GhostType = 14 Then
            TypeToString = "요괴" 'Yokai
        ElseIf GhostType = 15 Then
            TypeToString = "고료" 'Goryo
        ElseIf GhostType = 16 Then
            TypeToString = "마일링" 'Miling
        End If
        Return TypeToString
    End Function
End Class
