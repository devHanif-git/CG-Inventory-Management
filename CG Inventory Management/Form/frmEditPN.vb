Public Class frmEditPN
    Public SQL As New SQLControl
    Dim oldpn As String
    Dim oldpt As String
    Dim oldpd As String
    Dim oldqpp As Integer
    Private Sub frmEditPN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txtPN.Focus()
        txtPN.SelectionLength = 0
        oldpn = txtPN.Text
        oldpt = txtPT.Text
        oldpd = txtPD.Text
        oldqpp = txtQPP.Value
    End Sub

    Private Sub DoUpdatePN()
        'get current user
        SQL.AddParam("@name", frmMain.lblUser.Text)
        SQL.ExecQuery("SELECT UserID FROM Users WHERE Name = @name")

        If SQL.RecordCount < 1 Then Exit Sub

        Dim uid As String = ""
        For Each r As DataRow In SQL.DBDT.Rows
            uid = r("UserID")
        Next

        'ALTER TABLE Inventory DROP CONSTRAINT FK_PartNumber

        SQL.ExecQuery("ALTER TABLE Inventory DROP CONSTRAINT FK_PartNumber;")
        If SQL.HasException(True) Then Exit Sub

        'UPDATE HERE
        Dim tables As String() = {"Inventory", "PartLog", "PartOut", "PrintedCode"}

        For Each table In tables
            SQL.AddParam("@pn", txtPN.Text)
            SQL.AddParam("@oldpn", oldpn)

            SQL.ExecQuery("UPDATE " & table & " SET PartNumber = @pn WHERE PartNumber = @oldpn")
            If SQL.HasException(True) Then Exit Sub
        Next

        'Part Management itself
        SQL.AddParam("@uid", uid)
        SQL.AddParam("@pn", txtPN.Text)
        SQL.AddParam("@pt", txtPT.Text)
        SQL.AddParam("@pd", txtPD.Text)
        SQL.AddParam("@qpp", txtQPP.Value)
        SQL.AddParam("@oldpn", oldpn)

        SQL.ExecQuery("UPDATE PartManagement SET PartNumber = @pn, " _
                    & "PartType = @pt, PN_Desc = @pd, QtyPerPart = @qpp, " _
                    & "UpdateTime = GETDATE(), Updater = @uid WHERE PartNumber = @oldpn;")
        If SQL.HasException(True) Then Exit Sub

        SQL.ExecQuery("ALTER TABLE Inventory " _
                    & "ADD Constraint FK_PartNumber " _
                    & "FOREIGN KEY(PartNumber) REFERENCES PartManagement(PartNumber);")
        If SQL.HasException(True) Then Exit Sub

        MessageBox.Show("Part Details Has Been Updated.", "Part Management")
        Me.Close()
        frmMain.btnMM.PerformClick()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim changesDetected As Boolean = False
        ' Check if the text in the txtpn textbox is different from the oldpn string
        If txtPN.Text <> oldpn Then
            changesDetected = True
        End If
        ' Check if the text in the txtpt textbox is different from the oldpt string
        If txtPT.Text <> oldpt Then
            changesDetected = True
        End If
        ' Check if the text in the txtpt textbox is different from the oldpt string
        If txtPD.Text <> oldpd Then
            changesDetected = True
        End If
        ' Check if the text in the txtqty textbox is different from the oldqty string
        If txtQPP.Text <> oldqpp Then
            changesDetected = True
        End If

        If changesDetected Then
            If MessageBox.Show("Are you sure you want to save changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                DoUpdatePN()
            End If
        Else
            ' None of the textboxes have been changed
            MessageBox.Show("None of the textboxes have been changed")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class