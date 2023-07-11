Public Class Splash
    Private hwid As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Cursor.Current = Cursors.WaitCursor

        'GET HWID
        If ProgressBar1.Value = 20 Then
            Timer1.Enabled = False
            Dim hw As New clsComputerInfo

            Dim hdd As String
            Dim cpu As String
            Dim mb As String
            Dim mac As String

            cpu = hw.GetProcessorId()
            hdd = hw.GetVolumeSerial("C")
            mb = hw.GetMotherBoardID()
            mac = hw.GetMACAddress()

            hwid = Strings.UCase(hw.getMD5Hash(cpu & hdd & mb & mac))

            frmMain.hwid = hwid

            Timer1.Enabled = True
        End If

        'Init BarTender Engine
        If ProgressBar1.Value = 50 And hwid = "7C654D04A9EE2967620C99DD5DD1A0F1" Then
            initEngine.Show()
        End If

        'Finishing
        If ProgressBar1.Value = 100 Then
            Me.Close()
            frmMain.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class