Public Class frmFindExact

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            'no beep
            e.Handled = True
            Try
                btnCalc.PerformClick()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub frmFindExact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txtQty.Text = ""
        txtQty.TextAlign = HorizontalAlignment.Center
        txtQty.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim array As New List(Of Integer)()
        For Each row As DataGridViewRow In frmInventoryPart.dgvInventory.Rows
            array.Add(CInt(row.Cells(5).Value))
        Next
        Dim target_sum As Integer = txtQty.Text.Trim
        Dim result As Object = find_sum(array.ToArray(), target_sum)
        If result Is Nothing Then
            MessageBox.Show("No combination of elements in the array adds up to " & target_sum) 
        ElseIf TypeOf result Is Integer Then
            MessageBox.Show(result.ToString())
        Else
            Dim subset As Integer() = DirectCast(result, Integer())

            Dim subset_string As String = ""
            Dim count As Integer = 0
            For i As Integer = 0 To subset.Length - 1
                If count = 5 Then
                    subset_string &= Environment.NewLine
                    count = 0
                End If
                If i = subset.Length - 1 Then
                    subset_string &= subset(i)
                Else
                    subset_string &= subset(i) & " + "
                End If
                count += 1
            Next

            subset_string = subset_string.TrimEnd & " = " & target_sum.ToString()
            MessageBox.Show(subset_string)
        End If
        txtQty.SelectAll()
    End Sub

    Private Function find_sum(array As Integer(), target_sum As Integer) As Object
        Dim n As Integer = array.Length
        Dim dp(n, target_sum + 1) As Boolean

        For i As Integer = 0 To n
            dp(i, 0) = True
        Next

        For i As Integer = 1 To n
            For j As Integer = 1 To target_sum
                If j >= array(i - 1) Then
                    dp(i, j) = dp(i - 1, j) Or dp(i - 1, j - array(i - 1))
                Else
                    dp(i, j) = dp(i - 1, j)
                End If
            Next
        Next

        If dp(n, target_sum) Then
            Dim subset As New List(Of Integer)()
            Dim i As Integer = n
            Dim j As Integer = target_sum
            While i > 0 And j > 0
                If dp(i, j) And Not dp(i - 1, j) Then
                    subset.Add(array(i - 1))
                    j -= array(i - 1)
                End If
                i -= 1
            End While
            Return subset.ToArray()
        End If
        Return Nothing
    End Function

End Class