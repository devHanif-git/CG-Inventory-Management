Public Class frmMain
    Private currentChildForm As Form
    Public hwid As String = ""
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelMain.Controls.Add(childForm)
        PanelMain.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        'lblFormTitle.Text = childForm.Text
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading.Show()
        OpenChildForm(New frmInventory)
        Me.Show()
        Loading.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        OpenChildForm(New frmInventory)
    End Sub

    Private Sub lblSignOut_Click(sender As Object, e As EventArgs) Handles lblSignOut.Click
        frmLogin.txtID.Text = ""
        frmLogin.txtPass.Text = ""
        frmLogin.cbxSPass.Checked = False
        frmLogin.Show()
        frmLogin.Focus()
        frmLogin.txtID.Focus()
        Me.Close()
    End Sub

    Private Sub btnIncoming_Click(sender As Object, e As EventArgs) Handles btnIncoming.Click
        If hwid <> "7C654D04A9EE2967620C99DD5DD1A0F1" Or hwid = "05EA3FF0C220883F0020347582CCD983" Then
            MessageBox.Show("Access is denied!" & vbCrLf & vbCrLf & "Reason: Because no 'Bartender' printer was detected," & vbCrLf & "this PC/Hardware is unable to print.", "Access is denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            OpenChildForm(New frmIncoming)
        End If
    End Sub

    Private Sub btnMSI_Click(sender As Object, e As EventArgs) Handles btnMSI.Click
        If hwid <> "7C654D04A9EE2967620C99DD5DD1A0F1" Or hwid = "05EA3FF0C220883F0020347582CCD983" Then
            MessageBox.Show("Access is denied!" & vbCrLf & vbCrLf & "Reason: Because no 'Bartender' printer was detected," & vbCrLf & "this PC/Hardware is unable to print.", "Access is denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            OpenChildForm(New frmStockIn)
        End If
    End Sub

    Private Sub btnMSO_Click(sender As Object, e As EventArgs) Handles btnMSO.Click
        OpenChildForm(New frmStockOut)
    End Sub

    Private Sub btnMM_Click(sender As Object, e As EventArgs) Handles btnMM.Click
        OpenChildForm(New frmMM)
    End Sub

    Private Sub btnML_Click(sender As Object, e As EventArgs) Handles btnML.Click
        OpenChildForm(New frmML)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        If lblLvl.Text = 1 Then
            MessageBox.Show("You are 'STAFF,' hence you are not permitted to access the Administrator." & vbCrLf & vbCrLf & "Please check with your Group Adminisrator for assistance.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            OpenChildForm(New frmAdmin)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmLogin.txtID.Text = ""
        frmLogin.txtPass.Text = ""
        frmLogin.cbxSPass.Checked = False
        frmLogin.Show()
        frmLogin.Focus()
        frmLogin.txtID.Focus()
        Me.Close()
    End Sub
End Class