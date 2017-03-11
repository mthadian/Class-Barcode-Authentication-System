Public Class frmLogin
    Private Sub clearStuff()
        cbxRole.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub login()
        Select Case cbxRole.Text
            Case "LECTURER"
                
                Dim rsLogin As New ADODB.Recordset
                sql = "select * from t_Users where v_UserName='" & txtUsername.Text & "' AND v_Password ='" & txtPassword.Text & "'AND v_role='" & cbxRole.Text & "'"

                rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rsLogin.EOF Then

                    frmLecForm.MdiParent = frmMain
                    frmLecForm.Dock = DockStyle.Fill
                    frmMain.btnClose.Enabled = True
                    frmMain.btnLogOut.Enabled = True
                    frmLecForm.Show()


                Else

                    MsgBox("Wrong Login Credentials", MsgBoxStyle.Information, "LECTURER")
                    clearStuff()
                    Exit Sub
                End If
                rsLogin.Close()
                Me.Close()
            Case "STUDENT"
                Dim rsLogin As New ADODB.Recordset
                sql = "select * from t_Users where v_UserName='" & txtUsername.Text & "' AND v_Password ='" & txtPassword.Text & "'AND v_role='" & cbxRole.Text & "'"

                rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rsLogin.EOF Then
                    frmStudentForm.MdiParent = frmMain
                    frmStudentForm.Dock = DockStyle.Fill
                    frmMain.btnClose.Enabled = True
                    frmMain.btnLogOut.Enabled = True
                    'frmMain.MenuStrip1.Enabled = True
                    frmStudentForm.Show()

                Else
                    MsgBox("Wrong Login Credentials", MsgBoxStyle.Information, "STUDENT")
                    clearStuff()
                    Exit Sub
                End If
                rsLogin.Close()
                Me.Close()
            Case "ADMIN"
                Dim rsLogin As New ADODB.Recordset
                sql = "select * from t_Users where v_UserName='" & txtUsername.Text & "' AND v_Password ='" & txtPassword.Text & "'AND v_role='" & cbxRole.Text & "'"

                rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rsLogin.EOF Then
                    'txtPassword.Clear()
                    frmMain.treeSideMenu.Visible = True
                    frmMain.btnClose.Enabled = True
                    frmMain.btnLogOut.Enabled = True
                    frmMain.MenuStrip1.Enabled = True
                    frmMain.Show()

                Else
                    MsgBox("Wrong Login Credentials", MsgBoxStyle.Information, "ADMINISTRATOR")
                    clearStuff()
                    Exit Sub
                End If
                rsLogin.Close()
                Me.Close()
            Case "DEPARTMENT HEAD"
                Dim rsLogin As New ADODB.Recordset
                sql = "select * from t_Users where v_UserName='" & txtUsername.Text & "' AND v_Password ='" & txtPassword.Text & "'AND v_role='" & cbxRole.Text & "'"

                rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rsLogin.EOF Then
                    'txtPassword.Clear()
                    frmDephead.MdiParent = frmMain
                    frmDephead.Dock = DockStyle.Fill
                    frmMain.btnClose.Enabled = True
                    frmMain.btnLogOut.Enabled = True
                    frmDephead.Show()

                Else
                    MsgBox("Wrong Login Credentials", MsgBoxStyle.Information, "DEPARTMENT HEAD")
                    clearStuff()
                    Exit Sub
                End If
                rsLogin.Close()
                Me.Close()
            Case "CLASS"
                Dim rsLogin As New ADODB.Recordset
                sql = "select * from t_Users where v_UserName='" & txtUsername.Text & "' AND v_Password ='" & txtPassword.Text & "'AND v_role='" & cbxRole.Text & "'"

                rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If Not rsLogin.EOF Then
                    'txtPassword.Clear()
                    frmClass.MdiParent = frmMain
                    frmClass.Dock = DockStyle.Fill
                    frmMain.btnClose.Enabled = True
                    frmMain.btnLogOut.Enabled = True
                    frmClass.Show()

                Else
                    MsgBox("Wrong Login Credentials", MsgBoxStyle.Information, "CLASS")
                    clearStuff()
                    Exit Sub
                End If
                rsLogin.Close()
                Me.Close()
        End Select
       
    End Sub
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        'frmLecForm.MdiParent = Me
        'frmLecForm.Dock = DockStyle.Fill
        login()
        
    End Sub
    

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMain.Close()
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        frmMain.treeSideMenu.Visible = False
        pnlUpdate.Hide()
        frmMain.btnClose.Enabled = False
        frmMain.btnLogOut.Enabled = False
        'pForm = Me.ParentForm
        'pForm.AddTabPage(tp)
        'LoadRoles()
        BringToFront()


    End Sub

    
    Private Sub frmLogin_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        'BringToFront()
    End Sub

    Private Sub frmLogin_MdiChildActivate(sender As System.Object, e As System.EventArgs) Handles MyBase.MdiChildActivate
        'BringToFront()
    End Sub

    Private Sub frmLogin_ParentChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.ParentChanged
        'BringToFront()
    End Sub

    Private Sub frmLogin_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BringToFront()
    End Sub

    Private Sub lnkUpdatePW_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUpdatePW.LinkClicked
        pnlUpdate.Show()
    End Sub

    Private Sub UpdatePassWord()

        Select Case cbxRole.Text
            Case "LECTURER"
                Dim rsLogin As New ADODB.Recordset
                Try
                    If cbxRole.Visible Then
                        sql = "select * from t_Users where v_UserName='" & txtUser.Text & "' AND v_Password ='" & txtOldPW.Text & "'AND v_role='" & cbxRole.Text & "'"

                        rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        If Not rsLogin.EOF Then
                            If txtNewPW1.Text = txtNewPW2.Text Then
                                rsLogin("v_Password").Value = txtNewPW2.Text
                                rsLogin.Update()
                                MsgBox("Password updated")
                            Else
                                MsgBox("Passwords don't match!")
                                Exit Sub
                            End If
                        Else
                            MsgBox("Check your Credentials!")

                        End If
                    End If
                    rsLogin.Close()
                    Exit Sub
                    Me.Close()
                Catch ex As Exception
                    MsgBox("You chose the Wrong Role")
                End Try

            Case "STUDENT"
                Dim rsLogin As New ADODB.Recordset
                Try
                    If cbxRole.Visible Then
                        sql = "select * from t_Users where v_UserName='" & txtUser.Text & "' AND v_Password ='" & txtOldPW.Text & "'AND v_role='" & cbxRole.Text & "'"

                        rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        If Not rsLogin.EOF Then
                            If txtNewPW1.Text = txtNewPW2.Text Then
                                rsLogin("v_Password").Value = txtNewPW2.Text
                                rsLogin.Update()
                                MsgBox("Password updated")
                            Else
                                MsgBox("Passwords don't match!")
                                Exit Sub
                            End If
                        Else
                            MsgBox("Check your Credentials!")

                        End If
                    End If
                    rsLogin.Close()
                    Exit Sub
                    Me.Close()
                Catch ex As Exception
                    MsgBox("You chose the Wrong Role")
                End Try

            Case "ADMIN"
                Dim rsLogin As New ADODB.Recordset
                Try
                    If cbxRole.Visible Then
                        sql = "select * from t_Users where v_UserName='" & txtUser.Text & "' AND v_Password ='" & txtOldPW.Text & "'AND v_role='" & cbxRole.Text & "'"

                        rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        If Not rsLogin.EOF Then
                            If txtNewPW1.Text = txtNewPW2.Text Then
                                rsLogin("v_Password").Value = txtNewPW2.Text
                                rsLogin.Update()
                                MsgBox("Password updated")
                            Else
                                MsgBox("Passwords don't match!")
                                Exit Sub
                            End If
                        Else
                            MsgBox("Check your Credentials!")

                        End If
                    End If
                    rsLogin.Close()
                    Exit Sub
                    Me.Close()
                Catch ex As Exception
                    MsgBox("You chose the Wrong Role")
                End Try

            Case "DEPARTMENT HEAD"
                Dim rsLogin As New ADODB.Recordset
                Try
                    If cbxRole.Visible Then
                        sql = "select * from t_Users where v_UserName='" & txtUser.Text & "' AND v_Password ='" & txtOldPW.Text & "'AND v_role='" & cbxRole.Text & "'"

                        rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        If Not rsLogin.EOF Then
                            If txtNewPW1.Text = txtNewPW2.Text Then
                                rsLogin("v_Password").Value = txtNewPW2.Text
                                rsLogin.Update()
                                MsgBox("Password updated")
                            Else
                                MsgBox("Passwords don't match!")
                                Exit Sub
                            End If
                        Else
                            MsgBox("Check your Credentials!")

                        End If
                    End If
                    rsLogin.Close()
                    Exit Sub
                    Me.Close()
                Catch ex As Exception
                    MsgBox("You chose the Wrong Role")
                End Try
            Case "CLASS"
                Dim rsLogin As New ADODB.Recordset
                Try
                    If cbxRole.Visible Then
                        sql = "select * from t_Users where v_UserName='" & txtUser.Text & "' AND v_Password ='" & txtOldPW.Text & "'AND v_role='" & cbxRole.Text & "'"

                        rsLogin.Open(sql, cnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                        If Not rsLogin.EOF Then
                            If txtNewPW1.Text = txtNewPW2.Text Then
                                rsLogin("v_Password").Value = txtNewPW2.Text
                                rsLogin.Update()
                                MsgBox("Password updated")
                            Else
                                MsgBox("Passwords don't match!")
                                Exit Sub
                            End If
                        Else
                            MsgBox("Check your Credentials!")

                        End If
                    End If
                    rsLogin.Close()
                    Exit Sub
                    Me.Close()
                Catch ex As Exception
                    MsgBox("You chose the Wrong Role")
                End Try



            Case Else
                MsgBox("Select a Role please!")
                Exit Sub
        End Select



    End Sub
    Private Sub btnUpdatePw_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdatePw.Click
        UpdatePassWord()
    End Sub
   

    Private Sub cbxRole_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxRole.SelectedIndexChanged

    End Sub
End Class