Public Class frmLecLogin

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim rsLogin As New ADODB.Recordset

        sql = "select * from t_Lecturers where pv_LecId='" & txtUsername.Text & "' AND pv_LecId ='" & txtPassword.Text.Trim() & "'"
        rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rsLogin.EOF Then
            'txtPassword.Clear()

            frmLecForm.Show()

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

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLecLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'BringToFront()
    End Sub

    Private Sub frmLecLogin_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BringToFront()
    End Sub
End Class