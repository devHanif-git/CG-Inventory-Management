Imports Seagull.BarTender.Print
Public Class PrintCartonLabel
    Dim _btw_path = ""
    Dim _PrinterName = ""
    Private Sub PrintCartonLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Dim printers As Printers = New Printers()

        If printers.Count > 0 Then
            _PrinterName = printers.[Default].PrinterName
        End If

        _btw_path = Application.StartupPath + "\Label.btw"
        btnno.Focus()
    End Sub

    Private Sub PrintBar(ByVal y As Integer)
        Using btEngine As Engine = New Engine(True) ' this make it delay
            Dim labelFormat As LabelFormatDocument = btEngine.Documents.Open(_btw_path)

            Try
                'QR Code
                labelFormat.SubStrings.SetSubString("pn", lblpn.Text)
                labelFormat.SubStrings.SetSubString("cgcode", lblcgcode.Text)
                labelFormat.SubStrings.SetSubString("qty", lblqty.Text)
                'Others
            Catch ex As Exception
                MessageBox.Show("Error in modifying content" & ex.Message, "Printing Error!")
            End Try

            If _PrinterName <> "" Then
                labelFormat.PrintSetup.PrinterName = _PrinterName
                For i As Integer = 1 To y
                    labelFormat.Print("CGIM" & DateTime.Now, 20)
                Next
            Else
                MessageBox.Show("Please select a printer first", "Select Printer!")
            End If
        End Using
    End Sub

    Private Sub btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click
        Me.Close()
    End Sub

    Private Sub btnprint1_Click(sender As Object, e As EventArgs) Handles btnprint1.Click
        Loading.Show()
        PrintBar(1)
        Loading.Close()
        Me.Close()
    End Sub

    Private Sub btnprint2_Click(sender As Object, e As EventArgs) Handles btnprint2.Click
        Loading.Show()
        PrintBar(2)
        Loading.Close()
        Me.Close()
    End Sub
End Class