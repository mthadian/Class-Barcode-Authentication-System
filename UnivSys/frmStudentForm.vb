Imports System.IO
Public Class frmStudentForm
    Implements InterfaceSys
    Dim imgName As String
    Dim result As Single
    Dim perAttendance As Single
    Dim modStudForm As String = "QUERY"
    Dim myStream As New ADODB.Stream
    Private tp As New TabPage("Student Form")
    Private pForm As frmMain


    Private Sub frmStudentForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        frmMain.treeSideMenu.Visible = False
        frmMain.MenuStrip1.Enabled = False
        Me.txtUser.Text = frmLogin.txtUsername.Text
        frmMain.treeSideMenu.Hide()
        btnRegister.Enabled = False
        loadFaculty()
        loadStudent()
        pnlRegUnits.Hide()
        disableRegister()
        loadSpreadAll()

        'TextBox.DefaultFont = New Font("Arial", 9, FontStyle.Bold)
        'loadSpreadRegistered()

        'TreeView1.Font = New Font("Arial", 9, FontStyle.Regular)
    End Sub
    Public Sub loadStudent()
        Dim val As DBNull
        val = DBNull.Value

        myStream = New ADODB.Stream
        myStream.Type = ADODB.StreamTypeEnum.adTypeBinary


        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select * from t_Students where pv_StudRegNo='" & txtUser.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        If Not rs.EOF Then
            txtCourseCode.Text = rs("fv_CourseCode").Value
            txtDepCode.Text = rs("fv_DepCode").Value
            cbxDepartment.Text = rs("fv_DepName").Value
            txtFacCode.Text = rs("fv_FacCode").Value
            cbxFaculty.Text = rs("fv_FacName").Value
            txtStudName.Text = rs("v_StudName").Value
            txtStudRegNo.Text = rs("pv_StudRegNo").Value
            cbxCourse.Text = rs("fv_CourseName").Value
            txtSex.Text = rs("n_Sex").Value
            lblUser.Text = rs("v_StudName").Value

            If Not val.Equals(rs("im_StudPic").Value) Then
                myStream.Open()
                Dim data As Byte() = DirectCast(rs("im_StudPic").Value, Byte())
                Dim ms As New MemoryStream(data)
                PicStude.Image = Image.FromStream(ms)
                PicStude.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                PicStude.Image = Nothing
            End If
            rs.Close()
            rs = Nothing
            myStream = Nothing
        End If

    End Sub


    Private Sub loadFaculty()
        cbxFacSearch.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "select v_FacultyName from t_Faculty"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxFacSearch.Items.Add(rs("v_FacultyName").Value)
            rs.MoveNext()

        Loop
        rs.Close()
        rs = Nothing

    End Sub
    Private Sub loadTime()
        cbxTime.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "select v_Time from t_LecUnits where fv_UnitCode='" & txtUnitCode.Text & "' "
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxTime.Items.Add(rs("v_Time").Value)
            rs.MoveNext()

        Loop
        rs.Close()
        rs = Nothing
    End Sub
    Private Sub loadDep()
        cbxDepSearch.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_DepName from t_Department where v_FacultyName='" & cbxFacSearch.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxDepSearch.Items.Add(rs("v_DepName").Value)
            rs.MoveNext()
        Loop
        rs.Close()
        rs = Nothing

    End Sub
    Public Sub FormCancel() Implements InterfaceSys.FormCancel
        'ClearItems()
        frmMain.ToggleControls(True)
    End Sub
    Public Sub FormEdit() Implements InterfaceSys.FormEdit
        mode = "EDIT"
        frmMain.ToggleControls(False)
        enableStuff()
        'grpboxAddUnits.Enabled = True
    End Sub

    Public Sub FormNew() Implements InterfaceSys.FormNew
        mode = "NEW"
        'clearItems()
        'grpboxAddUnits.Enabled = True
        frmMain.ToggleControls(False)
        enableStuff()
    End Sub

    Public Sub FormSave() Implements InterfaceSys.FormSave
        'Register()
        saveUnits()
    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cbxFacSearch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxFacSearch.SelectedIndexChanged
        sql = "Select * from t_Faculty where v_FacultyName='" & cbxFacSearch.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            'txtFacCode.Text = rs("pv_FacultyCode").Value
            'cbxFaculty.Items.Add(rs("v_FacultyName").Value)
            'cbxFaculty.Text = txtFacCode.Text
        End If
        rs.Close()
        
        loadDep()
    End Sub

    Private Sub cbxDepSearch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxDepSearch.SelectedIndexChanged
        sql = "Select * from t_Department where v_DepName='" & cbxDepSearch.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            'txtDepCode.Text = rs("pv_DepCode").Value
        End If
        rs.Close()
        'txtUnitCode.Text = ""

        loadSpreadUnits()
    End Sub
    Private Sub loadSpreadUnits()
        spreadUnits.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Units where fv_DepName='" & cbxDepSearch.Text & "' "

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF

                spreadUnits.MaxRows = spreadUnits.MaxRows + 1
                spreadUnits.Row = spreadUnits.MaxRows
                spreadUnits.Col = 1
                spreadUnits.TypeButtonText = "Edit"
                spreadUnits.Col = 1
                spreadUnits.Text = rs("pv_UnitCode").Value
                spreadUnits.Col = 2
                spreadUnits.Text = rs("v_UnitName").Value

                'spreadAddUnits.Col = 3
                'spreadAddUnits.Text = rs("fv_DepName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub
   

    Private Sub Register()
        conn.BeginTrans()

        Me.Cursor = Cursors.WaitCursor
        'Dim rs As New ADODB.Recordset
        rs = New ADODB.Recordset
        'If mode = "NEW" Then
        Try

            sql = "select * from t_StudUnits where pv_UnitCode='" & txtUnitCode.Text & "'  AND v_UnitName='" & txtUnitName.Text & "'AND fv_StudReg='" & txtUser.Text & "'"

            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)


            If Not rs.EOF Then
                conn.RollbackTrans()
                Me.Cursor = Cursors.Arrow
                MsgBox("Unitcode exists,please enter different Code", MsgBoxStyle.Information, "Unit code")
                rs.Close()
                Exit Sub
            Else
                rs.AddNew()

                rs("pv_UnitCode").Value = txtUnitCode.Text
                rs("v_UnitName").Value = txtUnitName.Text
                rs("fv_StudReg").Value = txtUser.Text
                rs("fv_Time").Value = cbxTime.Text
                'txtUnitCode.Text = rs("pv_UnitCode").Value
                'txtUnitName.Text = rs("v_UnitName").Value

                'rsReg.Close()
            End If
            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Unit Saved !", MsgBoxStyle.Information, "Unit")
            rs.Close()
        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")
            rs.Close()

        End Try

        rs = Nothing
        'End If
    End Sub
    Private Sub btnRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnRegister.Click

        saveUnits()
        frmMain.ToggleControls(False)
        'loadSpreadAddDB()
        'sql = "SELECT DBO.t_Students.*,dbo.StudUnits.* " & _
        '"FROM dbo.t_Students INNER JOIN dbo.StudUnits " & _
        '"ON dbo.t_Students.pv_StudRegNo = t_StudUnits.fv_StudReg  " & _
        '"WHERE t_StudUnits.fv_StudReg ='" & txtStudRegNo.Text & "' "
        '"WHERE t_StudUnits.pv_UnitCode ='" & txtUnitCode.Text & "' "
        'spreadUnits.ClearSelection()
        disableRegister()
        loadSpreadRegistered()
    End Sub

    Private Sub loadSpreadRegistered()
        spreadMoveUnits.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_StudUnits where fv_StudReg='" & txtUser.Text & "'"
       

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF

                spreadMoveUnits.MaxRows = spreadMoveUnits.MaxRows + 1
                spreadMoveUnits.Row = spreadMoveUnits.MaxRows
                spreadMoveUnits.Col = 1
                spreadMoveUnits.TypeButtonText = "Edit"
                spreadMoveUnits.Col = 1
                spreadMoveUnits.Text = rs("pv_UnitCode").Value
                spreadMoveUnits.Col = 2
                spreadMoveUnits.Text = rs("v_UnitName").Value

                


                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub spreadUnits_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadUnits.ClickEvent
        spreadUnits.Row = spreadUnits.ActiveRow
        spreadUnits.Col = 1


        sql = "SELECT * FROM t_Units where pv_UnitCode= '" & spreadUnits.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtUnitCode.Text = rs("pv_UnitCode").Value
            txtUnitName.Text = rs("v_UnitName").Value

            'cbxDepartment.Text = rs("fv_DepName").Value
            'txtDescri.Text = rs("v_Description").Value

            'grpboxAddUnits.Enabled = False


        Else
            MsgBox("No Unit. Add new")
        End If
        rs.Close()
        btnRegister.Enabled = True
        loadTime()
    End Sub

    Private Sub btnPicBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnPicBrowse.Click
        Dim dlgImage As FileDialog = New OpenFileDialog()
        dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

        If dlgImage.ShowDialog() = DialogResult.OK Then
            imgName = dlgImage.FileName

            Dim newimg As New Bitmap(imgName)

            PicStude.SizeMode = PictureBoxSizeMode.StretchImage
            PicStude.Image = DirectCast(newimg, Image)

        End If

        dlgImage = Nothing
    End Sub
    'Private Sub loadImageFit()
    '    'Dim newimg As New Bitmap(imgName)
    '    PicStude.SizeMode = PictureBoxSizeMode.StretchImage
    '    PicStude.Image = DirectCast(newimg, Image)

    'End Sub

    Private Sub PicStude_Click(sender As System.Object, e As System.EventArgs) Handles PicStude.Click

    End Sub

    Private Sub cbxFaculty_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxFaculty.SelectedIndexChanged

    End Sub
   
    Private Sub saveUnits()
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
                sql = "select * from t_StudUnits where pv_UnitCode='" & txtUnitCode.Text & "'  AND v_UnitName='" & txtUnitName.Text & "'AND fv_StudReg='" & txtUser.Text & "'"


                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Unit exist,please enter different Code", MsgBoxStyle.Information, "Unit code")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()

                     rs("pv_UnitCode").Value = txtUnitCode.Text
                    rs("v_UnitName").Value = txtUnitName.Text
                    rs("fv_StudReg").Value = txtUser.Text
                    rs("fv_Time").Value = cbxTime.Text


                End If
            ElseIf mode = "EDIT" Then
                spreadUnits.Row = spreadUnits.ActiveRow
                spreadUnits.Col = 1
                sql = "select * from t_StudUnits where pv_UnitCode='" & txtUnitCode.Text & "'  AND v_UnitName='" & txtUnitName.Text & "'AND fv_StudReg='" & txtUser.Text & "'"
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Then
                    'Update()
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Item name does not exist", MsgBoxStyle.Information, "Item")
                    rs.Close()
                    Exit Sub
                End If
            End If

            rs("pv_UnitCode").Value = txtUnitCode.Text
            rs("v_UnitName").Value = txtUnitName.Text
            rs("fv_Time").Value = cbxTime.Text
            'rs("fv_DepName").Value = cbxDepartment.Text
            ''rs("v_FacultyName").Value = cbxFaculty.Text
            'rs("fv_DepCode").Value = txtDepCode.Text

            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            'clearItems()
            rs.Close()
            loadSpreadUnits()
            frmMain.ToggleControls(True)

            modStudForm = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try
    End Sub

    Private Sub btnNewUnit_Click(sender As System.Object, e As System.EventArgs) Handles btnNewUnit.Click
        mode = "NEW"
        'clearItems()
        'grpboxAddUnits.Enabled = True
        frmMain.ToggleControls(False)
        enableStuff()

    End Sub
    Private Sub loadSpreadAll()
        spreadLoadAllRegistered.MaxRows = 0
        rs = New ADODB.Recordset
        'sql = "Select * from t_StudUnits where fv_StudReg='" & txtUser.Text & "'"
        sql = "SELECT dbo.t_StudUnits.*,dbo.t_Students.* ,dbo.t_LecUnits.* " & _
       "FROM dbo.t_StudUnits INNER JOIN dbo.t_Students " & _
       "ON dbo.t_StudUnits.fv_StudReg = dbo.t_Students.pv_StudRegNo " & _
       "INNER JOIN dbo.t_LecUnits " & _
       "ON dbo.t_StudUnits.fv_Time=dbo.t_LecUnits.v_Time " & _
       "WHERE dbo.t_StudUnits.fv_StudReg ='" & txtUser.Text & "' "
        'where fv_DepName='" & cbxDepSearch.Text & "' "
        'sql = "Select * from t_StudUnits where fv_StudReg='" & txtUser.Text & "'"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF

                perAttendance = (rs("in_Attendance").Value / rs("in_MaxAttendance").Value) * 100
                If rs("in_Attendance").Value = "0" And rs("in_MaxAttendance").Value = "0" Then
                    result = "0"
                    perAttendance = "0"
                Else
                    result = Math.Round(perAttendance, 2)
                End If

                spreadLoadAllRegistered.MaxRows = spreadLoadAllRegistered.MaxRows + 1
                spreadLoadAllRegistered.Row = spreadLoadAllRegistered.MaxRows
                spreadLoadAllRegistered.Col = 1
                spreadLoadAllRegistered.TypeButtonText = "Edit"
                spreadLoadAllRegistered.Col = 1
                spreadLoadAllRegistered.Text = rs("pv_UnitCode").Value
                spreadLoadAllRegistered.Col = 2
                spreadLoadAllRegistered.Text = rs("v_UnitName").Value

                spreadLoadAllRegistered.Col = 3
                spreadLoadAllRegistered.Text = rs("in_MaxAttendance").Value

                spreadLoadAllRegistered.Col = 4
                spreadLoadAllRegistered.ForeColor = Color.OrangeRed
                If perAttendance > 66 Then spreadLoadAllRegistered.ForeColor = Color.DarkGreen
                spreadLoadAllRegistered.Text = result


                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub
    
    Private Sub btnShowpanel_Click(sender As System.Object, e As System.EventArgs) Handles btnShowpanel.Click
        pnlRegUnits.Show()
    End Sub

    Private Sub btnDoneAdding_Click(sender As System.Object, e As System.EventArgs) Handles btnDoneAdding.Click
        loadSpreadAll()
        pnlRegUnits.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()

        frmMain.Show()
    End Sub

    Private Sub lnkLblChangePic_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub disableRegister()
        cbxFacSearch.Enabled = False
        cbxDepSearch.Enabled = False
        txtUnitCode.Enabled = False
        txtUnitName.Enabled = False
        txtCourseCode.Enabled = False
        txtDepCode.Enabled = False
        txtFacCode.Enabled = False
        txtSex.Enabled = False
        txtStudName.Enabled = False
        txtStudRegNo.Enabled = False
        cbxDepartment.Enabled = False
        cbxFaculty.Enabled = False
        cbxCourse.Enabled = False

    End Sub
    Private Sub enableStuff()
        cbxFacSearch.Enabled = True
        cbxDepSearch.Enabled = True
        txtUnitCode.Enabled = True
        txtUnitName.Enabled = True
    End Sub

    Private Sub frmStudentForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)

    End Sub

    Private Sub frmStudentForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
        'tp.Hide()
    End Sub

    Private Sub spreadLoadAllRegistered_RightClick(sender As System.Object, e As AxFPSpread._DSpreadEvents_RightClickEvent) Handles spreadLoadAllRegistered.RightClick

    End Sub

    Private Sub spreadLoadAllRegistered_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadLoadAllRegistered.ClickEvent
        spreadLoadAllRegistered.Row = spreadLoadAllRegistered.ActiveRow
        spreadLoadAllRegistered.Col = 1


        sql = "SELECT * FROM t_StudUnits where pv_UnitCode= '" & spreadLoadAllRegistered.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtUnitCode.Text = rs("pv_UnitCode").Value
            txtUnitName.Text = rs("v_UnitName").Value
            txtTime.Text = rs("fv_Time").Value

        Else
            MsgBox("No Unit. Add new")
        End If
        rs.Close()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim msgresult As DialogResult
        msgresult = MsgBox(" Delete this Unit?", MessageBoxButtons.YesNo)
        If msgresult = DialogResult.Yes Then
            deleteStuff()
        Else
            loadSpreadAll()
        End If
        

        loadSpreadAll()

    End Sub
    Private Sub deleteStuff()
        Dim rs As New ADODB.Recordset
        Try
            sql = "select * FROM t_StudUnits where pv_UnitCode='" & txtUnitCode.Text & "' AND fv_Time='" & txtTime.Text & "'  AND fv_StudReg='" & txtUser.Text & "' "
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox("Select")
        End Try
        If Not rs.EOF Then
            rs.Delete()
            rs.Close()
        Else
            MsgBox("Please select a Unit")
        End If
    End Sub

End Class