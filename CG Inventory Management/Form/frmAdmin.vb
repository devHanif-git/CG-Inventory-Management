Public Class frmAdmin
    Public SQL As New SQLControl
    Dim OldID As String = ""
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading.Show()
        dgvUsers.DoubleBuffered(True)
        Guna2GroupBox1.Left = (Guna2GroupBox1.Parent.Width \ 2) - (Guna2GroupBox1.Width \ 2) 'horizontal centering
        'Guna2GroupBox1.Top = (Guna2GroupBox1.Parent.Height \ 2) - (Guna2GroupBox1.Height \ 2) ' Ver centering
        Guna2GroupBox2.Left = (Guna2GroupBox2.Parent.Width \ 2) - (Guna2GroupBox2.Width \ 2) 'horizontal centering
        'Guna2GroupBox2.Top = (Guna2GroupBox2.Parent.Height \ 2) - (Guna2GroupBox2.Height \ 2) ' Ver centering
        Guna2GroupBox3.Left = (Guna2GroupBox3.Parent.Width \ 2) - (Guna2GroupBox3.Width \ 2) 'horizontal centering
        'Guna2GroupBox2.Top = (Guna2GroupBox2.Parent.Height \ 2) - (Guna2GroupBox2.Height \ 2) ' Ver centering


        'HWID
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

        txtHWID.Text = hwid

        'END HWID


        SQL.ExecQuery("SELECT * FROM CGIDNum")

        If SQL.HasException(True) Then Exit Sub

        txtCGIDNumber.Text = SQL.DBDT.Rows(0)("CGIDNo")
        txtyyMM.Text = SQL.DBDT.Rows(0)("CGIDYYMM")

        LoadDataToListBox()
        If lbxRack.Items.Count < 1 Then
            txtRackName.Text = ""
        Else
            lbxRack.SelectedIndex = 0
        End If

        SetupGroupLvl()
        SetupDGV()
        btnCreate.Visible = False
        btnCancel.Visible = False
        split.Visible = False
        Disable()
        LoadDatatoDGV()

        dgvUsers_CellClick(Nothing, Nothing)
        Loading.Close()
        Me.Show()
    End Sub
    Private Sub Disable()
        txtEmail.Enabled = False
        txtID.Enabled = False
        txtName.Enabled = False
        txtPass.Enabled = False
        txtPass2.Enabled = False
        txtUGroup.Enabled = False
        txtULvl.Enabled = False
        cbxActive.Enabled = False
        cbxSuspend.Enabled = False
    End Sub
    Private Sub Enable()
        txtEmail.Enabled = True
        txtID.Enabled = True
        txtName.Enabled = True
        txtPass.Enabled = True
        txtPass2.Enabled = True
        txtUGroup.Enabled = True
        txtULvl.Enabled = True
        cbxActive.Enabled = True
        cbxSuspend.Enabled = True
        txtID.Focus()
    End Sub
    Private Sub ClearText()
        txtEmail.Text = ""
        txtID.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        txtPass2.Text = ""
        txtUGroup.SelectedIndex = 0
        txtULvl.SelectedIndex = 0
        cbxActive.Checked = True
    End Sub

    Private Sub GetUserRack(Rack As String)
        SQL.AddParam("@rack", Rack)
        SQL.ExecQuery("SELECT TOP 1 * " &
                      "FROM Rack " &
                      "WHERE RackName = @rack;")

        If SQL.RecordCount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            txtRackName.Text = r("RackName")
        Next
    End Sub

    Private Sub LoadDataToListBox()
        SQL.ExecQuery("SELECT * FROM Rack")

        If SQL.HasException(True) Then Exit Sub


        For Each r As DataRow In SQL.DBDT.Rows
            lbxRack.Items.Add(r("RackName"))
        Next
    End Sub
    Private Sub SetupDGV()
        Dim dgvImageColumn As New DataGridViewImageColumn With {
            .Image = My.Resources.useractive,
            .HeaderText = "",
            .Name = "Status Icon",
            .Width = 28
        }

        With dgvUsers
            .RowHeadersVisible = False
            .ColumnCount = 7
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            .RowTemplate.Height = 40
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 255)

            .Columns.Insert(0, dgvImageColumn)

            Dim columnNames As String() = {"No.", "Employee ID", "Name", "Password", "User Group", "User Level", "Status"}

            For i As Integer = 1 To .ColumnCount - 1
                .Columns(i).Name = columnNames(i - 1)
            Next

            .Columns("Status Icon").Width = 28
            .Columns("No.").Width = 40
            .Columns("Name").Width = 350

            .Columns("No.").SortMode = DataGridViewColumnSortMode.NotSortable
        End With

    End Sub
    Private Sub SetupGroupLvl()
        txtUGroup.Items.Add("Select Group")
        txtULvl.Items.Add("Select Level")

        txtUGroup.SelectedIndex = 0
        txtULvl.SelectedIndex = 0
        If frmMain.lblLvl.Text = 3 Then
            txtUGroup.Items.Add("Administrator")
            txtUGroup.Items.Add("Store Leader")
            txtUGroup.Items.Add("Store Staff")

            txtULvl.Items.Add("System Administrator")
            txtULvl.Items.Add("Group Administrator")
            txtULvl.Items.Add("Section Operator")
        ElseIf frmMain.lblLvl.Text = 2 Then
            txtUGroup.Items.Add("Store Leader")
            txtUGroup.Items.Add("Store Staff")

            txtULvl.Items.Add("Group Administrator")
            txtULvl.Items.Add("Section Operator")
        End If
    End Sub
    Private Sub DoInsert()
        Try
            Dim chkdup As Boolean = Not CheckDupUserID(txtID.Text)
            If chkdup Then
                SQL.AddParam("@id", txtID.Text)
                SQL.AddParam("@pass", Encrypt(txtPass.Text))
                SQL.AddParam("@name", txtName.Text)
                SQL.AddParam("@email", txtEmail.Text)
                SQL.AddParam("@group", txtUGroup.Text)
                If txtULvl.SelectedIndex = 1 Then
                    SQL.AddParam("@lvl", 3)
                ElseIf txtULvl.SelectedIndex = 2 Then
                    SQL.AddParam("@lvl", 2)
                ElseIf txtULvl.SelectedIndex = 3 Then
                    SQL.AddParam("@lvl", 1)
                End If
                If cbxActive.Checked Then
                    SQL.AddParam("@stts", 1)
                Else
                    SQL.AddParam("@stts", 0)
                End If

                SQL.ExecQuery("INSERT INTO Users(UserID, UserPass, Name, Email, UserGroup, UserLevel, Status) VALUES(@id, @pass, @name, @email, @group, @lvl, @stts);")
                If SQL.HasException(True) Then Exit Sub

                MessageBox.Show("New Employee Account Has Been Added.", "Administrator")

            Else
                MessageBox.Show("Employee ID '" + txtID.Text + "' already exists in the database.", "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtID.Focus()
                txtID.Select(0, txtID.Text.Length)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub DoUpdate()
        Try
            SQL.AddParam("@oldid", OldID)
            SQL.AddParam("@id", txtID.Text)
            SQL.AddParam("@pass", Encrypt(txtPass.Text))
            SQL.AddParam("@name", txtName.Text)
            SQL.AddParam("@email", txtEmail.Text)
            SQL.AddParam("@group", txtUGroup.Text)
            If txtULvl.SelectedIndex = 1 Then
                SQL.AddParam("@lvl", 3)
            ElseIf txtULvl.SelectedIndex = 2 Then
                SQL.AddParam("@lvl", 2)
            ElseIf txtULvl.SelectedIndex = 3 Then
                SQL.AddParam("@lvl", 1)
            End If
            If cbxActive.Checked Then
                SQL.AddParam("@stts", 1)
            Else
                SQL.AddParam("@stts", 0)
            End If

            SQL.ExecQuery("UPDATE Users SET UserID = @id, UserPass = @pass, Name = @name, Email = @email, UserGroup = @group, UserLevel = @lvl, Status = @stts WHERE UserID = @oldid;")
            If SQL.HasException(True) Then Exit Sub

            MessageBox.Show("Employee Details Has Been Updated.", "Administrator")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DoDelete()
        Try
            SQL.AddParam("@id", txtID.Text)
            SQL.ExecQuery("DELETE FROM Users WHERE UserID = @id")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        lblTitle.Text = "Add New Employee Account"
        Enable()
        btnCreate.Text = "Create"
        btnCreate.Visible = True
        btnCancel.Visible = True
        split.Visible = True
        ClearText()
        dgvUsers.Enabled = False
    End Sub

    Private Function CheckDupUserID(UID As String) As Boolean
        SQL.AddParam("@id", UID)
        SQL.ExecQuery("SELECT * FROM Users WHERE UserID = @id")
        Dim result As Boolean = False
        If SQL.RecordCount > 0 Then
            result = True
        End If
        Return result
    End Function

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        txtPass.Select(0, txtPass.Text.Length)
    End Sub
    Private Sub txtPass2_Enter(sender As Object, e As EventArgs) Handles txtPass2.Enter
        txtPass2.Select(0, txtPass2.Text.Length)
    End Sub

    Private Sub LoadDatatoDGV()
        Try
            dgvUsers.Rows.Clear()
            dgvUsers.Enabled = True
            If frmMain.lblLvl.Text = 3 Then
                SQL.AddParam("@1", 1)
                SQL.AddParam("@2", 2)
                SQL.AddParam("@3", 3)
            ElseIf frmMain.lblLvl.Text = 2 Then
                SQL.AddParam("@1", 1)
                SQL.AddParam("@2", 2)
                SQL.AddParam("@3", "")
            End If

            SQL.ExecQuery("SELECT * FROM Users WHERE UserLevel IN (@1,@2,@3) ORDER BY UserID;")

            If SQL.HasException(True) Then Exit Sub

            For i As Integer = 1 To SQL.DBDT.Rows.Count
                Dim status As Boolean = False
                Dim image As Image
                Dim textstatus As String
                If SQL.DBDT.Rows(i - 1)("Status") = True Then
                    status = True
                Else
                    status = False
                End If
                If status Then
                    image = My.Resources.useractive
                    textstatus = "ACTIVE"
                Else
                    image = My.Resources.usersuspended
                    textstatus = "SUSPENDED"
                End If

                Dim textlevel As String = ""
                If SQL.DBDT.Rows(i - 1)("UserLevel") = 3 Then
                    textlevel = "System Administrator"
                ElseIf SQL.DBDT.Rows(i - 1)("UserLevel") = 2 Then
                    textlevel = "Group Administrator"
                ElseIf SQL.DBDT.Rows(i - 1)("UserLevel") = 1 Then
                    textlevel = "Section Operator"
                End If

                dgvUsers.Rows.Add(New Object() {image, i.ToString + ".", SQL.DBDT.Rows(i - 1)("UserID"), SQL.DBDT.Rows(i - 1)("Name"), Strings.StrDup(16, "*"), SQL.DBDT.Rows(i - 1)("UserGroup"), textlevel, textstatus})

                If textstatus = "SUSPENDED" Then
                    For j As Integer = 1 To dgvUsers.Columns.Count
                        dgvUsers.Rows(dgvUsers.Rows.Count - 1).Cells(j - 1).Style.BackColor = Color.FromArgb(255, 192, 192)
                    Next
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Highlight(UserID As String)
        For i As Integer = 1 To dgvUsers.Rows.Count
            If dgvUsers.Rows(i - 1).Cells(2).Value = UserID Then
                dgvUsers.ClearSelection()
                dgvUsers.Rows(i - 1).Selected = True
            End If
        Next
    End Sub

    Private Sub HighlightList(UserID As String)
        For i As Integer = 1 To lbxRack.Items.Count
            If lbxRack.Items(i - 1).ToString = UserID Then
                lbxRack.SelectedIndex = 0
                lbxRack.SelectedIndex = i - 1
            End If
        Next
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        txtID.Text = dgvUsers.CurrentRow.Cells(2).Value.ToString
        txtName.Text = dgvUsers.CurrentRow.Cells(3).Value.ToString
        txtPass.Text = dgvUsers.CurrentRow.Cells(4).Value.ToString
        txtPass2.Text = dgvUsers.CurrentRow.Cells(4).Value.ToString
        txtEmail.Text = GetUserEmail(dgvUsers.CurrentRow.Cells(2).Value.ToString)

        If frmMain.lblLvl.Text = 3 Then
            If dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Administrator" Then
                txtUGroup.SelectedIndex = 1
            ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Leader" Then
                txtUGroup.SelectedIndex = 2
            ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Staff" Then
                txtUGroup.SelectedIndex = 3
            End If

            If dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "System Administrator" Then
                txtULvl.SelectedIndex = 1
            ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Group Administrator" Then
                txtULvl.SelectedIndex = 2
            ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Section Operator" Then
                txtULvl.SelectedIndex = 3
            End If
        End If

        If frmMain.lblLvl.Text = 2 Then
            If dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Leader" Then
                txtUGroup.SelectedIndex = 1
            ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Staff" Then
                txtUGroup.SelectedIndex = 2
            End If

            If dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Group Administrator" Then
                txtULvl.SelectedIndex = 1
            ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Section Operator" Then
                txtULvl.SelectedIndex = 2
            End If
        End If

        If dgvUsers.CurrentRow.Cells("Status").Value.ToString = "SUSPENDED" Then
            cbxSuspend.Checked = True
        Else
            cbxActive.Checked = True
        End If
    End Sub

    Private Function GetUserEmail(UID As String) As Object
        Dim result As String = ""

        SQL.AddParam("@id", UID)
        SQL.ExecQuery("SELECT Email FROM Users WHERE UserID = @id")
        If SQL.HasException(True) Then Exit Function

        If SQL.RecordCount > 0 Then
            result = SQL.DBDT.Rows(0)("Email").ToString
        End If

        Return result
    End Function

    Private Function GetUserPass(UID As String) As Object
        Dim resultenc As String = ""
        Dim result As String

        SQL.AddParam("@id", UID)
        SQL.ExecQuery("SELECT UserPass FROM Users WHERE UserID = @id")
        If SQL.HasException(True) Then Exit Function

        If SQL.RecordCount > 0 Then
            resultenc = SQL.DBDT.Rows(0)("UserPass").ToString
        End If

        result = Decrypt(resultenc)
        Return result
    End Function

    Private Sub EditEmployeeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEmployeeDetailsToolStripMenuItem.Click
        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvUsers.Focus()
        Else
            Dim OldPass As String = GetUserPass(txtID.Text)
            txtPass.Text = OldPass
            txtPass2.Text = OldPass
            dgvUsers.Enabled = False
            OldID = txtID.Text
            Enable()
            btnCreate.Text = "Save"
            btnCreate.Visible = True
            btnCancel.Visible = True
            split.Visible = True
        End If
    End Sub

    Private Sub DeleteEmployeeAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeAccountToolStripMenuItem.Click
        Dim num As Integer = 0

        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dgvUsers.Focus()
        Else
            If dgvUsers.SelectedRows(0).Cells("User Level").Value = "Group Administrator" Then
                For i As Integer = 1 To dgvUsers.Rows.Count
                    If dgvUsers.Rows(i - 1).Cells("User Level").Value = "Group Administrator" Then
                        num += 1
                    End If
                Next
                If num = 1 Then
                    MessageBox.Show("At least one Group Administrator account needs to remain in the system to manage users.", "Group Administrator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                num = 2
            End If
            If num > 1 Then
                If MessageBox.Show("Confirm to delete below employee account?" & vbCrLf & vbCrLf & "Employee ID: " & dgvUsers.SelectedRows(0).Cells("Employee ID").Value & vbCrLf & "Name: " & dgvUsers.SelectedRows(0).Cells("Name").Value & vbCrLf & "User Group: " & dgvUsers.SelectedRows(0).Cells("User Group").Value & vbCrLf & "User Level: " & dgvUsers.SelectedRows(0).Cells("User Level").Value, "Delete User Login Account", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    DoDelete()
                    LoadDatatoDGV()
                    Disable()
                    btnCreate.Visible = False
                    btnCancel.Visible = False
                    split.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub cbxPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSPass.CheckedChanged
        If cbxSPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
            txtPass2.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
            txtPass2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim num As Integer = 0

        If btnCreate.Text = "Save" Then
            If txtID.Text = "" Then
                MessageBox.Show("The Employee ID information is required.", "Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtID.Focus()
            ElseIf txtName.Text = "" Then
                MessageBox.Show("The User Name information is required.", "User Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtName.Focus()
            ElseIf txtPass.Text = "" Then
                MessageBox.Show("Password is required.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPass.Focus()
            ElseIf txtPass.Text.Length < 6 Then
                MessageBox.Show("A password length of at least 6 characters is required.", "Passwords Length", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPass.Focus()
                txtPass.Select(0, txtPass.Text.Length)
            ElseIf txtPass.Text <> txtPass2.Text Then
                MessageBox.Show("The entered Passwords do not match!", "Passwords Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPass.Focus()
                txtPass.Select(0, txtPass.Text.Length)
            ElseIf txtUGroup.SelectedIndex = 0 Then
                MessageBox.Show("The User Group selection is required.", "User Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUGroup.Select()
            ElseIf txtULvl.SelectedIndex = 0 Then
                MessageBox.Show("The User Level selection is required.", "User Level", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtULvl.Select()
            Else
                If dgvUsers.SelectedRows(0).Cells("User Level").Value = "Group Administrator" Then
                    For i As Integer = 1 To dgvUsers.Rows.Count
                        If dgvUsers.Rows(i - 1).Cells("User Level").Value = "Group Administrator" Then
                            num += 1
                        End If
                    Next
                    If num = 1 Then
                        MessageBox.Show("At least one Group Administrator account needs to remain in the system to manage users.", "Group Administrator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    num = 2
                End If
                If num > 1 Then
                    DoUpdate()
                    LoadDatatoDGV()
                    Highlight(txtID.Text)
                    'ClearText()
                    Disable()
                    btnCreate.Visible = False
                    btnCancel.Visible = False
                    split.Visible = False
                End If
            End If
        Else
            If txtID.Text = "" Then
                MessageBox.Show("The Employee ID information is required.", "Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtID.Focus()
            ElseIf txtName.Text = "" Then
                MessageBox.Show("The User Name information is required.", "User Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtName.Focus()
            ElseIf txtPass.Text = "" Then
                MessageBox.Show("Password is required.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPass.Focus()
            ElseIf txtPass.Text.Length < 6 Then
                MessageBox.Show("A password length of at least 6 characters is required.", "Passwords Length", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPass.Focus()
                txtPass.Select(0, txtPass.Text.Length)
            ElseIf txtPass.Text <> txtPass2.Text Then
                MessageBox.Show("The entered Passwords do not match!", "Passwords Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPass.Focus()
                txtPass.Select(0, txtPass.Text.Length)
            ElseIf txtUGroup.SelectedIndex = 0 Then
                MessageBox.Show("The User Group selection is required.", "User Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUGroup.Select()
            ElseIf txtULvl.SelectedIndex = 0 Then
                MessageBox.Show("The User Level selection is required.", "User Level", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtULvl.Select()
            Else
                DoInsert()
                LoadDatatoDGV()
                Highlight(txtID.Text)
                'ClearText()
                Disable()
                btnCreate.Visible = False
                btnCancel.Visible = False
                split.Visible = False
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lblTitle.Text = "Employee Account Details"
        btnCreate.Visible = False
        btnCancel.Visible = False
        split.Visible = False
        Disable()
        txtID.Text = dgvUsers.SelectedRows(0).Cells("Employee ID").Value
        txtName.Text = dgvUsers.SelectedRows(0).Cells("Name").Value
        txtPass.Text = dgvUsers.SelectedRows(0).Cells("Password").Value
        txtPass2.Text = dgvUsers.SelectedRows(0).Cells("Password").Value
        txtEmail.Text = GetUserEmail(txtID.Text)
        If frmMain.lblLvl.Text = 3 Then
            If dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Administrator" Then
                txtUGroup.SelectedIndex = 1
            ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Leader" Then
                txtUGroup.SelectedIndex = 2
            ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Staff" Then
                txtUGroup.SelectedIndex = 3
            End If

            If dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "System Administrator" Then
                txtULvl.SelectedIndex = 1
            ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Group Administrator" Then
                txtULvl.SelectedIndex = 2
            ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Section Operator" Then
                txtULvl.SelectedIndex = 3
            End If
        End If

        If frmMain.lblLvl.Text = 2 Then
            If dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Leader" Then
                txtUGroup.SelectedIndex = 1
            ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Staff" Then
                txtUGroup.SelectedIndex = 2
            End If

            If dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Group Administrator" Then
                txtULvl.SelectedIndex = 1
            ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Section Operator" Then
                txtULvl.SelectedIndex = 2
            End If
        End If

        If dgvUsers.CurrentRow.Cells("Status").Value.ToString = "SUSPENDED" Then
            cbxSuspend.Checked = True
        Else
            cbxActive.Checked = True
        End If
        'ClearText()
        dgvUsers.Enabled = True
        dgvUsers.Focus()
    End Sub

    Private Sub dgvUsers_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsers.CellMouseDown
        If e.Button = MouseButtons.Right Then

            If e.RowIndex = -1 Then Return

            dgvUsers.CurrentCell = dgvUsers(e.ColumnIndex, e.RowIndex)
            txtID.Text = dgvUsers.CurrentRow.Cells(2).Value.ToString
            txtName.Text = dgvUsers.CurrentRow.Cells(3).Value.ToString
            txtPass.Text = dgvUsers.CurrentRow.Cells(4).Value.ToString
            txtPass2.Text = dgvUsers.CurrentRow.Cells(4).Value.ToString
            txtEmail.Text = GetUserEmail(dgvUsers.CurrentRow.Cells(2).Value.ToString)

            If frmMain.lblLvl.Text = 3 Then
                If dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Administrator" Then
                    txtUGroup.SelectedIndex = 1
                ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Leader" Then
                    txtUGroup.SelectedIndex = 2
                ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Staff" Then
                    txtUGroup.SelectedIndex = 3
                End If

                If dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "System Administrator" Then
                    txtULvl.SelectedIndex = 1
                ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Group Administrator" Then
                    txtULvl.SelectedIndex = 2
                ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Section Operator" Then
                    txtULvl.SelectedIndex = 3
                End If
            End If

            If frmMain.lblLvl.Text = 2 Then
                If dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Leader" Then
                    txtUGroup.SelectedIndex = 1
                ElseIf dgvUsers.CurrentRow.Cells("User Group").Value.ToString = "Store Staff" Then
                    txtUGroup.SelectedIndex = 2
                End If

                If dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Group Administrator" Then
                    txtULvl.SelectedIndex = 1
                ElseIf dgvUsers.CurrentRow.Cells("User Level").Value.ToString = "Section Operator" Then
                    txtULvl.SelectedIndex = 2
                End If
            End If

            If dgvUsers.CurrentRow.Cells("Status").Value.ToString = "SUSPENDED" Then
                cbxSuspend.Checked = True
            Else
                cbxActive.Checked = True
            End If
        End If
    End Sub

    Private Sub lbxRack_MouseDown(sender As Object, e As MouseEventArgs) Handles lbxRack.MouseDown
        If e.Button = MouseButtons.Right Then
            lbxRack.SelectedIndex = lbxRack.IndexFromPoint(e.X, e.Y)
        End If

    End Sub

    Private Sub lbxRack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxRack.SelectedIndexChanged

        GetUserRack(lbxRack.Text)

    End Sub
    Private Sub CreateNewRackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewRackToolStripMenuItem.Click
        lbxRack.Enabled = False
        btnAdd.Text = "Add"
        txtRackName.Text = ""
        btnAdd.Visible = True
        btnACancel.Visible = True
        txtRackName.Enabled = True
        txtRackName.Focus()
    End Sub

    Private Sub btnACancel_Click(sender As Object, e As EventArgs) Handles btnACancel.Click
        lbxRack.Enabled = True
        btnAdd.Visible = False
        btnACancel.Visible = False
        txtRackName.Enabled = False

        GetUserRack(lbxRack.Text)

    End Sub
    Private Sub AddNewRack(NameRack As String)
        'get current user
        SQL.AddParam("@name", frmMain.lblUser.Text)
        SQL.ExecQuery("SELECT UserID FROM Users WHERE Name = @name")

        If SQL.RecordCount < 1 Then Exit Sub

        Dim uid As String = ""
        For Each r As DataRow In SQL.DBDT.Rows
            uid = r("UserID")
        Next

        SQL.AddParam("@rack", NameRack)
        SQL.AddParam("@uid", uid)

        SQL.ExecQuery("INSERT INTO Rack(RackName, UpdateTime, Updater) VALUES(@rack, GETDATE(), @uid)")

        If SQL.HasException(True) Then Exit Sub

        MessageBox.Show("Rack has been added.", "Administrator")
    End Sub

    Private Sub DoUpdateRack()
        'get current user
        SQL.AddParam("@name", frmMain.lblUser.Text)
        SQL.ExecQuery("SELECT UserID FROM Users WHERE Name = @name")

        If SQL.RecordCount < 1 Then Exit Sub

        Dim uid As String = ""
        For Each r As DataRow In SQL.DBDT.Rows
            uid = r("UserID")
        Next

        SQL.AddParam("@uid", uid)
        SQL.AddParam("@rack", lbxRack.Text)
        SQL.AddParam("@newrack", txtRackName.Text)

        SQL.ExecQuery("UPDATE Rack SET RackName = @newrack, UpdateTime = GETDATE(), Updater = @uid WHERE RackName = @rack")

        If SQL.HasException(True) Then Exit Sub

        MessageBox.Show("Rack Details Has Been Updated.", "Administrator")
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Save" Then
            If txtRackName.Text = "" Then
                MessageBox.Show("The Rack information is required.", "Rack", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DoUpdateRack()
                lbxRack.Items.Clear()
                LoadDataToListBox()
                HighlightList(txtRackName.Text)

                btnAdd.Visible = False
                btnACancel.Visible = False
                txtRackName.Enabled = False

                GetUserRack(lbxRack.Text)
                lbxRack.Enabled = True
            End If

        Else
            If txtRackName.Text = "" Then
                MessageBox.Show("The Rack information is required.", "Rack", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                AddNewRack(txtRackName.Text)
                lbxRack.Items.Clear()
                LoadDataToListBox()
                HighlightList(txtRackName.Text)

                btnAdd.Visible = False
                btnACancel.Visible = False
                txtRackName.Enabled = False

                GetUserRack(lbxRack.Text)
                lbxRack.Enabled = True
            End If
        End If
    End Sub

    Private Sub EditRackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditRackToolStripMenuItem.Click
        If lbxRack.Text = "" Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lbxRack.Focus()
        Else
            lbxRack.Enabled = False
            GetUserRack(lbxRack.Text)
            btnAdd.Text = "Save"
            btnAdd.Visible = True
            btnACancel.Visible = True
            txtRackName.Enabled = True
            txtRackName.Focus()
        End If
    End Sub
    Private Sub DoDeleteRack()
        Try
            SQL.AddParam("@rack", lbxRack.Text)
            SQL.ExecQuery("DELETE FROM Rack WHERE RackName = @rack")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub DeleteRackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRackToolStripMenuItem.Click
        If lbxRack.Text = "" Then
            MessageBox.Show("A selection is required.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lbxRack.Focus()
        Else
            If MessageBox.Show("Confirm to delete below rack?" & vbCrLf & vbCrLf & "Rack Name: " & lbxRack.Text, "Delete Rack", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                DoDeleteRack()
                lbxRack.Items.Clear()
                LoadDataToListBox()
                If lbxRack.Items.Count < 1 Then
                    txtRackName.Text = ""
                Else
                    lbxRack.SelectedIndex = 0
                End If

                btnAdd.Visible = False
                btnACancel.Visible = False
                txtRackName.Enabled = False

                GetUserRack(lbxRack.Text)
            End If
        End If
    End Sub

    Private Sub txtRackName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRackName.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btnAdd.PerformClick()

            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        btnSave.Visible = True
        btnCancelS.Visible = True
        txtyyMM.Enabled = True
        txtCGIDNumber.Enabled = True
        txtyyMM.Focus()
        txtyyMM.Select(0, txtyyMM.TextLength)
    End Sub

    Private Sub btnCancelS_Click(sender As Object, e As EventArgs) Handles btnCancelS.Click
        SQL.ExecQuery("SELECT * FROM CGIDNum")

        If SQL.HasException(True) Then Exit Sub

        txtCGIDNumber.Text = SQL.DBDT.Rows(0)("CGIDNo")
        txtyyMM.Text = SQL.DBDT.Rows(0)("CGIDYYMM")

        txtCGIDNumber.Enabled = False
        txtyyMM.Enabled = False
        btnCancelS.Visible = False
        btnSave.Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SQL.AddParam("@yyMM", txtyyMM.Text.Trim)
        SQL.AddParam("@cgidno", txtCGIDNumber.Text.Trim)

        SQL.ExecQuery("UPDATE CGIDNum SET CGIDYYMM = @yyMM, CGIDNo = @cgidno")

        If SQL.HasException(True) Then Exit Sub

        btnSave.Visible = False
        btnCancel.Visible = False
        txtCGIDNumber.Enabled = False
        txtyyMM.Enabled = False
        btnCancelS.Visible = False
        btnSave.Visible = False

        SQL.ExecQuery("SELECT * FROM CGIDNum")

        If SQL.HasException(True) Then Exit Sub

        txtCGIDNumber.Text = SQL.DBDT.Rows(0)("CGIDNo")
        txtyyMM.Text = SQL.DBDT.Rows(0)("CGIDYYMM")

        MessageBox.Show("The New Settings Have Been Updated.", "Administrator")

    End Sub

    Private Sub txtyyMM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtyyMM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                txtCGIDNumber.Focus()
                txtCGIDNumber.Select(0, txtCGIDNumber.TextLength)
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub txtCGIDNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCGIDNumber.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btnSave.PerformClick()

            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If txtHWID.Text <> String.Empty Then
            Clipboard.SetText(txtHWID.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub btncgidConfirm_Click(sender As Object, e As EventArgs) Handles btncgidConfirm.Click
        If txtCGID.Text.StartsWith("CGID-") Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete everything related to this CGID?" + vbCrLf +
                                                         vbCrLf +
                                                         "CGID Number: " & txtCGID.Text.Trim, "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'check for data if valid or not
                SQL.AddParam("@cgid", txtCGID.Text.Trim)
                SQL.ExecQuery("SELECT TOP 1 * FROM PartLog WHERE CGID = @cgid")

                If SQL.RecordCount > 0 Then
                    SQL.AddParam("@cgid", txtCGID.Text.Trim)
                    SQL.ExecQuery("DELETE FROM Inventory WHERE CGID = @cgid")
                    SQL.AddParam("@cgid", txtCGID.Text.Trim)
                    SQL.ExecQuery("DELETE FROM PartLog WHERE CGID = @cgid")
                    SQL.AddParam("@cgid", txtCGID.Text.Trim)
                    SQL.ExecQuery("DELETE FROM PartOut WHERE CGID = @cgid")
                    SQL.AddParam("@cgid", txtCGID.Text.Trim)
                    SQL.ExecQuery("DELETE FROM PrintedCode WHERE CGID = @cgid")

                    If SQL.HasException(True) Then Exit Sub
                    MessageBox.Show("Delete Completed!.", "Completed!.")
                    txtCGID.Text = ""
                    txtCGID.Focus()
                End If
            End If
        Else
            MessageBox.Show("The CGID Number is invalid!.", "Invalid!")
            txtCGID.Focus()
        End If
    End Sub

    Private Sub txtCGID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCGID.KeyPress
        'press enter in textbox
        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btncgidConfirm.PerformClick()
            Catch ex As Exception
                Exit Sub
            End Try

        End If
    End Sub
End Class



