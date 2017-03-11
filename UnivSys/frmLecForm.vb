Imports System.IO
Public Class frmLecForm
    Implements InterfaceSys
    Dim myStream As New ADODB.Stream
    Dim modLecForm As String = "QUERY"
    Dim MaxAttend As Integer
    Dim perAttendance As Single
    Dim result As Single
    Dim imgName As String
    Private tp As New TabPage("Lecturer Form")
    Private pForm As frmMain
    Private Sub frmLecForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'frmMain.Show()
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        frmMain.MenuStrip1.Enabled = True
        Me.txtUser.Text = frmLogin.txtUsername.Text
        frmMain.treeSideMenu.Hide()
        loadLecturer()
        loadUnits()
        loadSpreadLecUnits()
        loadLecUnits()
    End Sub
    Public Sub loadLecturer()
        Dim val As DBNull
        val = DBNull.Value

        myStream = New ADODB.Stream
        myStream.Type = ADODB.StreamTypeEnum.adTypeBinary


        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        'sql = "Select * from t_Students where pv_StudRegNo='" & txtUser.Text & "'"
        sql = "SELECT dbo.t_Lecturers.*,dbo.t_Department.* ,dbo.t_Faculty.* " & _
        "FROM dbo.t_Lecturers INNER JOIN dbo.t_Department " & _
        "ON dbo.t_Lecturers.fv_DepCode = dbo.t_Department.pv_DepCode " & _
        "INNER JOIN dbo.t_Faculty " & _
        "ON dbo.t_Lecturers.fv_FacCode=dbo.t_Faculty.pv_FacultyCode " & _
        "WHERE dbo.t_Lecturers.pv_LecId ='" & txtUser.Text & "' "

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        If Not rs.EOF Then
            'txtCourseCode.Text = rs("fv_CourseCode").Value
            txtDepCode.Text = rs("fv_DepCode").Value
            cbxDep.Text = rs("v_DepName").Value
            txtFacCode.Text = rs("fv_FacCode").Value
            cbxFaculty.Text = rs("v_FacultyName").Value
            txtLecName.Text = rs("v_LecName").Value
            txtLecId.Text = rs("pv_LecId").Value
            'cbxCourse.Text = rs("fv_CourseName").Value
            txtSex.Text = rs("n_Sex").Value
            lblProfileName.Text = rs("v_LecName").Value

            If Not val.Equals(rs("im_lecPic").Value) Then
                myStream.Open()
                Dim data As Byte() = DirectCast(rs("im_lecPic").Value, Byte())
                Dim ms As New MemoryStream(data)
                PicLec.Image = Image.FromStream(ms)
                PicLec.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                PicLec.Image = Nothing
            End If
            rs.Close()
            rs = Nothing
            myStream = Nothing
        End If

    End Sub
    Private Sub loadSpreadLecUnits()
        spreadLecUnits.MaxRows = 0
        rs = New ADODB.Recordset
        'sql = "Select * from t_Units where fv_DepCode='" & txtDepCode.Text & "' "
        sql = "SELECT dbo.t_LecUnits.*,dbo.t_Department.* ,dbo.t_Units.* " & _
        "FROM dbo.t_LecUnits INNER JOIN dbo.t_Department " & _
        "ON dbo.t_LecUnits.fv_DepCode = dbo.t_Department.pv_DepCode " & _
        "INNER JOIN dbo.t_Units " & _
        "ON dbo.t_LecUnits.fv_UnitCode=dbo.t_Units.pv_UnitCode " & _
        "WHERE dbo.t_LecUnits.fv_LecId ='" & txtUser.Text & "' "

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadLecUnits.MaxRows = spreadLecUnits.MaxRows + 1
                spreadLecUnits.Row = spreadLecUnits.MaxRows
                spreadLecUnits.Col = 1
                spreadLecUnits.TypeButtonText = "Edit"
                spreadLecUnits.Col = 1
                spreadLecUnits.Text = rs("fv_UnitCode").Value
                spreadLecUnits.Col = 2
                spreadLecUnits.Text = rs("v_UnitName").Value

                'spreadLecUnits.Col = 3
                'spreadLecUnits.Text = rs("v_DepName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub



    Public Sub FormCancel() Implements InterfaceSys.FormCancel
        frmMain.ToggleControls(True)
    End Sub

    Public Sub FormEdit() Implements InterfaceSys.FormEdit
        mode = "EDIT"
        frmMain.ToggleControls(False)
    End Sub

    Public Sub FormNew() Implements InterfaceSys.FormNew
        mode = "NEW"
        'clearItems()
        'grpboxAddUnits.Enabled = True
        frmMain.ToggleControls(False)
    End Sub

    Public Sub FormSave() Implements InterfaceSys.FormSave
        saveItems()
    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub
    Private Sub saveItems()
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
                sql = "select * from t_LecUnits where fv_UnitCode='" & txtUnitCode.Text & "'  AND fv_LecId='" & txtUser.Text & "'"
                'rs("pv_FacultyCode").Value = txtFacCode.Text
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                'rs("in_MaxAttendance").Value = "0"
                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Course code exist,please enter different Code", MsgBoxStyle.Information, "Course code")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()
                    rs("fv_LecId").Value = txtLecId.Text

                    rs("fv_DepCode").Value = txtDepCode.Text

                    rs("fv_UnitCode").Value = txtUnitCode.Text
                    rs("v_Day").Value = cbxDay.Text
                    rs("v_Time").Value = txtTime.Text
                    rs("v_Room").Value = txtRoom.Text
                    'rs("in_MaxAttendance").Value = txtAttend.Text


                End If
            ElseIf mode = "EDIT" Then
                spreadLecUnits.Row = spreadLecUnits.ActiveRow
                spreadLecUnits.Col = 1
                sql = "select * from t_LecUnits where fv_UnitCode='" & txtUnitCode.Text & "'"
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

            rs("fv_UnitCode").Value = txtUnitCode.Text
            rs("fv_LecId").Value = txtLecId.Text
            'rs("in_MaxAttendance").Value = txtAttend.Text
            rs("fv_DepCode").Value = txtDepCode.Text
            rs("v_Day").Value = cbxDay.Text
            rs("v_Time").Value = txtTime.Text
            rs("v_Room").Value = txtRoom.Text
            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            clearItems()
            rs.Close()
            loadSpreadLecUnits()
            frmMain.ToggleControls(True)

            modLecForm = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub
    Private Sub clearItems()



        cbxUnitName.Text = ""
        txtUnitCode.Text = ""
    End Sub

    Private Sub PicLec_Click(sender As System.Object, e As System.EventArgs) Handles PicLec.Click
        Dim dlgImage As FileDialog = New OpenFileDialog()
        dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

        If dlgImage.ShowDialog() = DialogResult.OK Then
            imgName = dlgImage.FileName

            Dim newimg As New Bitmap(imgName)

            PicLec.SizeMode = PictureBoxSizeMode.StretchImage
            PicLec.Image = DirectCast(newimg, Image)

        End If

        dlgImage = Nothing
    End Sub

    Private Sub pnlDetails_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlDetails.Paint

    End Sub
    Private Sub loadUnits()
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_UnitName from t_Units where fv_DepCode='" & txtDepCode.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxUnitName.Items.Add(rs("v_UnitName").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
        'txtUnitName.Text = rs("v_UnitName").Value
    End Sub

    Private Sub cbxUnitName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxUnitName.SelectedIndexChanged
        sql = "Select * from t_Units where v_UnitName='" & cbxUnitName.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtUnitCode.Text = rs("pv_UnitCode").Value

        End If
        rs.Close()

    End Sub

    Private Sub btnLogOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOut.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub frmLecForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Me.Enabled = False
        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub spreadLecUnits_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent)
        spreadLecUnits.Row = spreadLecUnits.ActiveRow
        spreadLecUnits.Col = 1


        'sql = "SELECT * FROM t_LecUnits where fv_UnitCode= '" & spreadLecUnits.Text & "'"
        sql = "SELECT dbo.t_LecUnits.*,dbo.t_Department.* ,dbo.t_Units.* " & _
        "FROM dbo.t_LecUnits INNER JOIN dbo.t_Department " & _
        "ON dbo.t_LecUnits.fv_DepCode = dbo.t_Department.pv_DepCode " & _
        "INNER JOIN dbo.t_Units " & _
        "ON dbo.t_LecUnits.fv_UnitCode=dbo.t_Units.pv_UnitCode " & _
        "WHERE dbo.t_LecUnits.fv_UnitCode ='" & spreadLecUnits.Text & "' "
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtUnitCode.Text = rs("fv_UnitCode").Value
            'txtAttend.Text = rs("in_MaxAttendance").Value
            'cbxUnitName.Text = rs("v_UnitName").Value
            ' ''cbxFaculty.Text = rs("v_FacultyName").Value
            ' ''txtFacCode.Text = rs("fv_FacultyCode").Value

        Else
            MsgBox("No Department. Add new")
        End If
        rs.Close()
    End Sub
    Private Sub loadSpreadLecStud()
        spreadStudLec.MaxRows = 0
        rs = New ADODB.Recordset
        
        sql = "SELECT dbo.t_StudUnits.*,dbo.t_Students.* ,dbo.t_LecUnits.* " & _
        "FROM dbo.t_StudUnits INNER JOIN dbo.t_Students " & _
        "ON dbo.t_StudUnits.fv_StudReg = dbo.t_Students.pv_StudRegNo " & _
        "INNER JOIN dbo.t_LecUnits " & _
        "ON dbo.t_StudUnits.pv_UnitCode=dbo.t_LecUnits.fv_UnitCode " & _
        "WHERE dbo.t_LecUnits.fv_UnitCode ='" & cbxUnitStud.Text & "'AND dbo.t_LecUnits.fv_LecId='" & txtUser.Text & "' "

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                perAttendance = (rs("in_Attendance").Value / rs("in_MaxAttendance").Value) * 100
                If rs("in_Attendance").Value = "0" And rs("in_MaxAttendance").Value = "0" Then
                    result = "0"
                Else
                    result = Math.Round(perAttendance, 2)
                End If
                spreadStudLec.MaxRows = spreadStudLec.MaxRows + 1
                spreadStudLec.Row = spreadStudLec.MaxRows
                spreadStudLec.Col = 1
                spreadStudLec.TypeButtonText = "Edit"
                spreadStudLec.Col = 1
                spreadStudLec.Text = rs("fv_StudReg").Value
                spreadStudLec.Col = 2
                spreadStudLec.Text = rs("v_StudName").Value
                spreadStudLec.Col = 3
                spreadStudLec.Text = rs("fv_DepName").Value
                spreadStudLec.Col = 4
                spreadStudLec.Text = result


                'txtStudAtend.text = rs("in_Attendance").Value


                rs.MoveNext()
            Loop

        End If
        rs.Close()

    End Sub
    Private Sub loadLecUnits()
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select fv_UnitCode from t_LecUnits where fv_LecId='" & txtLecId.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxUnitStud.Items.Add(rs("fv_UnitCode").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub cbxUnitStud_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxUnitStud.SelectedIndexChanged
        loadSpreadLecStud()
    End Sub

    Private Sub pnlCourses_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlCourses.Paint

    End Sub

    Private Sub frmLecForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblDay_Click(sender As System.Object, e As System.EventArgs) Handles lblDay.Click

    End Sub

    Private Sub spreadLecUnits_ClickEvent_1(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadLecUnits.ClickEvent
        spreadLecUnits.Row = spreadLecUnits.ActiveRow
        spreadLecUnits.Col = 1


        sql = "SELECT * FROM t_LecUnits where fv_UnitCode= '" & spreadLecUnits.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtUnitCode.Text = rs("fv_UnitCode").Value

            txtTime.Text = rs("v_Time").Value

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
            loadSpreadLecUnits()
        End If


        loadSpreadLecUnits()
    End Sub
    Private Sub deleteStuff()
        Dim rs As New ADODB.Recordset
        Try
            'sql = "select * FROM t_LecUnits where fv_UnitCode='" & txtUnitCode.Text & "' AND v_Time='" & txtTime.Text & "'  AND fv_LecId='" & txtLecId.Text & "' "
            sql = "select * FROM t_LecUnits where fv_UnitCode='" & txtUnitCode.Text & "'  AND fv_LecId='" & txtLecId.Text & "' "
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