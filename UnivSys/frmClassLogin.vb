Public Class frmClassLogin

    Private Sub lblLecLogin_Click(sender As System.Object, e As System.EventArgs) Handles lblLecLogin.Click

    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub lblUserName_Click(sender As System.Object, e As System.EventArgs) Handles lblUserName.Click

    End Sub
    Private Sub lblPassword_Click(sender As System.Object, e As System.EventArgs) Handles lblPassword.Click

    End Sub
    Private Sub txtUsername_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub
    Private Sub txtPassword_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim rsLogin As New ADODB.Recordset

        sql = "select * from t_Lecturers where pv_LecId='" & txtUsername.Text & "' AND pv_LecId ='" & txtPassword.Text.Trim() & "'"
        rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rsLogin.EOF Then
            'txtPassword.Clear()

            frmClass.Show()

        ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Enter Username and password")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Please enter username")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Enter password")

        End If
        rsLogin.Close()
        Me.Close()
    End Sub
    
    Private Sub frmClassLogin_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles MyBase.Scroll

    End Sub

    Private Sub frmClassLogin_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BringToFront()
    End Sub

    Private Sub frmClassLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class