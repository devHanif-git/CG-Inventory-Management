Public Class Splash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Cursor.Current = Cursors.WaitCursor

        'Init BarTender Engine
        If ProgressBar1.Value = 1 Then
            initEngine.Show()
        End If

        'GET HWID
        If ProgressBar1.Value = 50 Then
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

            Dim hwid As String = Strings.UCase(hw.getMD5Hash(cpu & hdd & mb & mac))

            frmMain.hwid = hwid

            Timer1.Enabled = True
        End If

        'Finishing
        If ProgressBar1.Value = 100 Then
            Me.Close()
            frmMain.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class