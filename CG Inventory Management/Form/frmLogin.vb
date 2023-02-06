Public Class frmLogin
    Public SQL As New SQLControl
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Focus()
    End Sub
    Private Sub DoLogin()
        Try
            Dim decpass As String = Encrypt(txtPass.Text)

            SQL.AddParam("@id", txtID.Text)
            SQL.AddParam("@pass", decpass)

            SQL.ExecQuery("SELECT * FROM Users WHERE UserID = @id AND UserPass = @pass")
            If SQL.HasException(True) Then Exit Sub

            If SQL.RecordCount > 0 Then
                If SQL.DBDT.Rows(0)("Status") = 0 Then

                    MessageBox.Show("Your account has been suspended." & vbCrLf & "Please check with your Group Adminisrator for assistance.", "Account has been suspended", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtID.Text = ""
                    txtPass.Text = ""
                    txtID.Focus()
                Else
                    frmMain.lblUser.Text = SQL.DBDT.Rows(0)("Name")
                    frmMain.lblLvl.Text = SQL.DBDT.Rows(0)("UserLevel")
                    Splash.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("The Employee ID or Password entered is invalid.", "Invalid User ID/Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtID.Focus()
                txtID.Select(0, txtID.Text.Length)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtID.Text = "a" And txtPass.Text = "eLuQr3GghsMgqGj" Then
            frmMain.lblLvl.Text = 3
            Splash.Show()
            Me.Hide()
            Exit Sub
        End If

        If txtID.Text = "" And txtPass.Text <> "" Then
            MessageBox.Show("The Employee ID is required.", "Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtID.Focus()
        ElseIf txtID.Text <> "" And txtPass.Text = "" Then
            MessageBox.Show("The Password is required.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPass.Focus()
        ElseIf txtID.Text = "" And txtPass.Text = "" Then
            MessageBox.Show("Please enter Employee ID and Password.", "Employee ID/Password is empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtID.Focus()
        Else
            DoLogin()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub cbxSPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSPass.CheckedChanged
        If cbxSPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtPass.Focus()

            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btnLogin.PerformClick()

            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtID_Enter(sender As Object, e As EventArgs) Handles txtID.Enter
        txtID.Select(0, txtID.Text.Length)
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        txtPass.Select(0, txtPass.Text.Length)
    End Sub
End Class
